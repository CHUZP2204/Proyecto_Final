﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmEliminaAdiccionesUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmEliminaAdiccionesUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="frmEliminaCobertura" class="form-inline">

        <asp:HiddenField ID="hdIdUsuario" runat="server" />
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
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaAdiccionesUsuario.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Elimina Las Adicciones Del Usuario</h3>
                            </div>

                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine;">
                        <div class="row" style="display: flex">
                            <div class="column" style="flex: 50%; padding: 10px;">
                                <div class="form-group">
                                    <asp:Label ID="lblIdentificadorAdiccion" runat="server" Text="Identificador Adiccion:" Style="font-weight: 700"></asp:Label>
                                    <asp:HiddenField ID="hdAdiccionesUsuario" runat="server" />
                                    <br />
                                    <asp:TextBox ID="txtIdentificadorAdiccion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                                <br>
                                 <br />
                                <div class="form-group">
                                    <asp:Label ID="lblIdentificadorUsuario" runat="server" Text="Identificador Usuario:" Style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtIdentificadorUsuario" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="container-fluid" style="text-align: center">
                            <div class="form-group" style="text-align: center">
                                <br />
                                <button type="button" class="btn btn-default btn-lg" id="myBtn" style="height: 45px; width: 200px"><strong>Eliminar</strong></button>
                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmListaAdiccionesUsuario.aspx ">Ver Lista</asp:HyperLink>
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
        <!-- Modal -->
        <div class="modal fade" data-backdrop='static' id="myModal" role="dialog">
            <div class="modal-dialog">
                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header" style="padding: 35px 50px;">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4><span class="fas fa-lock" style="margin-left: 20%"></span>Estas seguro que desea Eliminarlo</h4>
                    </div>
                    <br />
                    <asp:Button ID="btnsi" runat="server" Text="Si" CssClass="btn-success btn-block" BorderStyle="Groove" OnClick="btnsi_Click" weight="100px" />
                    <br />
                    <asp:Button ID="btnno" runat="server" Text="No" CssClass="btn-success btn-block" BorderStyle="Groove" OnClick="btnno_Click" weight="100px" />
                    <br />
                </div>
            </div>
        </div>
        <script>
            $(document).ready(function () {
                $("#myBtn").click(function () {
                    $("#myModal").modal();
                });
            });
        </script>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
