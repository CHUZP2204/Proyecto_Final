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

        public List<sp_RetornaAdiccionUsuario_Result> RetornaAdiccionesUsuario(int pIdAdicciones, int pIdUsuario)
        {
            List<sp_RetornaAdiccionUsuario_Result> resultado = this.modeloBD.sp_RetornaAdiccionUsuario(pIdAdicciones, pIdUsuario).ToList();

            return resultado;
        }



        public sp_RetornaAdiccionUsuarioID_Result sp_RetornaAdiccionesUsuarioID(int pIdIdentificador)
        {
            sp_RetornaAdiccionUsuarioID_Result resultado = new sp_RetornaAdiccionUsuarioID_Result();
            resultado = this.modeloBD.sp_RetornaAdiccionUsuarioID(pIdIdentificador).FirstOrDefault();
            return resultado;
        }








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