<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Perfil.aspx.cs" Inherits="View_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
                    <asp:Image ID="Image3" runat="server" Height="73px" Width="98px" />
                    <br />
                    <asp:Label ID="LB_nombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="LB_apellido" runat="server" Text="Apellido"></asp:Label>
                    &nbsp;
                    <br />
                    <asp:TextBox ID="TB_nombreperfil" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TB_apellidoperfil" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <br />
                    <asp:Label ID="LB_correo" runat="server" Text="Correo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LB_contrasenia" runat="server" Text="Contraseña"></asp:Label>
                    &nbsp;&nbsp;
                    <br />
                    <asp:TextBox ID="TB_correoperfil" runat="server" TextMode="Email" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_contraseniaperfil" runat="server" Enabled="False" ></asp:TextBox>
                    &nbsp;&nbsp;
                    <br />
                    <asp:Label ID="LB_direccion" runat="server" Text="Direccion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Label ID="LB_telefono" runat="server" Text="Telefono"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:TextBox ID="TB_direccionperfil" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_telefonoperfil" runat="server" TextMode="Number" Enabled="False"></asp:TextBox>
                    &nbsp;&nbsp;
                    <br />
                    <asp:Label ID="LB_documento" runat="server" Text="Documento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Label ID="LB_tipodevehiculoperfil" runat="server" Text="Tipo de Vehiculo"></asp:Label>
                    &nbsp;&nbsp;
                    <br />
                    <asp:TextBox ID="TB_documentoperfil" runat="server" TextMode="Number" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_tipodevehiculoperfil" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:Label ID="LB_actividadcomercial" runat="server" Text="Actividad Comercial"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:TextBox ID="TB_actividadcomercialperfil" runat="server" Enabled="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BTN_guardar" runat="server" Text="Guardar" Width="61px" />
&nbsp;<asp:Button ID="BTN_cancelar" runat="server" OnClick="BTN_cancelar_Click" Text="Cancelar" Width="66px" EnableTheming="True" />
                    &nbsp;<asp:Button ID="BTN_editar" runat="server"  CommandName="Editar" CommandArgument='<%# Eval("Id") %>'  Text="Editar" OnClick="BTN_editar_Click" />
&nbsp;
                    <br />
    </p>
</asp:Content>

