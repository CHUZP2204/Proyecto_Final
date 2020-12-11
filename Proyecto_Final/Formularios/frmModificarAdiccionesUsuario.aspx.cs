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
    public partial class frmModificarAdiccionesUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Validar Si Usuario Esta Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            if (!this.IsPostBack)
            {
                CargarAdiccionesUsuario();
            }
        }
        void CargarAdiccionesUsuario()
        {

            string parametro = this.Request.QueryString["IdIdentificador"];
            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                int IdIdentificador = Convert.ToInt32(parametro);
                BLAdiccionesUsuario oAdiccionUsuario = new BLAdiccionesUsuario();

                sp_RetornaAdiccionUsuarioID_Result resultado = new sp_RetornaAdiccionUsuarioID_Result();
                ///invocar al procedimiento
                resultado = oAdiccionUsuario.sp_RetornaAdiccionesUsuarioID(IdIdentificador);
                if (resultado == null)
                {
                    Response.Redirect("frmListaAdiccionesUsuario.aspx");
                }
                else
                {
                    this.txtIdentificacionAdiccion.Text = resultado.IdAdicciones.ToString();
                    this.txtIdentificacionUsuario.Text = resultado.IdUsuario.ToString();
                    /////asignar al hidden field
                    /////el valor de la llave primaria
                    hdAdiccionesUsuario.Value = resultado.IdIdentificador.ToString();
                }

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLAdiccionesUsuario oAdiccionUsu = new BLAdiccionesUsuario();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    //obtener el valor del hidden field 
                    int IdIdentificador = Convert.ToInt32(hdAdiccionesUsuario.Value);
                    int IdAdicciones = Convert.ToInt32(txtIdentificacionAdiccion.Text.ToString());
                    int IdUsuario = Convert.ToInt32(txtIdentificacionUsuario.Text.ToString());

                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oAdiccionUsu.ModificaAdiccionesUsuario(
                        IdIdentificador,
                        IdAdicciones,
                        IdUsuario
                        );

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