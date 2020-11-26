using Proyecto_Final.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final.Formularios
{
    public partial class frmInsertUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// No Se Muestra El Hyperlink Si Se Llama el formulario desde La Pantalla Login 
            /// Cuando Un Usuario Se Quiera Ver La Lista De Usuarios
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.hplstUsers.Visible = false;
            }
            /// No Se Mostrara El HyperLink Si ya Hay Un Usuario Logueado
            /// Porque Este Re-Direcciona a La Pantalla Login
            if (Convert.ToBoolean(this.Session["usuariologueado"]) == true)
            {
                this.hplAtrasInicio.Visible = false;
            }
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                string mensaje = "";
                BLusuarios oUsuario = new BLusuarios();
                bool resultado = false;
                try
                {
                    ///obtener los valores seleccionados por el usuario
                    ///se toma de la propiedad datavaluefield
                    ///tanto del dropdownlist como del listbox

                    ///yyyy/mm/dd
                    DateTime FechaNacimiento = Convert.ToDateTime(this.txtfechanacimiento.Text);


                    ///asignar a la variable el resultado de 
                    /// invocar el procedimiento almacenado que
                    /// se encuentra en el metodo

                    resultado = oUsuario.InsertaUsuario(
                        txtCedula.Text,
                        ddlgenero.SelectedValue,
                        FechaNacimiento,
                        txtNombre.Text,
                        txtPrimerApellido.Text,
                        txtSegundoApellido.Text,
                       txtdireccion.Text,
                       txtTelefonoprincipal.Text,
                       txtTelefonosecundario.Text,
                       txtcorreo.Text,
                       LstTipoUsuario.SelectedValue,
                       txtContrasenia.Text

                        );
                }
                ///  CATCH: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: Posee los datos de la excepcion
                catch (Exception excepcionCapturada)
                {

                    mensaje += $" Ocurrio un error:{excepcionCapturada.Message}";
                }
                ///siempre se ejecuta (se atrape o no la excepcion)
                finally
                {
                    /// si el resultado de la variable es verdadera implica que
                    /// el procedimiento no retorno errores

                    if (resultado)
                    {
                        mensaje += "El registro fue insetado";
                    }
                }

                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }


    }
}