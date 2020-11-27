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

            bool resultado = verificaUsuario(emailObtenido,passObtenida); 

            if(resultado == true)
            {
                Response.Write("<script>alert('Inicio De Sesion Correcto')</script>");
    
                ///redirecionar a la Pagina Inicial
                this.Response.Redirect("~/FormulariosBaseDatos/frmPaginaPrincipal.aspx");
            }
            else
            {
                Response.Write("<script>alert('No Se Pudo Iniciar Sesion Intente De Nuevo')</script>");
            }


        }

        private bool verificaUsuario(string pUsuario, string pContrasenia)
        {
            BLusuarios usuariosObtenido = new BLusuarios();

            List<sp_RetornaUsuario_Result> nuevaLista = usuariosObtenido.retornaUsuario(null, null);

            


                int usuarioEncontrado = 0;

            for (int i = 0; i < nuevaLista.Count; i++)
            {
                if (nuevaLista[i].Correo.Equals(pUsuario) && nuevaLista[i].Contrasenia.Equals(pContrasenia))
                {
                    usuarioEncontrado = 1;
                    ///Variables De Sesion, permite tener en memoria varibales con sus respectivos 
                    ///valores De Cualquier tipo de dato
                    ///************ Es case-sensitive
                    ///         nombre Variable,valor De La Variable

                    this.Session.Add("correo", nuevaLista[i].Correo);
                    this.Session.Add("nombre",nuevaLista[i].Nombre);
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
                   
                    this.Session.Add("correo", null);
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

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInsertUsuario.aspx");
        }
    }
}