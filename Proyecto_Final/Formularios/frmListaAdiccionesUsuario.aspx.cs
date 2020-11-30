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
            BLAdiccionesUsuario ObLAdicionUsuario = new BLAdiccionesUsuario();
            // variable contiene datos
            int IdAdicciones;
            int IdUsuario;
            if ( String.IsNullOrEmpty(this.txtIdentificacionAdiccion.Text) && String.IsNullOrEmpty(this.txtIdentificacionUsuario.Text))
            {

                List<sp_RetornaAdiccionUsuario_Result> fuenteDatos =
                ObLAdicionUsuario.RetornaAdiccionesUsuario(0, 0).ToList();
            }
            else
            {
                ///Las Variables Tienen Que Tener Un valor De Tipo INT
                ///Hay Error Si En EL TextBox No Se Pone Un Valor 
                ///Manda Un Vacio Y Vacio No Existe
                ///CORREGIR
                IdAdicciones = Convert.ToInt32(this.txtIdentificacionAdiccion.Text);
                IdUsuario = Convert.ToInt32(this.txtIdentificacionUsuario.Text);

                List<sp_RetornaAdiccionUsuario_Result> fuenteDatos =
                ObLAdicionUsuario.RetornaAdiccionesUsuario(IdAdicciones, IdUsuario).ToList();

                //fuente datos
                this.grdListaAdiccionUsuario.DataSource = fuenteDatos;

                //muestra grid
                this.grdListaAdiccionUsuario.DataBind();
            }




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