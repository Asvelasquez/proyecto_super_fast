﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Registrarse.aspx.cs" Inherits="View_Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            height: 20%;
            text-align: center;
        }
        .auto-style12 {
            text-align: center;
            height: 20%;
        }
        .auto-style13 {
            font-size: large;
        }
        .auto-style14 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style15 {
            text-align: center;
             height: 20%;
            height: 30px;
        }
        .auto-style16 {
            text-align: center;
            height: 5%;
            width: 11%;
        }
        .auto-style17 {
            text-align: center;
            width: 11%;
        }
        .auto-style18 {
            text-align: center;
            width: 12%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">
                <strong>
                <asp:Label ID="LB_Nombre" runat="server" Text="Nombre" CssClass="auto-style13"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:TextBox ID="TB_Nombre" runat="server" Width="20%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Nombre" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <strong>
                <asp:Label ID="LB_Apellido" runat="server" Text="Apellido" CssClass="auto-style13"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:TextBox ID="TB_Apellido" runat="server" Width="20%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Apellido" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Apellido" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <strong>
                <asp:Label ID="LB_Correo" runat="server" Text="Correo" CssClass="auto-style13"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:TextBox ID="TB_Correo" runat="server" Width="20%" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Correo" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Correo" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <strong>
                <asp:Label ID="LB_Telefono" runat="server" Text="Telefono" CssClass="auto-style13"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:TextBox ID="TB_Telefono" runat="server" Width="20%" TextMode="Phone"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Telefono" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Telefono" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <strong>
                <asp:Label ID="LB_Contrasenia" runat="server" Text="Contraseña" CssClass="auto-style13"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:TextBox ID="TB_Contrasenia" runat="server" TextMode="Password" Width="20%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Contrasenia" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Contrasenia" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>
                <asp:Label ID="LB_Direccion" runat="server" Text="Direccion" CssClass="auto-style13"></asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:TextBox ID="TB_Direccion" runat="server" Width="20%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Direccion" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TB_Direccion" ValidationGroup="VG_Registrar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>
                <asp:CheckBox ID="CB_Terminos" runat="server" CssClass="auto-style13" Text="Acepto terminos y condiciones" ValidateRequestMode="Enabled" />
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>
                <asp:Button ID="BT_Registrar" runat="server" CssClass="auto-style14" Text="Registrarme" OnClick="BT_Registrar_Click" ValidationGroup="VG_Registrar" />
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>
                <asp:Label ID="LB_Ingresar" runat="server" CssClass="auto-style13" Text="¿ya tienes  una cuenta?"></asp:Label>
                <asp:HyperLink ID="HL_Ingresar" runat="server" CssClass="auto-style13">Ingresar</asp:HyperLink>
                </strong></td>
        </tr>
    </table>
</asp:Content>

