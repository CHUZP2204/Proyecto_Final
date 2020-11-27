<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertaAdicciones.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertaAdicciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">




    <form id="form1" runat="server">
        <h1><strong>IAgregar nueva Adiccion </strong></h1>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server">Ver Lista Adicciones</asp:HyperLink>
        </p>
        <h1>&nbsp;</h1>
        <p class="auto-style1">
&nbsp; Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <h1 class="auto-style2">Codigo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigoAdicciones" runat="server"></asp:TextBox>
        </h1>
        <p>
        </p>
        <h1>
            <br />
            <asp:Button ID="btnAceptarAdccion" runat="server" OnClick="btnAceptarAdccion_Click" Text="Aceptar" />
        </h1>
    </form>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
