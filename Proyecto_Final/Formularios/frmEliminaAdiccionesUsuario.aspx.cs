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
    public partial class frmEliminaAdiccionesUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Esto Verifica Si Hay Un Usuario Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            CargarAdiccionesUsuario();
        }
        void CargarAdiccionesUsuario()
        {
            ///Obtener El Parametro De Consulta Seleccionado Desde
            ///Formulario Lista Cobertura

            string parametro = this.Request.QueryString["IdIdentificador"];
            ///Validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Lanzar Alerta De Que No Hay Ningun Parametro
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                ///Convertir La Variable De Consulta A INT
                int IdIdentificador = Convert.ToInt32(parametro);
                /// Se Crea Una Instancia De BLCobertura
                BLAdiccionesUsuario oAdiccionUsuario = new BLAdiccionesUsuario();
                /// Se Crea Una Instancia Del Modelo De BD
                sp_RetornaAdiccionUsuarioID_Result resultado = new sp_RetornaAdiccionUsuarioID_Result();
                ///Invocar Al Procedimiento Almacenado
                ///Que Retorna una cobertura Por ID De La Clase BL
                ///Y Se Asigna A Result
                resultado = oAdiccionUsuario.sp_RetornaAdiccionesUsuarioID(IdIdentificador);
                ///Si RESULT Es Vacio Redireccionar A Lista cobertura
                if (resultado == null)
                {
                    Response.Redirect("frmListaAdiccionesUsuario.aspx");
                }
                else
                {

                    ///Se Asignan A Los TextBox Los Datos Del  la cobertura
                    ///
                    this.txtIdentificadorAdiccion.Text = resultado.IdAdicciones.ToString();
                    this.txtIdentificadorUsuario.Text = resultado.IdUsuario.ToString();
                    this.hdAdiccionesUsuario.Value = resultado.IdIdentificador.ToString();
                }
            }
        }
        /// <summary>
        /// Evento Que Eliminara Un Registro
        /// </summary>
        /// 
        protected void btnsi_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }
        protected void btnno_Click(object sender, EventArgs e)
        {
            CargarAdiccionesUsuario();
        }

        void EliminarDatos()
        {
            if (this.IsValid)
            {
                BLAdiccionesUsuario oadiccionusuario = new BLAdiccionesUsuario();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    // obtener el id del registro eliminar
                    int idIdentificador = Convert.ToInt32(this.hdAdiccionesUsuario.Value);
                    // asignar a la variable resultado de 
                    // invocar el procedimiento almacenado
                    resultado = oadiccionusuario.EliminaAdiccionesUsuario(idIdentificador);

                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue eliminado correctamente";
                    }
                }
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }
    }
}