<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Agencia.Master" CodeBehind="frmAutomovil.aspx.vb" Inherits="AgenciaWeb.frmAutomovil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="lblAutomovilId" runat="server" Text="Automovil Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAutomovilId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAnio" runat="server" Text="Año"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResultado" runat="server" Text="---"></asp:Label>
            </td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Button ID="cmdGrabar" runat="server" Text="Grabar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr colspan="4">
            <asp:GridView ID="grvAutomovil" runat="server"></asp:GridView>
        </tr>
    </table>
</asp:Content>
