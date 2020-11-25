<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmInsertUsuario" runat="server" class="form-inline">
        <div>

            <!--Panel-->
            <div class="panel panel-primary" style="text-align: center; border: inset; margin-left: 100px; margin-right: 100px">


                <!--Encabezado Del Panel-->
                <div class="panel-heading">
                    <h1 class="auto-style1">Registro De Un Usuario</h1>
                </div>
                <!--Fin Encabezado Del Panel-->
                <!--Cuerpo Del Panel-->
                <div class="panel-body" style="background-color: aquamarine">

                    <!-- Columnnas Del Panel-->
                    <div class="row" style="display: flex">
                        <!-- Primera Columnna Del Panel-->
                        <div class="column" style="flex: 50%; padding: 10px;">

                            <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Cedula"></asp:Label>
                                <br />
                                <asp:TextBox class="form-control" ID="txtCedula" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Debe ingresar el numero de cedula" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />



                            <div class="form-group">
                                <asp:Label ID="label1" runat="server" Text="Fecha Nacimiento"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtfechanacimiento" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="form-control" ID="rqvtxtfechanacimiento" runat="server" ControlToValidate="txtfechanacimiento" ErrorMessage="Debe ingresar la Fecha de Nacimiento" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvTxtNombre" runat="server" ControlToValidate="txtNombre" CssClass="form-control" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPrimerApellido" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Debe ingresar el primer apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label8" runat="server" Text="Segundo Apellido"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvTxtSegundoApellido" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="label" runat="server" Text="Genero"></asp:Label>
                                <br />
                                <asp:DropDownList class="form-control" ID="ddlgenero" runat="server" DataTextField="nombre" DataValueField="Genero" Height="35px" Width="115px">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>

                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rqvgenero" runat="server" ControlToValidate="ddlgenero" ErrorMessage="Debe seleccionar el genero" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                        </div>
                        <!--Fin Primera Columna-->
                        <!-- Segunda Columnna Del Panel-->
                        <div class="column" style="flex: 50%; padding: 10px;">

                            <div class="form-group">
                                <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtdireccion" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtdireccion" runat="server" ControlToValidate="txtdireccion" ErrorMessage="Debe ingresar la direccion" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label6" runat="server" Text="Teléfono Principal"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtTelefonoprincipal" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtTelefonoprincipal" runat="server" ControlToValidate="txtTelefonoprincipal" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono principal" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label7" runat="server" Text="Teléfono Secundario"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtTelefonosecundario" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtTelefonosecundario" runat="server" ControlToValidate="txtTelefonosecundario" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono secundario" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label10" runat="server" Text="Correo"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtcorreo" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtcorreo" runat="server" ControlToValidate="txtcorreo" ErrorMessage="Debe ingresar su correo" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label11" runat="server" Text="Contraseña"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtContrasenia" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="Debe Ingresar Una Contraseña" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </div>
                            <br />

                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Tipo Usuario"></asp:Label>
                                <br />
                                <asp:ListBox ID="LstTipoUsuario" runat="server" Class="form-control" DataTextField="nombre" DataValueField="tipousuario" Height="42px" Width="126px">
                                    <asp:ListItem>Cliente</asp:ListItem>
                                    <asp:ListItem>Empleado</asp:ListItem>
                                    <asp:ListItem>Administrador</asp:ListItem>
                                </asp:ListBox>
                                <asp:RequiredFieldValidator ID="rqvTipoUsuario" runat="server" ErrorMessage="Debe seleccionar el Tipo de Usuario" Display="None"
                                    ControlToValidate="LstTipoUsuario"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <!--Fin Segunda Columna-->
                    </div>
                    <!--Fin Div Columnas-->
                </div>
                <!--Fin Cuerpo Panel-->
            </div>
            <!--Fin Panel-->
            <div class="container-fluid" style="text-align: center">
                <div class="form-group" style="text-align: center">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btAceptar" runat="server" Text="Guardar" CssClass="btn-primary" OnClick="btAceptar_Click" BorderColor="Black" BorderStyle="Double" ForeColor="Black" Height="42px" Width="162px" />

                    <%-- <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/FORMULARIO.BASE.DATOS/frmClientesLista.aspx">Regresar Lista</asp:HyperLink>--%>

           &nbsp;
                     <asp:HyperLink ID="hplstUsers" CssClass="btn-primary" runat="server" ForeColor="#FFCC00" NavigateUrl="~/FormulariosBaseDatos/frmUsuarioLista.aspx ">Registrar</asp:HyperLink>
                </div>
            </div>


            <br />

        </div>
        <asp:ValidationSummary ID="vsRegistroUsuario" runat="server" ShowMessageBox="True" ShowSummary="False" />

    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
