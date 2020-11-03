<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmUsuarioLista.aspx.cs" Inherits="Proyecto_Final.Formulario_Base_Datos.frmUsuarioLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form runat="server" class="form-inline">
        <h1>Lista de Usuarios</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Primer Apellido:"></asp:Label>
            <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnMostrarDatos" runat="server" Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hpAgregarUsario" runat="server" NavigateUrl="~/Formularios/frmInsertUsuario.aspx">Agregar Usuario</asp:HyperLink>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="grdListaUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="grdListaUsuarios_PageIndexChanging" PageSize="3">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre Usuario" />
                <asp:BoundField DataField="PrimerApellido" HeaderText="Apellido 1" />
                <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo" />
                <asp:BoundField DataField="Correo" HeaderText="Correo Usuario" />
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
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
