using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.BL
{
    public class BLPolizas
    {
        /// <summary>
        /// Modelo De Entity Framework
        ///  segurosEntities1 es el modelo Base Datos
        ///  y el Objeto modeloBD
        /// </summary>
        segurosEntities1 modeloBD = new segurosEntities1();

        /// <summary>
        /// Metodo Que Invoca El Store Procedure Que Retorna Las polizas
        /// Pasando Dos Parametros Como Busqueda
        /// </summary>
        /// <param name="pMontoAsegurado"></param>
        /// <param name="pPorcentajeCobertura"></param>
        /// <returns></returns>
        public List<sp_retornaRegistroPoliza_Result> retornaPoliza(string pMontoAsegurado = null, string pPorcentajeCobertura = null)
        {
            ///Se Crea La Variable Que Retorna
            List<sp_retornaRegistroPoliza_Result> resultado = new List<sp_retornaRegistroPoliza_Result>();
            /// Se Invoca El Store Procedure y Se Le Pasan Los Parametros
            resultado = this.modeloBD.sp_retornaRegistroPoliza(pMontoAsegurado, pPorcentajeCobertura).ToList();

            return resultado;
        }

        /// <summary>
        /// Retorna El Registro De una poliza Por Medio Del Procedemiento Almacenado
        /// 
        /// </summary>
        /// <param name="pidRegistro"></param>
        /// <returns></returns>
        public sp_RetornaRegistroPolizaID_Result sp_RetornaRegistroPolizaID_(int pidRegistro)
        {
            ///Crear La Variable Que Va Retornar
            sp_RetornaRegistroPolizaID_Result resultado = new sp_RetornaRegistroPolizaID_Result();

            /*
             * asignarle a la variable el resultado del llamado del procedemiento almacenado
             * es necesario incluir la instruccion FirstOrDefault
             * para que retorne un unico registro, ya que EF asume que siempre se retornan
             * "n" registros en los procedimientos almacenados que ejecutan las sentenecia
             * select
             
             */
            resultado =
                this.modeloBD.sp_RetornaRegistroPolizaID(pidRegistro).FirstOrDefault();
            ///Se Indica Que Retorne El Primero O Efecto Nulo

            return resultado;
        }
        /// <summary>
        /// Metodo Booleano Que Modifica Una Poliza
        /// </summary>
        public bool InsertaPoliza(
         string pMontoAsegurado,
       string pPorcentajeCobertura,
       int pNumeroAdicciones,
      string pMontoAdicciones,
       string pPrimaAntesImpu,
       string pImpuestos,
      string pPrimaFinal,
        int pIdSeguro,
        int pIdUsuario,
       int  pIdCobertura)

        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert / update/ delete la cantidad de 
            ///registros afectados debe ser mayor a 0

            int registrosAfectados = 0;

            /// invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_InsertaRegistroPoliza(
                    pMontoAsegurado,
                    pPorcentajeCobertura,
                    pNumeroAdicciones,
                    pMontoAdicciones,
                    pPrimaAntesImpu,
                    pImpuestos,
                    pPrimaFinal,
                    pIdSeguro,
                    pIdUsuario,
                    pIdCobertura
                    );

            if (registrosAfectados > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodo Booleano Que Modifica Una poliza
        public bool ModificaPoliza(int pIdRegistro, 
          string pMontoAsegurado,
       string pPorcentajeCobertura,
       int pNumeroAdicciones,
      string pMontoAdicciones,
       string pPrimaAntesImpu,
       string pImpuestos,
      string pPrimaFinal,
        int pIdSeguro,
        int pIdUsuario,
       int pIdCobertura)
        {
            ///Crear La variable Que Se Retornara
            int resultado = 0;
            ///Asignar A La Variable El Resultado Del LLamado Al Procedimiento Almacenado
            resultado = this.modeloBD.sp_ModificaRegistroPolizaID(
                    pIdRegistro,
                    pMontoAsegurado,
                    pPorcentajeCobertura,
                    pNumeroAdicciones,
                    pMontoAdicciones,
                    pPrimaAntesImpu,
                    pImpuestos,
                    pPrimaFinal,
                    pIdSeguro,
                    pIdUsuario,
                    pIdCobertura
                );
            ///Retornar El Valor 
            ///Si Se Ingreso Datos o No
            return resultado > 0;
        } 
            
        /// <summary>
        /// Metodo que elimina una poliza
        /// </summary>
        /// <param name="pIdRegistro"></param>
        /// <returns></returns>
         
        public bool EliminaPoliza(int pIdRegistro)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_Elimina_RegistroPolizaID(pIdRegistro);

            return registrosAfectados > 0;

        }
    }
}