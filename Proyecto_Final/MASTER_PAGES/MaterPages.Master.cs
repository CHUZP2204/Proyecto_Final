using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final.MASTER_PAGES
{
    public partial class MaterPages : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Si No Hay Usuario Logueado, no se debe mostrar El HyperLink Salir
            ///Esto Especialmente Para El Formulario Iniciar Session
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.hplSalir.Visible = false;
            }

        }
    }
}