﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/trabajarnosotros.aspx.cs" Inherits="View_trabajarnosotros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label11" runat="server" Text="¿Como trabajar con Super Fast?"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" 
Text="
Se debe diligenciar un formulario en el cual
ingresera Nombre(s), apellido(s), , tipo de 
vehiculo, numero de cedula, correo elect-
ronico, una contraseña, Numero de telefono,
hoja de vida 10-03 en formato pdf y esperar 
aprobracion del administrador." Height="199px" Width="200px" BorderColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image3" runat="server" Height="200px" ImageUrl="~/Imagenes/_CCC7703.jpg" Width="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image4" runat="server" Height="200px" ImageUrl="~/Imagenes/_CCC7766.jpg" Width="300px" />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BTN_iniciarsesion" runat="server" BackColor="#3399FF" BorderColor="White" OnClick="Button2_Click" Text="Iniciar sesion" Width="95px" />
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BNT_registrarse" runat="server" BackColor="#3399FF" BorderColor="White" OnClick="Button1_Click" Text="Regitrarse" Width="95px" />
<br />
&nbsp;
</asp:Content>
