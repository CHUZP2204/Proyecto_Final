using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final.Formularios
{
    public partial class frmInsertarAdiccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenaDatos();
        }
        void AlmacenaDatos()
        {
            if (this.IsValid)
            {
                string mensaje = " ";
                BLAdicciones bLAdicciones = new BLAdicciones();
                bool resultado = false;

                try
                {

                    resultado = bLAdicciones.InsertaAdiccion(
                        this.txtNombreAdiccion.Text,
                        this.txtNombreAdiccion.Text) ;
                }
                catch (Exception exepcionCapturada)
                {
                    mensaje += $"Ocurrio un error: { exepcionCapturada.Message}";

                }
                finally
                {
                    if (resultado)
                    {
                        mensaje += $"El registro fue Insertado ";
                    }
                }


                //mostrar el mensaje 
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }
    }
}