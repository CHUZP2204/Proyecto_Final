using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.BL
{
    public class BLusuarios
    {
        segurosEntities1 modeloBD = new segurosEntities1();
        
       public bool ModificaUsuario
            (int pIdUsuario,
             string pCedula,
             string pGenero,
             DateTime pFecha,
             string pNombre,
             string pPrimerApellido,
             string pSegundoApellido,
             string pDireccion,
             string pTelefono1,
             string pTelefono2,
             string pCorreo,
             string pTipoUsuario)
        {
            ///Crear La variable Que Se Retornara
            int resultado = 0;
            ///Asignar A La Variable El Resultado Del LLamado Al Procedimineto Almacenado
            resultado = this.modeloBD.spModificaUsuario(
                pIdUsuario, 
                pCedula,
                pGenero,
                pFecha,
                pNombre,
                pPrimerApellido,
                pSegundoApellido,
                pDireccion,
                pTelefono1,
                pTelefono2,
                pCorreo,
                pTipoUsuario);
            ///Retornar El Valor 
            if (resultado > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}