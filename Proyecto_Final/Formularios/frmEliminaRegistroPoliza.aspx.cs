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
    public partial class frmEliminaRegistroPoliza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Cargar Poliza Obtenido Por ID
            CargarPoliza();
        }
        void CargarPoliza()
        {
            ///Obtener El Parametro De Consulta Seleccionado Desde
            ///

            string parametro = this.Request.QueryString["IdRegistro"];
            ///Validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Lanzar Alerta De Que No Hay Ningun Parametro
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                ///Convertir La Variable De Consulta A INT
                int IdRegistro = Convert.ToInt16(parametro);
                /// Se Crea Una Instancia De BLUsuarios
                BLPolizas PolizaObtenido = new BLPolizas();
                /// Se Crea Una Instancia Del Modelo De BD
                sp_RetornaRegistroPolizaID_Result resultado = new sp_RetornaRegistroPolizaID_Result();
                ///Invocar Al Procedimiento Almacenado
                ///Que Retorna Una Poliza Por ID De La Clase BL
                ///Y Se Asigna A Result
                resultado = PolizaObtenido.sp_RetornaRegistroPolizaID_(IdRegistro);
                ///Si RESULT Es Vacio Redireccionar A ListaPoliza
                if (resultado == null)
                {
                    Response.Redirect("frmListaPolizas.aspx");
                }
                else
                {
                    ///Se Asignan A Los TextBox Los Datos De la POliza Obtenido
                    this.txtMontoAsegurado.Text = resultado.MontoAsegurado;
                    this.txtPorcentajeCobertura.Text = resultado.PorcentajeCobertura;
                    this.txtMontoAdicciones.Text = resultado.MontoAdicciones;
                    this.txtPrimaAntesImpu.Text = resultado.PrimaAntesImpu;
                    this.txtImpuesto.Text = resultado.Impuestos;
                    this.txtPrimaFinal.Text = resultado.PrimaFinal;
                    this.hdRegistro.Value = resultado.IdRegistro.ToString();
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
                CargarPoliza();
            }

            void EliminarDatos()
            {
                if (this.IsValid)
                {
                    BLPolizas opoliza = new BLPolizas();
                    bool resultado = false;
                    string mensaje = "";
                    try
                    {
                        // obtener el id del registro eliminar
                        int IdRegistro = Convert.ToInt32(this.hdRegistro.Value);
                        // asignar a la variable resultado de 
                        // invocar el procedimiento almacenado
                        resultado = opoliza.EliminaPoliza(IdRegistro);

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
