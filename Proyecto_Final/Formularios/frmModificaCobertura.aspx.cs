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
    public partial class frmModificaCobertura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargarCobertura();
            }
            void CargarCobertura()
            {

                string parametro = this.Request.QueryString["IdCobertura"];
                //validar si el parametro es correcto
                if (String.IsNullOrEmpty(parametro))
                {
                    Response.Write("<script>alert('Parámetro nulo')</script>");
                }
                else
                {
                    int IdCobertura = Convert.ToInt32(parametro);
                    BLCobertura coberturaObtenido = new BLCobertura();
                    sp_RetornaCoberturaID_Result resultado = new sp_RetornaCoberturaID_Result();
                    ///invocar al procedimiento
                    resultado = coberturaObtenido.RetornaCoberturaID(IdCobertura);
                    if (resultado == null)
                    {
                        Response.Redirect("frmListaCobertura.aspx");
                    }
                    else
                    {
                        this.txtnombre.Text = resultado.NombreCobertura;
                        this.txtdescripcion.Text = resultado.Descripcion;
                        this.txtporcentaje.Text = resultado.Procentaje;
                    
                        /////asignar al hidden field
                        /////el valor de la llave primaria
                        hdidCobertura.Value = resultado.IdCobertura.ToString();
                    }

                }
            }
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLCobertura oCobertura = new BLCobertura();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    //obtener el valor del hidden field 
                    int IdCobertura = Convert.ToInt32(hdidCobertura.Value);

                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oCobertura.ModificaCobertura(
                        IdCobertura,
                        this.txtnombre.Text,
                        this.txtdescripcion.Text,
                        this.txtporcentaje.Text);

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
                        mensaje += "El registro fue modificado";
                    }
                }
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }
    }
}