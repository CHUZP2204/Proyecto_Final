﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmListaPolizas.aspx.cs" Inherits="Proyecto_Final.Formularios.frmListaPolizas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!--Pagina Polizas-->
    <div id="formListaPolizas">
        <!--Contenido-->
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">
            <!--Contenido 1-->
              <div class="container-fluid" style="width: 500px">
                <!--Panel-->
                <div class="panel panel-primary"
                    style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                    <!--Encabezado Del Panel-->
                    <div class="panel-heading">
                        <div class="row" style="display: flex">
                            <div style="margin-left: 10px; margin-top: 15px">
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmPaginaPrincipal.aspx"
                                    class="btn btn-danger" runat="server"> <i class="fas fa-backspace"></i></asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 120px; padding-right: 150px">
                                <h3 class="auto-style1">Lista Polizas</h3>
                            </div>
                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <!--Nombre-->
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="MontoAsegurado:" style="font-weight: 700"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtmontoasegurado" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <br />
                        <!--FIN Nombre-->
                        <!--Primer Apellido-->
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="PorcentajeCobertura:" style="font-weight: 700"></asp:Label>
                            <asp:TextBox ID="txtporcentajecobertura" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <!--FIN Primer Apellido-->
                        <!--Botones-->
                        <br />
                        <br />
                        <div class="form-group">
                            <asp:Button ID="btnMostrarDatos" runat="server" Text="Mostrar datos" CssClass="btn btn-success" OnClick="btnMostrarDatos_Click" />
                            <br />
                            <br />
                            <asp:HyperLink ID="hpAgregarPoliza" class="btn btn-primary" role="button" BorderColor="Black"
                                runat="server" NavigateUrl="~/Formularios/frmInsertRegistroPoliza.aspx">Agregar Poliza</asp:HyperLink>
                            <br />
                        </div>
                        <!--FIN Botones-->
                        <br />
                        <br />
                        <!--GRID-->
                        <div>
                            <asp:GridView ID="grdListaPoliza" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="grdListaPoliza_PageIndexChanging" PageSize="3">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:BoundField DataField="MontoAsegurado" HeaderText="Monto Asegurado" />
                                    <asp:BoundField DataField="PorcentajeCobertura" HeaderText="Porcentaje Cobertura" />
                                    <asp:BoundField DataField="Impuestos" HeaderText="Impuesto" />
                                    <asp:BoundField DataField="PrimaFinal" HeaderText="Prima Final" />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdRegistro" DataNavigateUrlFormatString="frmModificaRegistroPoliza.aspx?IdRegistro={0}" Text="Modificar" />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdRegistro" DataNavigateUrlFormatString="frmEliminaRegistroPoliza.aspx?IdRegistro={0}" Text="Eliminar" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <br />
                        </div>
                        <!--FIN GRID-->
                    </div>
                    <!--FIN PANEL BODY-->
                </div>
                <!--FIN PANEL-->
            </div>
            <!--FIN Contenido 1-->
        </div>
        <!--FIN Contenido-->
    </div>
    <!--Fin Pagina Polizas-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
