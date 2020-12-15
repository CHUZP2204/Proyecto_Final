<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmReporteClientesPolizas.aspx.cs" Inherits="Proyecto_Final.Formularios.frmReporteClientesPolizas" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="form1">
        <asp:ScriptManager ID="scmReporteClientes" runat="server"></asp:ScriptManager>
        <div class="container-fluid" style="">
            <div class="panel panel-primary"
                style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                <!--Encabezado Del Panel-->
                <div class="panel-heading">
                    <div class="row" style="display: flex">
                        <div style="margin-left: 10px; margin-top: 15px">
                            <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmPaginaPrincipal.aspx"
                                class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                            </asp:HyperLink>
                        </div>
                        <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                            <h3 class="auto-style1">Reporte CLIENTE POLIZA</h3>
                        </div>
                    </div>
                </div>

                <!--Cuerpo Del Panel-->
                <div class="panel-body" style="background-color: aquamarine">
                    <asp:Label ID="Label1" runat="server" Text="Nombre Cliente:" style="font-weight: 700"></asp:Label>
                    &nbsp;
                   <asp:TextBox ID="txtNombre" runat="server" Width="100px"></asp:TextBox>
                    &nbsp;&nbsp;
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Primer Apellido:" style="font-weight: 700"></asp:Label>
                    &nbsp;&nbsp;
                   
                   <asp:TextBox ID="txtPrimerApellido" runat="server" Width="110px"></asp:TextBox>
                    &nbsp;&nbsp;
                   <asp:Label ID="Label3" runat="server" Text="Nombre Poliza: " style="font-weight: 700"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtNombrePoliza" runat="server"></asp:TextBox>
                    &nbsp; &nbsp;
                    <br />
                       <br />
                    <asp:Label ID="Label4" runat="server" Text="Porcentaje:" style="font-weight: 700"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtPorcentaje" runat="server"></asp:TextBox>
                     <br />
                       <br />
                     &nbsp;
                   <asp:Button ID="btnVerReporte" runat="server" Text="Ver Reporte" OnClick="btnVerReporte_Click" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <rsweb:ReportViewer ID="rpvClientes" runat="server" Width="100%" Height="540px" Style="margin-top: 0px; margin-bottom: 0px;" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
                        <LocalReport ReportPath="Reportes\RptPolizasXCliente.rdlc">
                        </LocalReport>
                    </rsweb:ReportViewer>
                    <br />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
