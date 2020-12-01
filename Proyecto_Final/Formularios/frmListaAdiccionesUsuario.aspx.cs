using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.Modelo;
using Proyecto_Final.BL;
using System;
using System.Collections.Generic;

namespace Proyecto_Final.Formularios
{
    public partial class frmListaAdiccionesUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaDatosGrid();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            CargaDatosGrid();
        }
        void CargaDatosGrid()
        {
            //crear la instancia de la clase que retorna datos
            BLAdiccionesUsuario bLAdicionUsuario = new BLAdiccionesUsuario();
            // variable contiene datos

            int IdAdicciones = Convert.ToInt32(this.txtIdentificacionAdiccion.Text.ToString());
            int IdUsuario = Convert.ToInt32(this.txtIdentificacionUsuario.Text.ToString());

            List<sp_RetornaAdiccionUsuario_Result> fuenteDatos =
                bLAdicionUsuario.RetornaAdiccionesUsuario(
                IdAdicciones,
                IdUsuario
                );

            //fuente datos
            this.grdListaAdiccionUsuario.DataSource = fuenteDatos;

            //muestra grid
            this.grdListaAdiccionUsuario.DataBind();

        }

        protected void grdListaAdiccionUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // indicar al grid la nueva pagina utilizando el paramentro e
            this.grdListaAdiccionUsuario.PageIndex = e.NewPageIndex;

            //cargar de nuevo el grid
            this.CargaDatosGrid();
        }
    }
}