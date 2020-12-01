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
        //public bool InsertaPoliza(string pCedula, string pGenero, DateTime pFecha, string pnombre, string pprimerApellido, string psegundoApellido,

        //  string pDireccion, string ptelefono1, string ptelefono2, string pCorreo, string pTipoUsuario, string pContrasenia)


        //{
        //    ///variable que posee la cantidad de registros afectados
        //    ///al realizar insert / update/ delete la cantidad de 
        //    ///registros afectados debe ser mayor a 0

        //    int registrosAfectados = 0;

        //    /// invocar al procedimiento almacenado
        //    registrosAfectados =
        //        this.modeloBD.sp_InsertaUsuario(
        //            pCedula,
        //            pGenero,
        //            pFecha,
        //            pnombre,
        //            pprimerApellido,
        //            psegundoApellido,
        //            pDireccion,
        //            ptelefono1,
        //            ptelefono2,
        //            pCorreo,
        //            pTipoUsuario,
        //            pContrasenia
        //            );

        //    if (registrosAfectados > 0)
        //        return true;
        //    else
        //        return false;
        //}

    }
}