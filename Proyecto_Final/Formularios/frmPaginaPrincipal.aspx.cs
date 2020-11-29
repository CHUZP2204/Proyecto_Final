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
            /// Esto Verifica Si Hay Un Usuario Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            /// Cargar Nombre Del Usuario Que Se Logueo
            cargaNombre();
        }

        /// <summary>
        /// Metodo Que Obtiene y asigna A Un Label Los Datos Del Usuario Actual
        /// Desde LAs Variables De Session
        /// </summary>
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