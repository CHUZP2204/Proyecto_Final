using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.Formularios;
using Proyecto_Final.BL;
using Proyecto_Final.Modelo;


namespace Proyecto_Final.Formularios
{
    public partial class frmListaCobertura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CargaDatosGrid();
        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.CargaDatosGrid();
        }
        void CargaDatosGrid()
        {
            //Crear la instancia de la clase que retorna los datos

            BLCobertura blcobertura = new BLCobertura();
            ///crear la variable que contiene los datos 
            List<sp_RetornaCobertura_Result> fuenteDatos =
            blcobertura.RetornaCobertura(this.txtnombre.Text, this.txtporcentaje.Text);

            ///agregar feunte de datos
            this.grdListaCobertura.DataSource = fuenteDatos;

            //se muestra el grid
            this.grdListaCobertura.DataBind();
        }

        protected void grdListaCobertura_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //inidar a grid la nueva pagina utilizando el parametro e
            this.grdListaCobertura.PageIndex = e.NewPageIndex;

            //cargar de nuevo el grid e inidarle que se muestre
            this.CargaDatosGrid();
        }
    }
}