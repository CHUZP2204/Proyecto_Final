<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmInsertUsuario" runat="server" class="form-inline">
        <h1 class="auto-style1">Ingresar Nuevo Usuario</h1>

        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Cedula"></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Debe ingresar el numero de cedula" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="label" runat="server" Text="Genero"></asp:Label>
            <asp:DropDownList ID="ddlgenero" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="Genero" Height="35px" Width="115px">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femenino</asp:ListItem>

            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rqvgenero" runat="server" ControlToValidate="ddlgenero" ErrorMessage="Debe seleccionar el genero" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="label1" runat="server" Text="Fecha Nacimiento"></asp:Label>
            <asp:TextBox ID="txtfechanacimiento" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtfechanacimiento" runat="server" ControlToValidate="txtfechanacimiento" ErrorMessage="Debe ingresar la Fecha de Nacimiento" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvTxtNombre" runat="server" ControlToValidate="txtNombre" CssClass="form-control" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
            <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Debe ingresar el primer apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Segundo Apellido"></asp:Label>
            <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvTxtSegundoApellido" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txtdireccion" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtdireccion" runat="server" ControlToValidate="txtdireccion" ErrorMessage="Debe ingresar la direccion" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Teléfono Principal"></asp:Label>
            <asp:TextBox ID="txtTelefonoprincipal" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtTelefonoprincipal" runat="server" ControlToValidate="txtTelefonoprincipal" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono principal" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Teléfono Secundario"></asp:Label>
            <asp:TextBox ID="txtTelefonosecundario" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtTelefonosecundario" runat="server" ControlToValidate="txtTelefonosecundario" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono secundario" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox ID="txtcorreo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtcorreo" runat="server" ControlToValidate="txtcorreo" ErrorMessage="Debe ingresar su correo" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtContrasenia" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="Debe Ingresar Una Contraseña" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>


        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Tipo Usuario"></asp:Label>
            <asp:ListBox ID="LstTipoUsuario" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="tipousuario" Height="42px" Width="126px">
                <asp:ListItem>Cliente</asp:ListItem>
                <asp:ListItem>Empleado</asp:ListItem>
                <asp:ListItem>Administrador</asp:ListItem>
            </asp:ListBox>
            <asp:RequiredFieldValidator ID="rqvTipoUsuario" runat="server" ErrorMessage="Debe seleccionar el Tipo de Usuario" Display="None"
                ControlToValidate="LstTipoUsuario"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Button ID="btAceptar" runat="server" Text="Guardar" CssClass="btn-success" OnClick="btAceptar_Click" BackColor="White" BorderColor="Black" BorderStyle="Double" ForeColor="Black" Height="42px" Width="162px" />

            <%-- <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/FORMULARIO.BASE.DATOS/frmClientesLista.aspx">Regresar Lista</asp:HyperLink>--%>

           &nbsp;
           <asp:HyperLink ID="hpListaUsuario" runat="server" NavigateUrl="~/Formulario Base Datos/frmUsuarioLista.aspx">Lista Usuarios</asp:HyperLink>

        </div>

        <br />
        <asp:ValidationSummary ID="vsRegistroUsuario" runat="server" ShowMessageBox="True" ShowSummary="False" />

    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
