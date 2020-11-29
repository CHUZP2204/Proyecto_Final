<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGES/MaterPages.Master" AutoEventWireup="true" CodeBehind="frmListaAdicciones.aspx.cs" Inherits="Proyecto_Final.Formularios.frmListaAdicciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptspersonalizados" runat="server">
    <div id="form1" >
        <h1>Lista Adicciones</h1>
        <p>
            <asp:HyperLink ID="hpNuevaAdiccion" runat="server" NavigateUrl="~/Formularios/frmInsertarAdiccion.aspx">Nueva Adiccion</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Nombre:&nbsp;
            <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Codigo&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigoAdiccion" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="grdListaAdiccion" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" Height="288px" OnPageIndexChanging="grdListaAdiccion_PageIndexChanging" PageSize="4" Width="661px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="idAdicciones" HeaderText="Identificador" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Adiccion" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo Adiccion" />
                    <asp:HyperLinkField DataNavigateUrlFields="idAdicciones" DataNavigateUrlFormatString="frmModificaAdiccion.aspx?idAdicciones={0}" Text="Modificar" />
                    <asp:HyperLinkField DataNavigateUrlFields="idAdicciones" DataNavigateUrlFormatString="frmEliminaAdiccion.aspx?idAdicciones={0}" Text="Eliminar" />
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
        </p>
    </div>
</asp:Content>
