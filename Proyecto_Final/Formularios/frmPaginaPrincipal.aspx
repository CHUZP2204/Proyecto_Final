<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmPaginaPrincipal.aspx.cs" Inherits="Proyecto_Final.Formularios.frmPaginaPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!--FORM PAGINA PRINCIPAL -->
    <div>
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">

            <div class="container-fluid" style="">
                <!--Panel-->
                <div class="panel panel-primary"
                    style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                    <!--Encabezado Del Panel-->
                    <div class="panel-heading">
                        <div class="row">
                            <div>
                                <h3 class="auto-style1">Principal</h3>
                            </div>
                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <p>HELLO WORLD</p>
                        <h2>AQUI ES LA PAGINA PRINCIPAL</h2>
                        <h1>
                            <asp:Label ID="lblUSuarioConectado" runat="server" Text="Informacion Confidente" ForeColor="Red"></asp:Label>

                        </h1>

                        <asp:HyperLink ID="hplUserList" class="btn btn-primary" role="button" BorderColor="Black"
                            runat="server" NavigateUrl="~/Formularios/frmUsuarioLista.aspx">Ver Lista Usuarios</asp:HyperLink> 
                        <br/>
                         <br/>
                    <asp:HyperLink ID="hpPolizaList" class="btn btn-primary" role="button" BorderColor="Black"
                            runat="server" NavigateUrl="~/Formularios/frmListaPolizas.aspx">Ver Lista Polizas</asp:HyperLink> 
                        <br/>
                        <br/>
                        <asp:HyperLink ID="hpAdicList" class="btn btn-primary" role="button" BorderColor="Black"
                            runat="server" NavigateUrl="~/Formularios/frmListaAdicciones.aspx">Ver Lista Adicciones</asp:HyperLink> 
                        <br/>
                        <br/>
                        <asp:HyperLink ID="hpCoberList" class="btn btn-primary" role="button" BorderColor="Black"
                            runat="server" NavigateUrl="~/Formularios/frmListaCobertura.aspx">Ver Lista Coberturas</asp:HyperLink> 
                        <br/>
                        <br/>
                         <asp:HyperLink ID="hpAdicUsuList" class="btn btn-primary" role="button" BorderColor="Black"
                            runat="server" NavigateUrl="~/Formularios/frmListaAdiccionesUsuario.aspx">Ver Lista Adicciones de Usuarios</asp:HyperLink> 
                        <br/>
                        <br/>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--FIN FOR PAGINA PRINCIPAL-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
