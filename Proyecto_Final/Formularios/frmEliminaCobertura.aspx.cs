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
    public partial class frmEliminaCobertura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Cargar Usuario Obtenido Por ID
            CargarCobertura();
        }
        void CargarCobertura()
        {
            ///Obtener El Parametro De Consulta Seleccionado Desde
            ///Formulario Lista Cobertura

            string parametro = this.Request.QueryString["IdCobertura"];
            ///Validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Lanzar Alerta De Que No Hay Ningun Parametro
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                ///Convertir La Variable De Consulta A INT
                int IdCobertura = Convert.ToInt32(parametro);
                /// Se Crea Una Instancia De BLCobertura
                BLCobertura coberturaObtenido = new BLCobertura();
                /// Se Crea Una Instancia Del Modelo De BD
                sp_RetornaCoberturaID_Result resultado = new sp_RetornaCoberturaID_Result();
                ///Invocar Al Procedimiento Almacenado
                ///Que Retorna una cobertura Por ID De La Clase BL
                ///Y Se Asigna A Result
                resultado = coberturaObtenido.RetornaCoberturaID(IdCobertura);
                ///Si RESULT Es Vacio Redireccionar A Lista cobertura
                if (resultado == null)
                {
                    Response.Redirect("frmListaCobertura.aspx");
                }
                else
                {
                    ///Se Asignan A Los TextBox Los Datos Del  la cobertura
                    this.txtNombre.Text = resultado.NombreCobertura;
                    this.txtDescripcion.Text = resultado.Descripcion;
                    this.txtPorcentaje.Text = resultado.Procentaje;
                    this.hdCobertura.Value = resultado.IdCobertura.ToString();
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
            CargarCobertura();
        }

        void EliminarDatos()
        {
            if (this.IsValid)
            {
                BLCobertura oCobertura = new BLCobertura();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    // obtener el id del registro eliminar
                    int idCobertura = Convert.ToInt32(this.hdCobertura.Value);
                    // asignar a la variable resultado de 
                    // invocar el procedimiento almacenado
                    resultado = oCobertura.EliminaCobertura(idCobertura);

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