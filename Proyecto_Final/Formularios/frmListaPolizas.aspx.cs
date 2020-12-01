using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.Modelo;
using Proyecto_Final.BL;

namespace Proyecto_Final.Formularios
{
    public partial class frmListaPolizas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Cargar Datos Del Grid Inicialmente Todos
            this.CargaDatosGrid();
        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            /// Cargar Datos Del Grid Inicialmente Todos
            this.CargaDatosGrid();
        }
        void CargaDatosGrid()
        {
            //Crear la instancia de la clase que retorna los datos

            BLPolizas blpoliza = new BLPolizas();
            ///crear la variable que contiene los datos 
            List<sp_retornaRegistroPoliza_Result> fuenteDatos =
            blpoliza.retornaPoliza(this.txtmontoasegurado.Text, this.txtporcentajecobertura.Text);

            ///agregar feunte de datos
            this.grdListaPoliza.DataSource = fuenteDatos;

            //se muestra el grid
            this.grdListaPoliza.DataBind();
        }

        protected void grdListaPoliza_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //inidar a grid la nueva pagina utilizando el parametro e
            this.grdListaPoliza.PageIndex = e.NewPageIndex;

            //cargar de nuevo el grid e inidarle que se muestre
            this.CargaDatosGrid();
        }
    }
}
