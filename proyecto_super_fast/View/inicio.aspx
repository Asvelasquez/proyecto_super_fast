<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/inicio.aspx.cs" Inherits="View_inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style10 {
        height: 50%;
        vertical-align:top;
    }
        .auto-style11 {
            height: 2%;
            vertical-align: top;
        }
        .auto-style12 {
            height: 1%;
            vertical-align: top;
            width: 50%;
        }
        .auto-style13 {
            height: 1%;
            font-size: medium;
        }
        .auto-style14 {
            height: 1%;
            vertical-align: top;
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style11" colspan="2">
            <asp:Menu ID="Menu_principal" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px" Width="100%" StaticDisplayLevels="5">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#B5C7DE" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem Text="Todo" Value="Inicio"></asp:MenuItem>
                    <asp:MenuItem Text="Restaurantes" Value="Restaurantes"></asp:MenuItem>
                    <asp:MenuItem Text="Supermercados" Value="Supermercados"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
        </td>
    </tr>
    <tr>
        <td class="auto-style14">
            <h1 class="auto-style13">Filtros</h1>
        </td>
        <td class="auto-style11"></td>
    </tr>
    <tr>
        <td class="auto-style12">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">&nbsp;</td>
    </tr>
</table>
</asp:Content>

