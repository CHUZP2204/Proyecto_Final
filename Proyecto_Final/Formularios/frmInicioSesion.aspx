<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmInicioSesion.aspx.cs" Inherits="Proyecto_Final.Formularios.frmInicioSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <style>
        .modal-header, h4, .close {
            background-color: #5cb85c;
            color: white !important;
            text-align: center;
            font-size: 30px;
        }

        .modal-footer {
            background-color: #f9f9f9;
        }
        .auto-style1 {
            color: #0066FF;
        }
    </style>
    <div class="container">
        <h2 class="auto-style1"><strong>Inicia Sesion O Registrate</strong></h2>
        <!-- Trigger the modal with a button -->
        <button type="button" class="btn btn-default btn-lg" id="myBtn"><strong>Login</strong></button>

        <!-- Modal -->
        <div class="modal fade" data-backdrop='static' id="myModal" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header" style="padding: 35px 50px;">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4><span class="fas fa-lock"></span>Login</h4>
                    </div>
                    <div class="modal-body" style="padding: 40px 50px;">
                        <form id="form1" runat="server">
                            <!--Nombre Usuario-->
                            <div class="form-group">
                                <label  ><span class="fas fa-user"></span>Username</label>
                                <asp:TextBox ID="txtUserName" runat="server"  TextMode="Email" placeholder="Enter Email" required="required"  Width="500px" ></asp:TextBox>
                  
                                
                                
                            </div>
                            <!---->
                            <!--Contraseña-->
                            <div class="form-group">
                                <label ><span class="fas fa-eye"></span>Password</label>
                                <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password" placeholder="Enter password" required="required"  Width="500px" ></asp:TextBox>
                            </div>
                           
                            <!---->
                            <!---->
                            <!--CHEKC Recordar -->
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox" value="" checked>Remember me</label>
                            </div>
                            <asp:Button ID="btnLogin" runat="server" Text="Login"  CssClass="btn-success btn-block" BorderStyle="Groove" OnClick="btnLogin_Click" weight="100px" />
                             <asp:HyperLink ID="hpRegistrar" runat="server"  ForeColor="#FFCC00" NavigateUrl="~/Formularios/frmInsertUsuario.aspx " >Registrar</asp:HyperLink>
                        </form>
                    </div>
                    <div class="modal-footer">
                        <button type="submit" class="btn btn-danger btn-default pull-left" data-dismiss="modal"><span class="fas fa-ban"></span>Cancel</button>
                        <p>Not a member? <a href="#">Sign Up</a></p>
                        <p>Forgot <a href="#">Password?</a></p>
                    </div>
                </div>

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

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
