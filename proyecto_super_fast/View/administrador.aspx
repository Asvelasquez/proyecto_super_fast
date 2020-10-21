<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/administrador.aspx.cs" Inherits="View_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;
        <asp:Label ID="Label11" runat="server" Font-Size="Large" Height="25px" Text="Solicitudes de aliados"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODSaliado" OnRowCommand="GridView1_RowCommand">
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
                <asp:TemplateField HeaderText="Aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_aceptaraliado" runat="server" CommandName="Aceptar" CommandArgument='<%# Eval("Id") %>' Text="Aceptar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rechazar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_rechazaraliado" runat="server" CommandName="Rechazar" CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSaliado" runat="server" SelectMethod="mostrarsolicitudaliado" TypeName="DAOUsuario"></asp:ObjectDataSource>
        <asp:Label ID="Label10" runat="server" Font-Size="Large" Height="25px" Text="Solicitudes de domiciliarios"></asp:Label>
       
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODSDom" OnRowCommand="GridView2_RowCommand">
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
                <asp:TemplateField HeaderText="aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_aceptardomiciliario" runat="server"  CommandName="Aceptar" CommandArgument='<%# Eval("Id") %>' Text="Aceptar"    />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rechazar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_rechazardomiciliario" runat="server" CommandName="Rechazar"  CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSDom" runat="server" SelectMethod="mostrarsolicituddomiciliario" TypeName="DAOUsuario"></asp:ObjectDataSource>
    </p>
</asp:Content>

