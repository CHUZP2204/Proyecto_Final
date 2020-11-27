<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertarAdiccion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertarAdiccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
    <form id="form1" runat="server">
        <h1>Agregar nueva Adiccion</h1>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Lista Adicciones</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Nombre:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
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
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
        </p>
    </form>
</asp:Content>
