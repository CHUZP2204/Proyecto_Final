<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmEliminarUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmEliminarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmEliminaUsuario" runat="server" class="form-inline">

        <asp:HiddenField ID="hdIdUsuario" runat="server" />
        <div>
            <asp:Label ID="lblIdUsuario" runat="server" Text="ID UNICO:"></asp:Label>
            <asp:TextBox ID="txtIdUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblPrimerApellido" runat="server" Text="Primer Apellido:"></asp:Label>
            <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblSegundoApellido" runat="server" Text="Segundo Apellido:"></asp:Label>
            <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCedula" runat="server" Text="Cedula:"></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control"></asp:TextBox>
        </div>


    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
