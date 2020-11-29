<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmModificaCobertura.aspx.cs" Inherits="Proyecto_Final.Formularios.frmModificaCobertura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
<div id="frmModificarCobertura"  class="form-inline">
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
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaCobertura.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Modificar Cobertura</h3>
                            </div>
                        </div>
                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->

                    <div class="panel-body" style="background-color: aquamarine">
                        <asp:HiddenField ID="hdidCobertura" runat="server" />
                        <!-- Columnnas Del Panel-->
                        <div class="row" style="display: flex">
                            <!-- Primera Columnna Del Panel-->
                            <div class="column" style="flex: 50%; padding: 10px;">
                                 <!--Campo nombre-->
                                <div class="form-group">
                                    <asp:Label ID="Label12" runat="server" Text="Nombre"></asp:Label>
                                    <br />
                                    <asp:TextBox class="form-control" ID="txtnombre" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtnombre"
                                        ErrorMessage="Debe ingresar un nombre no repetido"
                                        ForeColor="Red"
                                        Display="None"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                <!--FIN Campo nombre-->
                                <!--Campo descripcion-->
                                <div class="form-group">
                                    <asp:Label ID="label13" runat="server" Text="Descripcion"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtdescripcion" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtdescripcion" runat="server"
                                        ControlToValidate="txtdescripcion"
                                        ErrorMessage="Debe ingresar una descripcion"
                                        ForeColor="Red"
                                        Display="None"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                <!--Fin Campo descripcion-->
                                <!--Campo Porcentaje-->
                                <div class="form-group">
                                    <asp:Label ID="Label14" runat="server" Text="Porcentaje"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtporcentaje" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtporcentaje" runat="server"
                                        ControlToValidate="txtporcentaje"
                                        ErrorMessage="Debe ingresar un porcentaje mayor a '0' o igual o menor a '100'"
                                        ForeColor="Red"
                                        Display="None"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                <!--Fin Campo Porcentaje-->
                            </div>
                        </div>
                        <!--Fin Div Columnas-->
                        <!--Campo Boton-->
                        <div class="container-fluid" style="text-align: center">
                            <div class="form-group" style="text-align: center">

                                <asp:Button ID="btAceptar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btAceptar_Click" BorderColor="Black" BorderStyle="Double" ForeColor="Black" Height="42px" Width="162px" />
                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmListaCobertura.aspx ">Ver Lista Cobertura</asp:HyperLink>
                                <br />
                            </div>
                        </div>
                        <br />
                        <!--Fin Campo Boton-->
                    </div>
                    <!--Fin Cuerpo Panel-->
                </div>
                <!--Fin Panel-->
            </div>
            <!---->
        </div>
        <asp:ValidationSummary ID="vsRegistroCobertura" runat="server" ShowMessageBox="True" ShowSummary="False" />
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
