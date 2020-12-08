using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Final.Modelo;
using Microsoft.Reporting.WebForms;
using System.IO;


namespace Proyecto_Final.Formularios
{
    public partial class frmReporteClientesPolizas : System.Web.UI.Page
    {
        segurosEntities1 modeloBD = new segurosEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnVerReporte_Click(object sender, EventArgs e)
        {
            this.contruirReporte();
        }

        void contruirReporte()
        {

            ///indicar la ruta del reporte
            string rutaReporte = "~/Reportes/RptPolizasXCliente.rdlc";
            ///construir la ruta física
            string rutaServidor = Server.MapPath(rutaReporte);
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lblResultado.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpvClientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvClientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvClientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                List<sp_Retorna_PolizasClientes_Result> datosReporte =
                   this.retornaDatosReporte(this.txtNombre.Text, this.txtPrimerApellido.Text, this.txtNombrePoliza.Text,this.txtNombrePoliza.Text);
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvClientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvClientes.LocalReport.Refresh();
            }
        }
        /// <summary>
        /// Función que retorna la fuente de datos a mostrar en el reporte
        /// </summary>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pNombre"></param>
        ///  <param name="pNombrePoliza"></param>
        ///   <param name="pPorcentaje"></param>
        /// <returns></returns>
        List<sp_Retorna_PolizasClientes_Result> retornaDatosReporte(
            string pnombreUsuario, string pprimerApellido = null, string pnombrePoliza = null, string pPorcentajeCobertura = null)
        {
            return
                 this.modeloBD.sp_Retorna_PolizasClientes(pnombreUsuario, pprimerApellido, pnombrePoliza, pPorcentajeCobertura).ToList();
        }


    }
}