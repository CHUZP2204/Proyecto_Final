<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInsertRegistroPoliza.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInsertRegistroPoliza" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <!--Pagina Inserta Poliza-->
    <div id="frmRegistroPoliza>">
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
                                <asp:HyperLink ID="hplAtrasInicio" NavigateUrl="~/Formularios/frmListaPolizas.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">Registro De Una Poliza</h3>
                            </div>


                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--Cuerpo Del Panel-->
                    <div class="panel-body" style="background-color: aquamarine">

                        <!-- Columnnas Del Panel-->
                        <div class="row" style="display: flex">
                            <!-- Primera Columnna Del Panel-->
                            <div class="column" style="flex: 50%; padding: 10px;">
                             
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Monto Asegurado"></asp:Label>
                                    <br />
                                    <asp:TextBox class="form-control" ID="txtMontoAsegurado" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtMontoAsegurado" runat="server"
                                        ControlToValidate="txtMontoAsegurado"
                                        ErrorMessage="Debe ingresar un monto asegurado de la poliza"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                             
                                <div class="form-group">
                                    <asp:Label ID="label1" runat="server" Text="Porcentaje Cobertura"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPorcentajeCobertura" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtPorcentajeCobertura" runat="server"
                                        ControlToValidate="txtPorcentajeCobertura"
                                        ErrorMessage="Debe ingresar un porcentaje de la cobertura"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                              
                                <div class="form-group">
                                    <asp:Label ID="Label5" runat="server" Text="Numero Adicciones"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtNumeroAdicciones" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtNumeroAdicciones" runat="server"
                                        ControlToValidate="txtNumeroAdicciones"
                                        ErrorMessage="Debe ingresar un numero de total de Adicciones"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                             
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Monto Adicciones"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtMontoAdicciones" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtMontoAdicciones" runat="server"
                                        ControlToValidate="txtMontoAdicciones"
                                        ErrorMessage="Debe ingresar un monto de las Adicciones"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                            
                                <div class="form-group">
                                    <asp:Label ID="Label8" runat="server" Text="Prima Antes Impuesto"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPrimaAntesImpu" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtPrimaAntesImpu" runat="server"
                                        ControlToValidate="txtPrimaAntesImpu"
                                        ErrorMessage="Debe ingresar la prima antes del Impuesto"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                             
                              <div class="form-group">
                                    <asp:Label ID="Label12" runat="server" Text="Impuestos"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtImpuestos" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtImpuestos" runat="server"
                                        ControlToValidate="txtImpuestos"
                                        ErrorMessage="Debe ingresar el monto del impuesto que se va aplicar"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                               
                            </div>
                            <!--Fin Primera Columna-->
                            <!-- Segunda Columnna Del Panel-->
                            <div class="column" style="flex: 50%; padding: 10px;">
                               
                                <div class="form-group">
                                    <asp:Label ID="Label9" runat="server" Text="Prima Final"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtPrimaFinal" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtPrimaFinal" runat="server"
                                        ControlToValidate="txtPrimaFinal"
                                        ErrorMessage="Debe ingresar la prima final de la poliza"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                
                                <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Id Seguro"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtIdSeguro" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtIdSeguro" runat="server"
                                        ControlToValidate="txtIdSeguro"
                                        ErrorMessage="Debe ingresar el ID del Seguro"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                             
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text=" Id Usuario"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtIdUsuario" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvttxtIdUsuario" runat="server"
                                        ControlToValidate="txtIdUsuario"
                                        ErrorMessage="Debe ingresar el ID del Usuario"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                            
                                <div class="form-group">
                                    <asp:Label ID="Label10" runat="server" Text="Id Cobertura"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="txtIdCobertura" runat="server" Class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqvtxtIdCobertura" runat="server"
                                        ControlToValidate="txtIdCobertura"
                                        ErrorMessage="Debe ingresar el ID de la Cobertura"
                                        ForeColor="Red"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                             </div>
                            <!--Fin Segunda Columna-->
                        </div>
                        <!--Fin Div Columnas-->
                        <!--Campo Boton-->
                        <div class="container-fluid" style="text-align: center">
                            <div class="form-group" style="text-align: center">

                                <asp:Button ID="btAceptar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btAceptar_Click" BorderColor="Black" BorderStyle="Double" ForeColor="Black" Height="42px" Width="162px" />

                                <%-- <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/FORMULARIO.BASE.DATOS/frmClientesLista.aspx">Regresar Lista</asp:HyperLink>--%>
                                <br />
                                <br />
                                <asp:HyperLink ID="hplstUsers" class="btn btn-primary" role="button" BorderColor="Black"
                                    runat="server" NavigateUrl="~/Formularios/frmListaPolizas.aspx ">Ver Lista</asp:HyperLink>
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
        </div>
    </div>
    <!--FIN Pagina Inserta Poliza-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
