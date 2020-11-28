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
            if (!this.IsPostBack)
            {
                CargarUsuario();
            }


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
                int IdUsuario = Convert.ToInt32(parametro);
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

                    /////asignar al hidden field
                    /////el valor de la llave primaria
                    hdidUsuario.Value = resultUsuario.IdUsuario.ToString();
                }

            }


        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLusuarios oUsuario = new BLusuarios();
                bool resultado = false;
                string mensaje = "";
                try
                {

                    //convertir la  fecha
                    DateTime FechaNacimiento = Convert.ToDateTime(this.txtfechanacimiento.Text);

                    //obtener el valor del hidden field 
                    int idUsuario = Convert.ToInt32(hdidUsuario.Value);

                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oUsuario.ModificaUsuarioID(
                        idUsuario,
                        this.txtCedula.Text,
                        this.ddlgenero.SelectedValue,
                        FechaNacimiento,
                        this.txtNombre.Text,
                        this.txtPrimerApellido.Text,
                        this.txtSegundoApellido.Text,
                        this.txtdireccion.Text,
                        this.txtTelefonoprincipal.Text,
                        this.txtTelefonosecundario.Text,
                        this.txtcorreo.Text,
                         LstTipoUsuario.SelectedValue,
                        this.txtContrasenia.Text);

                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue modificado";
                    }
                }
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }
    }
}