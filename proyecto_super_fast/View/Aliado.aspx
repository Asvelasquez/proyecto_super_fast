<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Aliado.aspx.cs" Inherits="View_Aliado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
        .auto-style36 {
            width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td class="auto-style36">
                <br />
&nbsp;<asp:Label ID="LB_nombreproducto" runat="server" Text="Nombre del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_nombreproducto" runat="server"></asp:TextBox>
                <br />
&nbsp;<asp:Label ID="LB_descripcionproducto" runat="server" Text="Descripcion del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_descripcionproducto" runat="server"></asp:TextBox>
                <br />
&nbsp;<asp:Label ID="LB_precioproducto" runat="server" Text="Precio del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_precioproducto" runat="server" TextMode="Number"></asp:TextBox>
                <br />
&nbsp;<asp:Label ID="LB_imagenproducto1" runat="server" Text="Cargar imagen del producto #1"></asp:Label>
                <br />
&nbsp;<asp:FileUpload ID="FP_imagen1" runat="server" />
                <br />
&nbsp;<asp:Label ID="Label11" runat="server" Text=" Cargar imagen del producto #2"></asp:Label>
                <br />
&nbsp;<asp:FileUpload ID="FP_imagen2" runat="server" />
                <br />
&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BTN_guardarproducto" runat="server" OnClick="BTN_guardarproducto_Click" Text="Guardar" />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

