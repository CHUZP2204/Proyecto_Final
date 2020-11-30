using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.BL
{
    public class BLCobertura
    {
        /// <summary>
        /// Modelo De Entity Framework
        ///  segurosEntities1 es el modelo Base Datos
        ///  y el Objeto modeloBD
        /// </summary>
        segurosEntities1 modeloBD = new segurosEntities1();

        /// <summary>
        /// Metodo Que Invoca El Store Procedure Que Retorna Coberturas
        /// Pasando Dos Parametros Como Busqueda
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pPorcentaje"></param>
        /// <returns></returns>
        public List<sp_RetornaCobertura_Result> RetornaCobertura(string pNombre = null, string pPorcentaje = null)
        {
            ///Se Crea La Variable Que Retorna
            List<sp_RetornaCobertura_Result> resultado = new List<sp_RetornaCobertura_Result>();
            /// Se Invoca El Store Procedure y Se Le Pasan Los Parametros
            resultado = this.modeloBD.sp_RetornaCobertura(pNombre,pPorcentaje).ToList();

            return resultado;
        }

        /// <summary>
        /// Metodod Booleano Que Inserta la Cobertura
        /// </summary>
        public bool InsertaCobertura(string pNombre, string pDescripcion, string pPorcentaje)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert / update/ delete la cantidad de 
            ///registros afectados debe ser mayor a 0

            int registrosAfectados = 0;

            /// invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_InsertaCoberturas(
                   pNombre,
                   pDescripcion,
                   pPorcentaje
                    );

            if (registrosAfectados > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Retorna El Registro De Una cobertura Por Medio Del Procedemiento Almacenado
        /// 
        /// </summary>
        /// <param name="pIdCobertura"></param>
        /// <returns></returns>
        public sp_RetornaCoberturaID_Result RetornaCoberturaID(int pIdCobertura)
        {
            ///Crear La Variable Que Va Retornar
            sp_RetornaCoberturaID_Result resultado = new sp_RetornaCoberturaID_Result();

            /*
             * asignarle a la variable el resultado del llamado del procedemiento almacenado
             * es necesario incluir la instruccion FirstOrDefault
             * para que retorne un unico registro, ya que EF asume que siempre se retornan
             * "n" registros en los procedimientos almacenados que ejecutan las sentenecia
             * select
             
             */
            resultado =
                this.modeloBD.sp_RetornaCoberturaID(pIdCobertura).FirstOrDefault();
            ///Se Indica Que Retorne El Primero O Efecto Nulo

            return resultado;
        }

        /// <summary>
        /// Metodod Booleano Que Modifica la Cobertura
        /// </summary>
        public bool ModificaCobertura(int pIdCobertura, string pNombre, string pDescripcion, string pPorcentaje)
        {
            ///Crear La variable Que Se Retornara
            int resultado = 0;
            ///Asignar A La Variable El Resultado Del LLamado Al Procedimiento Almacenado
            resultado = this.modeloBD.spModificaCoberturas(
                pIdCobertura,
                pNombre,
                pDescripcion,
                pPorcentaje
                );
            ///Retornar El Valor 
            ///Si Se Ingreso Datos o No
            return resultado > 0;
        }
        public bool EliminaCobertura(int pIdCobertura)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_EliminaCoberturas(pIdCobertura);

            return registrosAfectados > 0;

        }

    }
}