<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmListaAdiccionesUsuario.aspx.cs" Inherits="Proyecto_Final.Formularios.frmListaAdiccionesUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">  
    <div id="form1">
        <div style="background-color: #699186; filter: drop-shadow(5px 5px 10px #444)">
            <div class="container-fluid" style="width: 500px">
                <!--Panel-->
                <div class="panel panel-primary"
                    style="text-align: center; border: solid 5px black; border-radius: 1em; filter: drop-shadow(15px 15px 20px #444); margin-left: 10px; margin-right: 10px; margin-top: 20px; margin-bottom: 20px">
                    <!--Encabezado Del Panel-->
                    <div class="panel-heading">
                        <div class="row" style="display: flex">
                            <div style="margin-left: 10px; margin-top: 15px">
                                <asp:HyperLink ID="hplAtras" NavigateUrl="~/Formularios/frmPaginaPrincipal.aspx"
                                    class="btn btn-danger" runat="server">
                                    <i class="fas fa-backspace"></i>
                                </asp:HyperLink>
                            </div>
                            <div style="margin-bottom: 10px; padding-left: 40px; padding-right: 40px">
                                <h3 class="auto-style1">LISTA LAS ADICCIONES DEL USUARIO</h3>
                            </div>
                        </div>

                    </div>
                    <!--Fin Encabezado Del Panel-->
                    <!--PANEL CUERPO-->
                    <div class="panel-body" style="background-color: aquamarine">
                        <div class="form-group">
                            <asp:HyperLink ID="hpAdiccionUsuario" runat="server" NavigateUrl="~/Formularios/frmInsertAdiccionesUsuario.aspx">Nueva Adiccion Del Usuario</asp:HyperLink>
                        </div>
                        <div class="form-group">
                            <label>Identificador Adiccion:</label>
                            <asp:TextBox ID="txtIdentificacionAdiccion" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Identificador Usuario:</label>
                            <asp:TextBox ID="txtIdentificacionUsuario" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnMostrar" CssClass="btn btn-primary" runat="server" OnClick="btnMostrar_Click" Text="Mostrar Datos" />
                        </div>


                        <div class="form-group">
                            <asp:GridView ID="grdListaAdiccionUsuario" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" 
                                AutoGenerateColumns="False" Height="288px" OnPageIndexChanging="grdListaAdiccionUsuario_PageIndexChanging" PageSize="4" Width="400px">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:BoundField DataField="IdIdentificador" HeaderText="Identificador" />
                                    <asp:BoundField DataField="IdAdicciones" HeaderText="Identificador Adiccion" />
                                    <asp:BoundField DataField="IdUsuario" HeaderText="Identificador Usuario" />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdIdentificador" DataNavigateUrlFormatString="frmModificarAdiccionesUsuario.aspx?IdIdentificador={0}" Text="Modificar" />
                                    <asp:HyperLinkField DataNavigateUrlFields="IdIdentificador" DataNavigateUrlFormatString="frmEliminaAdiccionesUsuario.aspx?IdIdentificador={0}" Text="Eliminar" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
   
</asp:Content>
