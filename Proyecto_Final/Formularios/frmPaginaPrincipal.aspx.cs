using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final.Formularios
{
    public partial class frmPaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaNombre();
        }

        void cargaNombre()
        {
            string nombreActual = Convert.ToString(this.Session["nombre"]);
            string pApellidoActual = Convert.ToString(this.Session["pApellido"]);
            string sApellidoActual = Convert.ToString(this.Session["sApellido"]);

            string mjs = $"Bienvenido Al Sistema {nombreActual} {pApellidoActual} {sApellidoActual}";

            this.lblUSuarioConectado.Text = mjs;
        }


    }
}