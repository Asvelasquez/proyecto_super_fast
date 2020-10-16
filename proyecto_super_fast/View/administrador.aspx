<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/administrador.aspx.cs" Inherits="View_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODSUsuario">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="NIT" SortExpression="Documento" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Actividadcomercial" HeaderText="Actividad comercial" SortExpression="Actividadcomercial" />
                <asp:BoundField DataField="Imagenperfil" HeaderText="Logo" SortExpression="Imagenperfil" />
                <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSUsuario" runat="server" SelectMethod="mostraraliado" TypeName="DAOUsuario"></asp:ObjectDataSource>
        asas<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODSDom">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                <asp:BoundField DataField="Imagenperfil" HeaderText="Imagenperfil" SortExpression="Imagenperfil" />
                <asp:BoundField DataField="Hojavida" HeaderText="Hojavida" SortExpression="Hojavida" />
                <asp:BoundField DataField="Tipovehiculo" HeaderText="Tipovehiculo" SortExpression="Tipovehiculo" />
                <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
                <asp:CommandField ShowEditButton="True" />
                <asp:ButtonField Text="Botón" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSDom" runat="server" SelectMethod="mostrardomiciliario" TypeName="DAOUsuario"></asp:ObjectDataSource>
    </p>
</asp:Content>

