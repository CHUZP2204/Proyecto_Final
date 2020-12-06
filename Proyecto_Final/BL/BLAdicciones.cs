using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Proyecto_Final.Modelo;

namespace Proyecto_Final
{
    public class BLAdicciones
    {
        /// <summary>
        /// Modelo De Entity Framework
        ///  segurosEntities1 es el modelo Base Datos
        ///  y el Objeto modeloBD
        /// </summary>
        segurosEntities1 modeloBD = new segurosEntities1();

        public List<sp_RetornaAdicciones_Result> RetornaAdicciones(string pNombre,string pCodigo)
        {
            List<sp_RetornaAdicciones_Result> resultado = this.modeloBD.sp_RetornaAdicciones(pNombre,pCodigo).ToList();

            return resultado;
        }

       

        public sp_RetornaAdiccionesID_Result sp_RetornaAdiccionesID(int pidAdicciones )
        {
            sp_RetornaAdiccionesID_Result resultado = new sp_RetornaAdiccionesID_Result();
            resultado = this.modeloBD.sp_RetornaAdiccionesID(pidAdicciones).FirstOrDefault();
            return resultado;
        }


        /// <summary>
        /// metodo booleano que  inserta un adiccion
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        public bool InsertaAdiccion(string pNombre, string pCodigo)

        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert / update/ delete la cantidad de 
            ///registros afectados debe ser mayor a 0

            int registrosAfectados = 0;

            /// invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.spInsertaAdicciones(
                    pNombre,
                    pCodigo
                    );

            if (registrosAfectados > 0)
                return true;
            else
                return false;
        }

        public bool ModificaAdiccion(int pidAdicciones, string pNombre, string pCodigo)
        {
            int registrosAfectados = 0;

            registrosAfectados =
                this.modeloBD.sp_ModificaAdicciones(
                    pidAdicciones,
                    pNombre,
                    pCodigo);

            return registrosAfectados > 0;
        }

        public bool EliminaAdiccion(int pidAdicciones)
        {   
            ///variable que posee la cantidad de registros afectados
            /////registros debe ser mayor a 0
            int registrosAfectados = 0;
            // invocar al sp 
            registrosAfectados =
                this.modeloBD.sp_EliminaAdiccionesID(
                    pidAdicciones);

            return registrosAfectados > 0;
        }

    }
    
}