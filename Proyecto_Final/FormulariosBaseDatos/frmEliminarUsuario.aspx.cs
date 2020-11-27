using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.BL;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.Formularios
{
    public partial class frmEliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Cargar Usuario Obtenido Por ID
            CargarUsuario();
        }

        void CargarUsuario()
        {
            ///Obtener El Parametro De Consulta Seleccionado Desde
            ///Formulario UsuarioLista
            
            string parametro = this.Request.QueryString["IdUsuario"];
            ///Validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Lanzar Alerta De Que No Hay Ningun Parametro
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                ///Convertir La Variable De Consulta A INT
                int IdUsuario = Convert.ToInt16(parametro);
                /// Se Crea Una Instancia De BLUsuarios
                BLusuarios usuarioObtenido = new BLusuarios();
                /// Se Crea Una Instancia Del Modelo De BD
                sp_RetornaUsuarioID_Result resultUsuario = new sp_RetornaUsuarioID_Result();
                ///Invocar Al Procedimiento Almacenado
                ///Que Retorna Un Usuario Por ID De La Clase BL
                ///Y Se Asigna A Result
                resultUsuario = usuarioObtenido.RetornaUsuarioID(IdUsuario);
                ///Si RESULT Es Vacio Redireccionar A UsuarioLista 
                if (resultUsuario == null)
                {
                    Response.Redirect("frmUsuarioLista.aspx");
                }
                else
                {
                    ///Se Asignan A Los TextBox Los Datos Del Usuario Obtenido
                    this.txtTipoEmpleado.Text = resultUsuario.TipoUsuario.ToString();
                    this.txtNombre.Text = resultUsuario.Nombre;
                    this.txtPrimerApellido.Text = resultUsuario.PrimerApellido;
                    this.txtSegundoApellido.Text = resultUsuario.SegundoApellido;
                    this.txtCedula.Text = resultUsuario.Cedula;
           
                }
            }
            

        }
        /// <summary>
        /// Evento Que Eliminara Un Registro
        /// </summary>
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}