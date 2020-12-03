<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmListaCobertura.aspx.cs" Inherits="Proyecto_Final.Formularios.frmListaCobertura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

    <!--Contenido FRM Cobertura-->
    <div id="frmListaCobertura" class="form-inline">
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">
            <!---->
            <div class="container-fluid" style="width: 500px">
                <!--Panel-->
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
                                <h3 class="auto-style1">Lista De Coberturas</h3>
                            </div>
                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine">

                        <!--Nombre-->
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Nombre:" style="font-weight: 700"></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <!--Fin Nombre-->
                        <br />
                        <br />
                        <!--Porcentaje-->
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Porcentaje:" style="font-weight: 700"></asp:Label>
                            <asp:TextBox ID="txtporcentaje" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <!--FIN Porcentaje-->
                        <br />

                        <!--Botones-->
                        <div class="form-group">
                            <asp:Button ID="btnMostrarDatos" runat="server" Text="Mostrar datos" CssClass="btn btn-success" OnClick="btnMostrarDatos_Click" />
                            <br />
                            <br />
                            <asp:HyperLink ID="hpAgregarcobertura" class="btn btn-primary" role="button" BorderColor="Black" runat="server"
                                NavigateUrl="~/Formularios/frmInsertCobertura.aspx">Agregar Cobertura</asp:HyperLink>
                            <br />
                            <br />
                        </div>
                        <!--Fin Botones-->
                        <br />
                        <!--GRID-->
                        <div class="form-group">
                            <asp:GridView ID="grdListaCobertura" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="grdListaCobertura_PageIndexChanging" PageSize="5">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Cobertura" />
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion Cobertura" />
                                    <asp:BoundField DataField="Procentaje" HeaderText="Procentaje Cobertura " />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdCobertura" DataNavigateUrlFormatString="frmModificaCobertura.aspx?IdCobertura={0}" Text="Modificar" />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdCobertura" DataNavigateUrlFormatString="frmEliminaCobertura.aspx?IdCobertura={0}" Text="Eliminar" />
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
                        </div>
                        <!--Fin GRID-->
                    </div>
                    <!--FIN CUERPO PANEL-->
                </div>
                <!--FIN PANEL-->
            </div>
        </div>
    </div>
    <!--Fin FRMCobertura-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
