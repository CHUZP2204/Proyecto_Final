<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmUsuarios.aspx.cs" Inherits="Proyecto_Final.Formularios.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Mostrar Usuarios" style="font-size: xx-large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Button ID="btnAceptar" runat="server" CssClass="btn-success" ForeColor="Black" OnClick="btnAceptar_Click" Text="Buscar" />
        <br />
        <br />
        &nbsp;<asp:GridView ID="grdUsuarios" runat="server" BorderColor="#999999" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False" BackColor="White" BorderStyle="None" BorderWidth="1px" Height="103px" OnSelectedIndexChanged="grdUsuarios_SelectedIndexChanged" Width="596px">
            <AlternatingRowStyle BackColor="#DCDCDC" HorizontalAlign="Justify" VerticalAlign="Bottom" />
            <Columns>
                <asp:BoundField DataField="IdUsuario" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="PrimerApellido" HeaderText="Primer Apellido" />
                <asp:BoundField DataField="SegundoApellido" HeaderText="Segundo Apellido" />
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" />
            </Columns>
            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hpRegistrar" runat="server"  ForeColor="#FFCC00" NavigateUrl="~/Formularios/frmInsertUsuario.aspx " >Registrar</asp:HyperLink>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="OpenModal" runat="server" Text="Abrir Modal" OnClick="OpenModal_Click" />
        <br />
        <div id="message"></div>
        <br />
        <br />

        <script>
            function showMessage(msg) {

                const message = document.querySelector("#message");

                var html = "<div class='modal' data-backdrop='static' id='myModal' tabindex='-1' role='dialog'> " +
                    "      <div class='modal-dialog  modal-dialog-centered' >" +
                    "        <div class='modal-content'>" +
                    "            <div class='modal-header'>" +
                    "                <h5 class='modal-title'>Validación</h5>" +
                    "           <button type='button' class='close' data-dismiss='modal' aria-label='Close'>" +
                    "               <span aria-hidden='true'>&times;</span>" +
                    "            </button>" +
                    "        </div>" +
                    "        <div class='modal-body'>" +
                    "            <p>" + msg + "</p>" +
                    "        </div>" +
                    "        <div class='modal-footer'>" +
                    "            <button type='button' class='btn btn-primary' data-dismiss='modal'>Ok</button>" +
                    "        </div>" +
                    "    </div>" +
                    "</div >" +
                    "</div >";

                message.innerHTML = html;

                $("#myModal").modal('show');
                //no tiene funcion
                /* $(function () {
                     $("#btnShow").click(function () {
                         showModal();
                     });
                 });*/
            }

        </script>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
</asp:Content>
