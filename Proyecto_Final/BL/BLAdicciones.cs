﻿using System;
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
    }
    
}