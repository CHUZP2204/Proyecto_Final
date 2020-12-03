<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertarAdiccion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertarAdiccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
    <div id="form1">
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">
            <!---->
            <div class="container-fluid" style="width: 500px">
                <!--Panel-->
                <div class="panel panel-primary"
                    style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                    <!--Encabezado Del Panel-->
                    <div class="panel-heading">
                        <div class="row" style="display: flex">
                            <div style="margin-left: 10px; margin-top: 15px">
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaAdicciones.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">AGREGAR NUEVA ADICCION</h3>
                            </div>
                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->

                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>&nbsp;&nbsp; 
                            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="rqvtxtNombreAdiccion" runat="server"
                                ControlToValidate="txtNombreAdiccion"
                                ErrorMessage="Debe Ingresar un Nombre"
                                ForeColor="Red"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Codigo"></asp:Label>&nbsp;&nbsp;
                            <asp:TextBox ID="txtCodigoAdiccion" runat="server"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="rqvtxtCodigoAdiccion" runat="server"
                                ControlToValidate="txtCodigoAdiccion"
                                ErrorMessage="Debe Ingresar un Codigo"
                                ForeColor="Red"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                            <div class="form-group">
                                <br />
                                <asp:Button ID="btnAceptar" CssClass="btn btn-success" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Ver Lista</asp:HyperLink>
                            </div>
                        </div>
                        <!--FIN CUERPO APNEL-->
                    </div>
                </div>
                <!--FIN PANEL-->
            </div>
            <!---->
        </div>
    </div>
</asp:Content>
