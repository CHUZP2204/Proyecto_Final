<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmModificaAdiccion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmModificaAdiccion" %>

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
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaAdicciones.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Modificar Adiccion</h3>
                            </div>
                        </div>
                    </div>
                    <!--PANEL BODY-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <asp:HiddenField ID="hdidAdicciones" runat="server" />
                        <p>
                            &nbsp;
                        </p>
                        <p>
                            Nombre:&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>

                        </p>
                        <p>
                            &nbsp;
                        </p>
                        <p>
                            Codigo:&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtCodigoAdiccion" runat="server"></asp:TextBox>
                        </p>
                        <p>
                            &nbsp;
                        </p>
                        <p>
                            <asp:Button ID="btnModificar" class="btn btn-primary" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                            <br />
                            <br />
                            <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Ver Lista</asp:HyperLink>
                        </p>
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
