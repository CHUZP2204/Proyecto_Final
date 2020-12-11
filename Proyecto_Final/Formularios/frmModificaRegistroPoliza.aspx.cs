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
    public partial class frmModificaRegistroPoliza : System.Web.UI.Page
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
                CargarPoliza();
            }
        }
        void CargarPoliza()
        {

            string parametro = this.Request.QueryString["IdRegistro"];
            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                int IdRegistro = Convert.ToInt32(parametro);
                BLPolizas PolizaObtenida = new BLPolizas();
                sp_RetornaRegistroPolizaID_Result resultado = new sp_RetornaRegistroPolizaID_Result();
                ///invocar al procedimiento
                resultado = PolizaObtenida.sp_RetornaRegistroPolizaID_(IdRegistro);
                if (resultado == null)
                {
                    Response.Redirect("frmListaPolizas.aspx");
                }
                else
                {
                    this.txtMontoAsegurado.Text = resultado.MontoAsegurado;
                    this.txtPorcentajeCobertura.Text = resultado.PorcentajeCobertura;
                    this.txtNumeroAdicciones.Text = resultado.NumeroAdicciones.ToString();
                    this.txtMontoAdicciones.Text = resultado.MontoAdicciones;
                    this.txtPrimaAntesImpu.Text = resultado.PrimaAntesImpu;
                    this.txtImpuestos.Text = resultado.Impuestos;
                    this.txtPrimaFinal.Text = resultado.PrimaFinal;
                    this.txtIdSeguro.Text = resultado.IdSeguro.ToString();
                    this.txtIdUsuario.Text = resultado.IdUsuario.ToString();
                    this.txtIdCobertura.Text = resultado.IdCobertura.ToString();


                    /////asignar al hidden field
                    /////el valor de la llave primaria
                    hdidRegistro.Value = resultado.IdRegistro.ToString();
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
                BLPolizas oPolizas = new BLPolizas();
                bool resultado = false;
                string mensaje = "";
                try
                {

                    //convertir datos int
                    int NumeroAdicciones = Convert.ToInt32(txtNumeroAdicciones.Text);
                    int IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
                    int IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    int IdCobertura = Convert.ToInt32(txtIdCobertura.Text);

                    //obtener el valor del hidden field 
                    int idRegistro = Convert.ToInt32(hdidRegistro.Value);

                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oPolizas.ModificaPoliza(
                        idRegistro,
                        this.txtMontoAsegurado.Text,
                        this.txtPorcentajeCobertura.Text,
                        NumeroAdicciones,
                        this.txtMontoAdicciones.Text,
                        this.txtPrimaAntesImpu.Text,
                        this.txtImpuestos.Text,
                        this.txtPrimaFinal.Text,
                        IdSeguro,
                        IdUsuario,
                        IdCobertura);

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
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }
    }
}