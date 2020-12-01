<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmEliminaRegistroPoliza.aspx.cs" Inherits="Proyecto_Final.Formularios.frmEliminaRegistroPoliza" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!---->
    <div id="frmEliminaRegistroPoliza">
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
                        <div class="row" style="display: flex">
                            <div class="column" style="flex: 50%; padding: 10px;">
                                <div class="form-group">
                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                                    <asp:HiddenField ID="hdUsuario" runat="server" />

                                    <br />
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblPrimerApellido" runat="server" Text="Primer Apellido:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblSegundoApellido" runat="server" Text="Segundo Apellido:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblCedula" runat="server" Text="Cedula:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                    <br />
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblIdUsuario" runat="server" Text="Tipo Empleado:"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtTipoEmpleado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>

                            </div>
                        </div>


                        <div class="container-fluid" style="text-align: center">
                            <div class="form-group" style="text-align: center">
                                <br />
                                <%-- <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-danger" OnClick="btnEliminar_Click" Text="Eliminar" />--%>
                                <button type="button" class="btn btn-default btn-lg" id="myBtn" style="height: 45px; width: 200px"><strong>Eliminar</strong></button>

                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmUsuarioLista.aspx ">Ir A Lista</asp:HyperLink>
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
