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
        /// <summary>
        /// Modelo De Entity Framework
        ///  segurosEntities1 es el modelo Base Datos
        ///  y el Objeto modeloBD
        /// </summary>
        segurosEntities1 modeloBD = new segurosEntities1();

        /// <summary>
        /// Metodo Que Invoca El Store Procedure Que Retorna Los Usuarios
        /// Pasando Dos Parametros Como Busqueda
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pPrimerApellido"></param>
        /// <returns></returns>
        public List<sp_RetornaUsuario_Result> retornaUsuario(string pNombre = null, string pPrimerApellido = null)
        {
            ///Se Crea La Variable Que Retorna
            List<sp_RetornaUsuario_Result> resultado = new List<sp_RetornaUsuario_Result>();
            /// Se Invoca El Store Procedure y Se Le Pasan Los Parametros
            resultado = this.modeloBD.sp_RetornaUsuario(pPrimerApellido, pNombre).ToList();

            return resultado;
        }

        public bool InsertaUsuario(string pCedula, string pGenero, DateTime pFecha, string pnombre, string pprimerApellido, string psegundoApellido,

           string pDireccion, string ptelefono1, string ptelefono2, string pCorreo, string pTipoUsuario, string pContrasenia)


        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert / update/ delete la cantidad de 
            ///registros afectados debe ser mayor a 0

            int registrosAfectados = 0;

            /// invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_InsertaUsuario(
                    pCedula,
                    pGenero,
                    pFecha,
                    pnombre,
                    pprimerApellido,
                    psegundoApellido,
                    pDireccion,
                    ptelefono1,
                    ptelefono2,
                    pCorreo,
                    pTipoUsuario,
                    pContrasenia
                    );

            if (registrosAfectados > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodod Booleano Que Modifica Un Usuario
        /// </summary>
        /// <param name="pIdUsuario">Parametro Principal Por El Cual Se 
        /// Editara Un Usuario En Especifico</param>
        /// <param name="pCedula"></param>
        /// <param name="pGenero"></param>
        /// <param name="pFecha"></param>
        /// <param name="pNombre"></param>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pSegundoApellido"></param>
        /// <param name="pDireccion"></param>
        /// <param name="pTelefono1"></param>
        /// <param name="pTelefono2"></param>
        /// <param name="pCorreo"></param>
        /// <param name="pTipoUsuario"></param>
        /// <returns></returns>
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
             string pTipoUsuario,
             string pContrasenia)
        {
            ///Crear La variable Que Se Retornara
            int resultado = 0;
            ///Asignar A La Variable El Resultado Del LLamado Al Procedimiento Almacenado
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
                pTipoUsuario,
                pContrasenia);
            ///Retornar El Valor 
            ///Si Se Ingreso Datos o No
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Retorna El Registro De Un Cliente Por Medio Del Procedemiento Almacenado
        /// sp_RetronaClienteID
        /// </summary>
        /// <param name="pIUsuario"></param>
        /// <returns></returns>
        public sp_RetornaUsuarioID_Result RetornaUsuarioID(int pIdUsuario)
        {
            ///Crear La Variable QUe Va Retornar
            sp_RetornaUsuarioID_Result resultado = new sp_RetornaUsuarioID_Result();

            /*
             * asignarle a la variable el resultado del llamado del procedemiento almacenado
             * es necesario incluir la instruccion FirstOrDefault
             * para que retorne un unico registro, ya que EF asume que siempre se retornan
             * "n" registros en los procedimientos almacenados que ejecutan las sentenecia
             * select
             
             */
            resultado =
                this.modeloBD.sp_RetornaUsuarioID(pIdUsuario).FirstOrDefault();
            ///Se Indica Que Retorne El Primero O Efecto Nulo

            return resultado;
        }
        /*   public List<sp_RetornaUsuario_Result> retornaUsuarios(string pNombre,string apel)
           {

           } 
        */

    }
}

