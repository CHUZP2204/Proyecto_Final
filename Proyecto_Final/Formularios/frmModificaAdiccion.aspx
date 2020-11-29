<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmModificaAdiccion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmModificaAdiccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <p>
        Modifcar Adiccion</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
    <form id="form1" runat="server">
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Lista Adicciones</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Nombre:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
            <asp:HiddenField ID="hdidAdicciones" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Codigo:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigoAdiccion" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        </p>
    </form>
</asp:Content>
