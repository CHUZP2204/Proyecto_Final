using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.BL;
using Proyecto_Final.Formulario_Base_Datos;
using Proyecto_Final.Modelo;

namespace Proyecto_Final.Formulario_Base_Datos
{
    public partial class frmUsuarioLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            this.CargaDatosGrid();
        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            
        }
        void CargaDatosGrid()
        {
            //Crear la instancia de la clase que retorna los datos

            BLusuarios bLusuarios = new BLusuarios();
            ///crear la variable que contiene los datos 
            List<sp_RetornaUsuario_Result> fuenteDatos =
            bLusuarios.retornaUsuario(this.txtNombre.Text,this.txtPrimerApellido.Text);

            ///agregar feunte de datos
            this.grdListaUsuarios.DataSource = fuenteDatos;

            //se muestra el grid
            this.grdListaUsuarios.DataBind();
        }

        protected void grdListaUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //inidar a grid la nueva pagina utilizando el parametro e
            this.grdListaUsuarios.PageIndex = e.NewPageIndex;

            //cargar de nuevo el grid e inidarle que se muestre
            this.CargaDatosGrid();
        }
    }
}