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
    public partial class frmEliminaAdiccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Esto Verifica Si Hay Un Usuario Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            CargaRegistro();

        }
        void CargaRegistro()
        {
            //obtener el parametro enviado desde el grid 
            //es casesensitive
            string parametro =
                 this.Request.QueryString["idAdicciones"];
            //validar si el parametro es correcto
            if (string.IsNullOrEmpty(parametro))
            {
                Response.Write("<scrpt>alert('Parametro nulo')</script"); 
            }
            else
            {
                int idAdicciones = Convert.ToInt16(parametro);
                BLAdicciones bLAdicciones = new BLAdicciones();
                //invocar al sp por medio del metodo
                sp_RetornaAdiccionesID_Result datosAdicciones =  bLAdicciones.sp_RetornaAdiccionesID(idAdicciones);

                //verificar que el objeto retornado no sea nulo
                if (datosAdicciones == null)
                {
                    Response.Redirect("frmListaAdicciones.aspx");
                }
                else
                {
                    ///asignar a cada una de las etiquetas los valores
                    ///obtenidos en la invocacion del sp por medio del metodo

                    this.txtNombreAdiccion.Text = datosAdicciones.NombreAdiccion.ToString();
                    this.txtCodigoAdiccion.Text = datosAdicciones.Codigo.ToString();
                    //asignar al hiden field
                    //el valor de llave primaria
                    this.hdidAdicciones.Value = datosAdicciones.IdAdicciones.ToString();
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
            CargaRegistro();
        }
        void EliminarDatos()
        {
            if (this.IsValid)
            {
                BLAdicciones bLAdicciones = new BLAdicciones();
                bool resultado = false;
                string mensaje = " ";

                try
                {
                    //obtener el id del registro eliminar
                    int idAdicciones = Convert.ToInt16(this.hdidAdicciones.Value);
                    //asignar a la variable el resultado
                    //de invocar el sp
                    resultado = bLAdicciones.EliminaAdiccion(idAdicciones);
                     
                }
                catch (Exception exepcionCapturada)
                {
                    mensaje += $"Ocurrio un error: { exepcionCapturada.Message}";

                }
                finally
                {
                    if (resultado)
                    {
                        mensaje += $"El registro fue Eliminado ";
                    }
                }


                //mostrar el mensaje 
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }
    }
}
