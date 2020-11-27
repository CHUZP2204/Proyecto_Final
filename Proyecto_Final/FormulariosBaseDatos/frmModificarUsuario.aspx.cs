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
    public partial class frmModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        void CargarUsuario()
        {

            string parametro = this.Request.QueryString["IdUsuario"];
            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                int IdUsuario = Convert.ToInt16(parametro);
                BLusuarios usuarioObtenido = new BLusuarios();
                sp_RetornaUsuarioID_Result resultUsuario = new sp_RetornaUsuarioID_Result();
                ///invocar al procedimiento
                resultUsuario = usuarioObtenido.RetornaUsuarioID(IdUsuario);
                if (resultUsuario == null)
                {
                    Response.Redirect("frmUsuarioLista.aspx");
                }
                else
                {
                    //this.txtIdUsuario.Text = resultUsuario.IdUsuario.ToString();
                    this.txtNombre.Text = resultUsuario.Nombre;
                    this.txtPrimerApellido.Text = resultUsuario.PrimerApellido;
                    this.txtSegundoApellido.Text = resultUsuario.SegundoApellido;
                    this.txtCedula.Text = resultUsuario.Cedula;
                    this.txtfechanacimiento.Text = resultUsuario.FechaNacimiento.ToString();
                    this.txtdireccion.Text = resultUsuario.Direccion;
                    this.txtTelefonoprincipal.Text = resultUsuario.TelefonoPrincipal;
                    this.txtTelefonosecundario.Text = resultUsuario.TelefonoSecundario;
                    this.txtcorreo.Text = resultUsuario.Correo;
                    this.txtContrasenia.Text = resultUsuario.Contrasenia;
                    this.ddlgenero.SelectedValue = resultUsuario.Genero;
                    this.LstTipoUsuario.SelectedValue = resultUsuario.TipoUsuario;
                }

            }


        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}