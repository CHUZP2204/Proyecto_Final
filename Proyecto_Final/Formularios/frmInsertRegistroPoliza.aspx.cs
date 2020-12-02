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
    public partial class frmInsertRegistroPoliza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                string mensaje = "";
                BLPolizas oPoliza = new BLPolizas();
                bool resultado = false;
                try
                {
                    ///obtener y convertir los valores seleccionados 
                    
                    int NumeroAdicciones = Convert.ToInt32(txtNumeroAdicciones.Text);
                    int IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
                    int IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    int IdCobertura = Convert.ToInt32(txtIdCobertura.Text);

                    ///asignar a la variable el resultado de 
                    /// invocar el procedimiento almacenado que
                    /// se encuentra en el metodo

                    resultado = oPoliza.InsertaPoliza(
                        txtMontoAsegurado.Text,
                         txtPorcentajeCobertura.Text,
                        NumeroAdicciones,
                        txtMontoAdicciones.Text,
                        txtPrimaAntesImpu.Text,
                        txtImpuestos.Text,
                        txtPrimaFinal.Text,
                         IdSeguro,
                         IdUsuario,
                         IdCobertura
                        );
                }
                ///  CATCH: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: Posee los datos de la excepcion
                catch (Exception excepcionCapturada)
                {

                    mensaje += $" Ocurrio un error:{excepcionCapturada.Message}";
                }
                ///siempre se ejecuta (se atrape o no la excepcion)
                finally
                {
                    /// si el resultado de la variable es verdadera implica que
                    /// el procedimiento no retorno errores

                    if (resultado)
                    {
                        mensaje += "El registro fue insertado";
                    }
                }

                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }


    }
}