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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        void CargarDatos()
        {
            BLusuarios clientesNuevos = new BLusuarios();

            List<sp_RetornaUsuario_Result> fuentedatos = clientesNuevos.retornaUsuario(this.txtNombre.Text, this.txtApellido.Text);

            this.grdUsuarios.DataSource = fuentedatos;
            this.grdUsuarios.DataBind();
        }

        protected void grdUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OpenModal_Click(object sender, EventArgs e)
        {
            string msj = " Me Jesus";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showMessage('" + msj + "')", true);
        }
    }
}