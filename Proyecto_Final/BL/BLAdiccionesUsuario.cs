using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.BL
{
    public class BLAdiccionesUsuario
    {
        /// <summary>
        /// Modelo De Entity Framework
        ///  segurosEntities1 es el modelo Base Datos
        ///  y el Objeto modeloBD
        /// </summary>
        segurosEntities1 modeloBD = new segurosEntities1();

        /// <summary>
        /// Metodo Que Invoca El Store Procedure Que Retorna adicciones por usuario
        /// Pasando Dos Parametros Como Busqueda
        /// </summary>
        /// <param name="pIdAdicciones"></param>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public List<sp_RetornaAdiccionUsuario_Result> RetornaAdiccionesUsuario(int pIdAdicciones, int pIdUsuario)
        {
            List<sp_RetornaAdiccionUsuario_Result> resultado = this.modeloBD.sp_RetornaAdiccionUsuario(pIdAdicciones, pIdUsuario).ToList();

            return resultado;
        }


        /// <summary>
        /// Retorna El Registro De Una Adiccion por Usuario Por Medio Del Procedemiento Almacenado
        /// 
        /// </summary>
        /// <param name="pIdIdentificador"></param>
        /// <returns></returns>
        public sp_RetornaAdiccionUsuarioID_Result sp_RetornaAdiccionesUsuarioID(int pIdIdentificador)
        {
            sp_RetornaAdiccionUsuarioID_Result resultado = new sp_RetornaAdiccionUsuarioID_Result();
            resultado = this.modeloBD.sp_RetornaAdiccionUsuarioID(pIdIdentificador).FirstOrDefault();
            return resultado;
        }
        /// <summary>
        /// Metodod Booleano Que Inserta la adiccion por usuario
        /// </summary>
        public bool InsertaAdiccionesUsuario(int pIdAdicciones, int pIdUsuario)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert / update/ delete la cantidad de 
            ///registros afectados debe ser mayor a 0

            int registrosAfectados = 0;

            /// invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_InsertAdiccionUsuario(
                   pIdAdicciones,
                   pIdUsuario 
                    );

            if (registrosAfectados > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodod Booleano Que Modifica la  Adicciones Usuario
        /// </summary>
        public bool ModificaAdiccionesUsuario(int pIdIdentificador, int pIdAdicciones, int pIdUsuario)
        {
            ///Crear La variable Que Se Retornara
            int resultado = 0;
            ///Asignar A La Variable El Resultado Del LLamado Al Procedimiento Almacenado
            resultado = this.modeloBD.spModificaAdiccionUsuario(
                pIdIdentificador,
                pIdAdicciones,
                pIdUsuario
                );
            ///Retornar El Valor 
            ///Si Se Ingreso Datos o No
            return resultado > 0;
        }
        /// <summary>
        /// Metodod Booleano Que Elimina la adiccion por usuario
        /// </summary>
        public bool EliminaAdiccionesUsuario(int pIdIdentificador)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_EliminaAdiccionUsuario(pIdIdentificador);

            return registrosAfectados > 0;

        }

    }
}