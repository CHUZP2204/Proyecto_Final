using Proyecto_Final.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

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
                this.hplAtrasInicio.Visible = false;
            }
            /// No Se Mostrara El HyperLink Si ya Hay Un Usuario Logueado
            /// Porque Este Re-Direcciona a La Pantalla Login
            if (Convert.ToBoolean(this.Session["usuariologueado"]) == true)
            {
                this.hplAtrasInicio.Visible = false;
                this.hplAtrasInicio.Visible = true;
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

                    ///Enviar Un Correo  Al Nuevo Usuario Registrado
                    MailMessage email = new MailMessage();
                    MailAddress de = new MailAddress("segurossigloxxi44@gmail.com");

                    email.To.Add(this.txtcorreo.Text);


                    email.From = de;
                    email.Priority = MailPriority.Normal;
                    email.IsBodyHtml = false;
                    email.Subject = "ASUNTO: " + "Su Cuenta En Seguros El Equipo Del Siglo XXI";
                    email.Body = $"Estimado Cliente: { this.txtPrimerApellido.Text} { this.txtSegundoApellido.Text}" +
                                 $" {this.txtNombre.Text} Gracias Por Confiar En Seguros El Equipo Del Siglo XXI" +
                                 $" Para Nosotros Es Un  Placer Servirle";

                    ///segurossigloxxi44@gmail.com
                    ///a2b3c4d05
                    SmtpClient enviar = new SmtpClient();

                    enviar.Host = "smtp.gmail.com";
                    enviar.Credentials = new NetworkCredential("segurossigloxxi44@gmail.com", "a2b3c4d05");
                    enviar.EnableSsl = true;
                    enviar.Send(email);
                    email.Dispose();


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
                        mensaje += "El registro fue insertado";
                    }
                }

                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");

                ///VErificar Si Esta Registrando Desde Pantalla Inicial O Ya Usuario Logueado
                /*
                if(Convert.ToBoolean(this.Session["usuariologueado"]) != true)
                {
                    this.Response.Redirect("frmInicioSesion.aspx");
                }
                else
                {
                    this.Response.Redirect("frmUsuarioLista.aspx");
                }
                */
            }
        }


    }
}