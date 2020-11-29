<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmListaCobertura.aspx.cs" Inherits="Proyecto_Final.Formularios.frmListaCobertura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

      <div id="frmListaCobertura" class="form-inline">
        <h1>Lista de Coberturas</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Porentaje:"></asp:Label>
            <asp:TextBox ID="txtporcentaje" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnMostrarDatos" runat="server" Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hpAgregarcobertura" runat="server" NavigateUrl="~/Formularios/frmInsertCobertura.aspx">Agregar Cobertura</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:GridView ID="grdListaCobertura" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="grdListaCobertura_PageIndexChanging" PageSize="5">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
