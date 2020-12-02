<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmEliminaRegistroPoliza.aspx.cs" Inherits="Proyecto_Final.Formularios.frmEliminaRegistroPoliza" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!---->
    <div id="frmEliminaRegistroPoliza">
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
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmListaPolizas.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Eliminar Poliza</h3>
                            </div>

                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine;">
                      <asp:HiddenField ID="hdRegistro" runat="server" />
                                <!-- Columnnas Del Panel-->
                                 <div class="row" style="display: flex">
                            <!-- Primera Columnna Del Panel-->
                            <div class="column" style="flex: 50%; padding: 10px;">
                               
                                <div class="form-group">
                                    <asp:Label ID="lblMontoAsegurado" runat="server" Text="Monto Asegurado:" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtMontoAsegurado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblPorcentajeCobertura" runat="server" Text="Porcentaje Cobertura :" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPorcentajeCobertura" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblMontoAdicciones" runat="server" Text="Monto Adicciones:" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtMontoAdicciones" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                                
                                <div class="form-group">
                                    <asp:Label ID="lblPrimaAntesImpu" runat="server" Text="Prima Antes Impuesto:" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPrimaAntesImpu" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                
                                 <div class="form-group">
                                    <asp:Label ID="lblImpuesto" runat="server" Text="Impuesto:" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtImpuesto" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                     </div>
                                  
                                <div class="form-group">
                                    <asp:Label ID="lblPrimaFinal" runat="server" Text="PrimaFinal:" style="font-weight: 700"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPrimaFinal" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                     </div>
                            </div>
                            <!--Fin Primera Columna-->
                             </div>
                        <!--Fin Div Columnas-->
                        <div class="container-fluid" style="text-align: center">
                            <div class="form-group" style="text-align: center">
                                <br />
                                <button type="button" class="btn btn-default btn-lg" id="myBtn" style="height: 45px; width: 200px"><strong>Eliminar</strong></button>
                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmListaPolizas.aspx ">Ir A Lista</asp:HyperLink>
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
    <!---->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
