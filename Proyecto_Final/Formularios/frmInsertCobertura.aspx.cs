using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.BL;

namespace Proyecto_Final.Formularios
{
    public partial class frmInsertCobertura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Validar Si Usuario Esta Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
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
               BLCobertura  oCobertura = new BLCobertura();
                bool resultado = false;
                try
                {
                    ///asignar a la variable el resultado de 
                    /// invocar el procedimiento almacenado que
                    /// se encuentra en el metodo

                    resultado = oCobertura.InsertaCobertura(
                        txtnombre.Text,
                        txtdescripcion.Text,
                       txtporcentaje.Text);
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
            }
        }
    }
}