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
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.Session["usuariologueado"]) == true)
            {
                this.Response.Redirect("~/Formularios/frmPaginaPrincipal.aspx");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            cargaDatos();
        }
        void cargaDatos()
        {
            ///Nota La Contraseña es el campo telefono1 
            ///Porque No existe el campo Para Ese Dato
            ///se debe crear
            string passObtenida = this.txtPassword.Text;
            string emailObtenido = this.txtUserName.Text;

            bool resultado = verificaUsuario(emailObtenido, passObtenida);

            if (resultado == true)
            {
                Response.Write("<script>alert('Inicio De Sesion Correcto')</script>");

                ///redirecionar a la Pagina Inicial
                this.Response.Redirect("~/Formularios/frmPaginaPrincipal.aspx");
            }
            else
            {
                Response.Write("<script>alert('NO SE PUDO INICIAR SESION <br/> INTENTE DE NUEVO!')</script>");
            }


        }

        /// <summary>
        /// Metodo Que Verifica Si La Autenticacion Es Valida 
        /// Al Ingresar Al Sistema
        /// </summary>
        /// <param name="pUsuario">Nombre Usuario</param>
        /// <param name="pContrasenia">Contraseña Usuario</param>
        /// <returns></returns>
        private bool verificaUsuario(string pUsuario, string pContrasenia)
        {
            BLusuarios usuariosObtenido = new BLusuarios();

            ///Instancia Que Retorna Los Usuarios
            List<sp_RetornaUsuario_Result> nuevaLista = usuariosObtenido.retornaUsuario(null, null);


            int usuarioEncontrado = 0;

            ///For Que Recorre La Lista De Usuarios 
            ///Verificando Que El Usuario Exista
            for (int i = 0; i < nuevaLista.Count; i++)
            {
                if (nuevaLista[i].Correo.Equals(pUsuario) && nuevaLista[i].Contrasenia.Equals(pContrasenia))
                {
                    ///Si Se Encontro Usuario se Asigna Un 1
                    usuarioEncontrado = 1;
                    ///Variables De Sesion, permite tener en memoria varibales con sus respectivos 
                    ///valores De Cualquier tipo de dato
                    ///************ Es case-sensitive
                    ///         nombre Variable,valor De La Variable

                    this.Session.Add("correo", nuevaLista[i].Correo);
                    this.Session.Add("nombre", nuevaLista[i].Nombre);
                    this.Session.Add("pApellido", nuevaLista[i].PrimerApellido);
                    this.Session.Add("sApellido", nuevaLista[i].SegundoApellido);
                    this.Session.Add("idusuario", nuevaLista[i].IdUsuario);
                    this.Session.Add("tipousuario", nuevaLista[i].TipoUsuario);
                    this.Session.Add("usuariologueado", true);

                    ///redirecionar a la Pagina Inicial
                    this.Response.Redirect("~/Formularios/frmPaginaPrincipal.aspx");

                }
                else
                {
                    /// Las Variables De Session Permanezcan Vacias
                    this.Session.Add("correo", null);
                    this.Session.Add("nombre", null);
                    this.Session.Add("pApellido", null);
                    this.Session.Add("sApellido", null);
                    this.Session.Add("idusuario", null);
                    this.Session.Add("tipousuario", null);
                    this.Session.Add("usuariologueado", null);
                }

            }
            if (usuarioEncontrado > 0)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        /// <summary>
        /// Evento Del Boton Que Redirecciona A Formulario De Registrarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInsertUsuario.aspx");
        }
    }
}