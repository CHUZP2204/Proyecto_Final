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

            ///Obtener El Id Del Usuario Conectado
            string idUserConnected = this.Session["idusuario"].ToString();
            ///Asignar A Hypelinks Para Modifcar Datos Personales De Usuario
            this.hplModificarUser.NavigateUrl = "~/Formularios/frmModificarUsuario.aspx?IdUsuario=" + idUserConnected;
            this.hplEliminarUser.NavigateUrl = "~/Formularios/frmEliminarUsuario.aspx?IdUsuario=" + idUserConnected;
            ///Verificar El Tipo De Usuario Conectado
            VerificaPermisoTipoUsuario();
            /// Cargar Nombre Del Usuario Que Se Logueo
            cargaNombre();
        }

        /// <summary>
        /// usando la variable de session tipo de usuario 
        /// muestra o oculta opeciones del menu
        /// </summary>
        void VerificaPermisoTipoUsuario()
        {
            string tipoUsuarioCOnectado = Convert.ToString(Session["tipousuario"]);
            if (tipoUsuarioCOnectado.Equals("Administrador") || tipoUsuarioCOnectado.Equals("Empleado"))
            {
                this.hplUserList.Visible = true;
                this.hpAdicUsuList.Visible = true;
                this.hpPolizaList.Visible = true;
                this.hpAdicList.Visible = true;
                this.hpCoberList.Visible = true;
                this.hplReporte1.Visible = true;
                this.hplReporte2.Visible = true;
            }

            if (tipoUsuarioCOnectado.Equals("Cliente"))
            {
                this.hplUserList.Visible = false;
                this.hpAdicUsuList.Visible = false;
                this.hpPolizaList.Visible = false;
                this.hpAdicList.Visible = false;
                this.hpCoberList.Visible = false;
                this.hplReporte1.Visible = false;
                this.hplReporte2.Visible = false;
            }

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
            string sTipoUsuarioActual = Convert.ToString(this.Session["tipousuario"]);

            this.lblTipoUsuarioActual.Text = sTipoUsuarioActual;

            string mjs = $"Bienvenido Al Sistema {nombreActual} {pApellidoActual} {sApellidoActual}  <br/> " +
                         $" Es Un Gusto Verlo De Vuelta";

            this.lblUSuarioConectado.Text = mjs;
        }


    }
}