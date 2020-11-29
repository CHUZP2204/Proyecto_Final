<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertarAdiccion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertarAdiccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
    <div id="form1">
        <h1>Agregar nueva Adiccion</h1>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Lista Adicciones</asp:HyperLink>
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>&nbsp;&nbsp; 
            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rqvtxtNombreAdiccion" runat="server" ControlToValidate="txtNombreAdiccion" ErrorMessage="Debe Ingresar un Nombre" ForeColor="Red"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </p>

        <p>
            &nbsp;
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Codigo"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigoAdiccion" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rqvtxtCodigoAdiccion" runat="server" ControlToValidate="txtCodigoAdiccion" ErrorMessage="Debe Ingresar un Codigo" ForeColor="Red"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        </p>
    </div>
</asp:Content>
