using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.Formularios
{
    public partial class frmListaAdicciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Validar Si Usuario Esta Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            CargaDatosGrid();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            this.CargaDatosGrid();
        }
        void CargaDatosGrid()
        {
            //crear la instancia de la clase que retorna datos
            BLAdicciones bLAdicciones = new BLAdicciones();
            // variable contiene datos
            List<sp_RetornaAdicciones_Result> fuenteDatos =
                bLAdicciones.RetornaAdicciones(this.txtNombreAdiccion.Text,
                this.txtCodigoAdiccion.Text);

            //fuente datos
            this.grdListaAdiccion.DataSource = fuenteDatos;

            //muestra grid
            this.grdListaAdiccion.DataBind();



        }

        protected void grdListaAdiccion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // indicar al grid la nueva pagina utilizando el paramentro e
            this.grdListaAdiccion.PageIndex = e.NewPageIndex;

            //cargar de nuevo el grid
            this.CargaDatosGrid();
        }
    }
}