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
            }
            else
            {
                Response.Write("<script>alert('No Se Pudo Iniciar Sesion Intente De Nuevo')</script>");
            }


        }

        public bool verificaUsuario(string pUsuario, string pContrasenia)
        {
            BLusuarios usuariosObtenido = new BLusuarios();

            List<sp_RetornaUsuario_Result> nuevaLista = usuariosObtenido.retornaUsuario(null, null);

            


                int usuarioEncontrado = 0;

            for (int i = 0; i < nuevaLista.Count; i++)
            {
                if (nuevaLista[i].Correo.Equals(pUsuario) && nuevaLista[i].Contraseña.Equals(pContrasenia))
                {
                    usuarioEncontrado = 1;
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


    }
}