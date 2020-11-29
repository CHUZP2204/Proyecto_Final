<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmPaginaPrincipal.aspx.cs" Inherits="Proyecto_Final.Formularios.frmPaginaPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!--FORM PAGINA PRINCIPAL -->

        <p>HELLO WORLD</p>
        <h2>AQUI ES LA PAGINA PRINCIPAL</h2>
        <h1>
            <asp:Label ID="lblUSuarioConectado" runat="server" Text="Label" ForeColor="Red"></asp:Label>

        </h1>

        <asp:HyperLink ID="hplUserList" class="btn btn-primary" role="button" BorderColor="Black"
            runat="server" NavigateUrl="~/Formularios/frmUsuarioLista.aspx">Ver Lista</asp:HyperLink>
    <!--FIN FOR PAGINA PRINCIPAL-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
