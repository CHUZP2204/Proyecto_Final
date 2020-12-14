<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmModificarAdiccionesUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmModificarAdiccionesUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="form1">
        <!--CONTENIDO-->
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">
            <div class="container-fluid" style="width: 500px">
                <!--PANEL-->
                <div class="panel panel-primary"
                    style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                    <!--Encabezado Del Panel-->
                    <div class="panel-heading">
                        <div class="row" style="display: flex">
                            <div style="margin-left: 10px; margin-top: 15px">
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaAdiccionesUsuario"
                                    class="btn btn-danger" runat="server"> <i class="fas fa-backspace"></i></asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Modificar Las Adicciones Del Usuario </h3>
                            </div>
                        </div>
                    </div>
                    <!--PANEL BODY-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <asp:HiddenField ID="hdAdiccionesUsuario" runat="server" />
                            <div class="form-group">
                                <asp:Label ID="Label12" runat="server" Text="Identificador Adiccion:" Style="font-weight: 700"></asp:Label>
                                <br />
                                <asp:TextBox class="form-control" ID="txtIdentificacionAdiccion" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtIdentificacionAdiccion" runat="server"
                                    ControlToValidate="txtIdentificacionAdiccion"
                                    ErrorMessage="Debe Ingresar un Numero de Identificador de Adicciones"
                                    ForeColor="Red"
                                    Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>

                            <br />
                            <div class="form-group">
                                <asp:Label ID="label13" runat="server" Text="Identificador Usuario:" Style="font-weight: 700"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtIdentificacionUsuario" runat="server" Class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqvtxtIdentificacionUsuario" runat="server"
                                    ControlToValidate="txtIdentificacionUsuario"
                                    ErrorMessage="Debe Ingresar un Numero de Identificador de Usuario"
                                    ForeColor="Red"
                                    Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>

                            <br />
                            <asp:Button ID="btnModificar" class="btn btn-primary" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                            <br />
                            <br />
                            <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                runat="server" NavigateUrl="~/Formularios/frmListaAdiccionesUsuario.aspx">Ver Lista</asp:HyperLink>
                    </div>
                    <!--FIN BODY PANEL-->
                </div>
            </div>
            <!--FIN PANEL-->
        </div>
        <!--FIN CONTENIDO-->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
