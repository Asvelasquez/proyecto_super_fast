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
&nbsp;<asp:TextBox ID="TB_nombreproducto" runat="server" BorderColor="Black" Height="20px" Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_nombreproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
&nbsp;<asp:Label ID="LB_descripcionproducto" runat="server" Text="Descripcion del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_descripcionproducto" runat="server" BorderColor="Black" Height="20px" Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_descripcionproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
&nbsp;<asp:Label ID="LB_precioproducto" runat="server" Text="Precio del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_precioproducto" runat="server" TextMode="Number" BorderColor="Black" Height="20px" Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_precioproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
&nbsp;<asp:Label ID="LB_imagenproducto1" runat="server" Text="Cargar imagen del producto #1"></asp:Label>
                <br />
&nbsp;<asp:FileUpload ID="FP_imagen1" runat="server" Width="276px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FP_imagen1" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
&nbsp;<br />
&nbsp;<br />
&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BTN_guardarproducto" runat="server" OnClick="BTN_guardarproducto_Click" Text="Guardar" ValidationGroup="VG_cargarproducto" BorderColor="Black" Height="30px" Width="110px" />
                <br />
            </td>
            <td>
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_producto1">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                        <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
                        <asp:BoundField DataField="Descripcion_producto" HeaderText="Descripcion_producto" SortExpression="Descripcion_producto" />
                        <asp:BoundField DataField="Precio_producto" HeaderText="Precio_producto" SortExpression="Precio_producto" />
                        <asp:BoundField DataField="Estado_producto" HeaderText="Estado_producto" SortExpression="Estado_producto" />
                        <asp:TemplateField HeaderText="Imagen producto">
                            <ItemTemplate>
                                <asp:Image ID="Image_producto" runat="server" Height="50px" Width="50px" ImageUrl='<%# Eval("Imagenperfil") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_producto1" runat="server" SelectMethod="mostrarproducto" TypeName="DAOProductos">
                    <SelectParameters>
                        <asp:SessionParameter Name="consulta" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_pruebahojadevida" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                        <asp:BoundField DataField="Imagenperfil" HeaderText="Imagenperfil" SortExpression="Imagenperfil" />
                        <asp:BoundField DataField="Hojavida" HeaderText="Hojavida" SortExpression="Hojavida" />
                        <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
                        <asp:BoundField DataField="Auditoria" HeaderText="Auditoria" SortExpression="Auditoria" />
                        <asp:TemplateField HeaderText="hojavida">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink4" NavigateUrl='<%# Eval("hojavida") %>' Target="_blank" runat="server">Hoja de vida</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_pruebahojadevida" runat="server" SelectMethod="mostrarsolicituddomiciliario" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
                <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Hojas_de_vida/carnet.pdf" runat="server">HyperLink</asp:HyperLink>
                <br />
            </td>
        </tr>
        </table>
</asp:Content>

