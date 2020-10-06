<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Registrarse.aspx.cs" Inherits="View_Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            height: 23px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LB_Nombre" runat="server" Text="Nombre"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:TextBox ID="TB_Nombre" runat="server" Width="20%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LB_Apellido" runat="server" Text="Apellido"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:TextBox ID="TB_Apellido" runat="server" Width="20%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LB_Email" runat="server" Text="Email"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:TextBox ID="TB_Email" runat="server" Width="20%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LB_Contrasenia" runat="server" Text="Contraseña"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

