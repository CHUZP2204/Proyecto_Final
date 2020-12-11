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
    public partial class frmModificaAdiccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Validar Si Usuario Esta Conectado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/Formularios/frmInicioSesion.aspx");
            }
            if (!this.IsPostBack)
            {
                CargaRegistro();
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            AlmacenaDatos();
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
                Response.Write("<scrpt>alert('Parametro nulo')</script"); ;
            }
            else
            {
                int idAdicciones = Convert.ToInt16(parametro);
                BLAdicciones bLAdicciones = new BLAdicciones();
                sp_RetornaAdiccionesID_Result datosAdicciones = new sp_RetornaAdiccionesID_Result();

                //invocar al sp por medio del metodo
                datosAdicciones = bLAdicciones.sp_RetornaAdiccionesID(idAdicciones);

                //verificar que el objeto retornado no sea nulo
                if (datosAdicciones == null)
                {
                    Response.Redirect("frmListaAdicciones.aspx");
                }
                else
                {
                    ///asignar a cada una de las etiquetas los valores
                    ///obtenidos en la invocacion del sp por medio del metodo

                    this.txtNombreAdiccion.Text = datosAdicciones.Nombre.ToString();
                    this.txtCodigoAdiccion.Text = datosAdicciones.Codigo.ToString();
                    //asignar al hiden field
                    //el valor de llave primaria
                    this.hdidAdicciones.Value = datosAdicciones.IdAdicciones.ToString();
                }
            }
        }
        void AlmacenaDatos()
        {
            if (this.IsValid)
            {
                string mensaje = " ";
                BLAdicciones bLAdicciones = new BLAdicciones();
                bool resultado = false;

                try
                {
                    //obtener el valor de hidden field
                    int idAdicciones = Convert.ToInt16(this.hdidAdicciones.Value);
                    ///obtener los valores seleccionados por el usuario
                    ///se toman de la propiedad datavaluefield


                    //asignar a la variable el resultado
                    // de invocar el sp
                    resultado = bLAdicciones.ModificaAdiccion(
                        idAdicciones,
                       this.txtNombreAdiccion.Text,
                       this.txtCodigoAdiccion.Text);

                }
                catch (Exception exepcionCapturada)
                {
                    mensaje += $"Ocurrio un error: { exepcionCapturada.Message}";

                }
                finally
                {
                    if (resultado)
                    {
                        mensaje += $"El registro fue Modificado ";
                    }
                }


                //mostrar el mensaje 
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }


    }
}