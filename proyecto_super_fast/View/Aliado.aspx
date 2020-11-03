﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Aliado.aspx.cs" Inherits="View_Aliado" %>

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
&nbsp;<asp:TextBox ID="TB_nombreproducto" runat="server" BorderColor="Black" Height="20px" Width="180px" ValidationGroup="VG_cargarproducto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="TB_nombreproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
    <strong>
            <asp:RegularExpressionValidator ID="REV_Nombre" runat="server" ControlToValidate="TB_nombreproducto" ErrorMessage="por favor revise el nombre" ValidationExpression="^[a-zA-Z0-9\s]+$" ValidationGroup="VG_cargarproducto" ForeColor="White"></asp:RegularExpressionValidator>
            </strong>
                <br />
&nbsp;<asp:Label ID="LB_descripcionproducto" runat="server" Text="Descripcion del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_descripcionproducto" runat="server" BorderColor="Black" Height="20px" Width="180px" ValidationGroup="VG_cargarproducto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Descripcion" runat="server" ControlToValidate="TB_descripcionproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
    <strong>
            <asp:RegularExpressionValidator ID="REV_Descripcion" runat="server" ControlToValidate="TB_descripcionproducto" ErrorMessage="por favor revise la descripcion" ValidationExpression="^[a-zA-Z0-9\s]+$" ValidationGroup="VG_cargarproducto" ForeColor="White"></asp:RegularExpressionValidator>
            </strong>
                <br />
&nbsp;<asp:Label ID="LB_precioproducto" runat="server" Text="Precio del producto"></asp:Label>
                <br />
&nbsp;<asp:TextBox ID="TB_precioproducto" runat="server" TextMode="Number" BorderColor="Black" Height="20px" Width="180px" ValidationGroup="VG_cargarproducto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Precio" runat="server" ControlToValidate="TB_precioproducto" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
                <br />
    <strong>
            <asp:RegularExpressionValidator ID="REV_Precio" runat="server" ControlToValidate="TB_precioproducto" ErrorMessage="por favor revise el precio" ValidationExpression="^\d*[1-9]\d*$" ValidationGroup="VG_cargarproducto" ForeColor="White"></asp:RegularExpressionValidator>
            </strong>
                <br />
&nbsp;<asp:Label ID="LB_imagenproducto1" runat="server" Text="Cargar imagen del producto #1"></asp:Label>
                <br />
&nbsp;<asp:FileUpload ID="FP_imagen1" runat="server" Width="276px" />
                <asp:RequiredFieldValidator ID="RFV_CargarProducto" runat="server" ControlToValidate="FP_imagen1" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_cargarproducto"></asp:RequiredFieldValidator>
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
                        <asp:TemplateField HeaderText="Imagen producto">
                            <ItemTemplate>
                                <asp:Image ID="Image_producto" runat="server" Height="50px" Width="50px" ImageUrl='<%# Eval("Imagen_producto1") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_producto1" runat="server" SelectMethod="mostrarproducto" TypeName="DAOProductos" DataObjectTypeName="Producto" UpdateMethod="updateproducto">
                    <SelectParameters>
                        <asp:SessionParameter Name="consulta" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:Label ID="Label10" runat="server" Font-Size="Large" Text="Solicitud de pedidos"></asp:Label>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Imagenes/Iconos/refrescar.png" OnClick="ImageButton1_Click" Width="35px" />
                <br />
                <asp:GridView ID="GV_pedidosaliado" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_pedidoaliado">
                    <Columns>
                        <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
                        <asp:BoundField DataField="Especificacion_pedido" HeaderText="Especificacion_pedido" SortExpression="Especificacion_pedido" />
                        <asp:BoundField DataField="Descripcion_producto" HeaderText="Descripcion_producto" SortExpression="Descripcion_producto" />
                        <asp:BoundField DataField="Precio_pedido" HeaderText="Precio_pedido" SortExpression="Precio_pedido" />
                        <asp:BoundField DataField="Cantidad_pedido" HeaderText="Cantidad_pedido" SortExpression="Cantidad_pedido" />
                        <asp:BoundField DataField="Nombre_clientec" HeaderText="Nombre_clientec" SortExpression="Nombre_clientec" />
                        <asp:BoundField DataField="Telefono_cliente" HeaderText="Telefono_cliente" SortExpression="Telefono_cliente" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_pedidoaliado" runat="server" SelectMethod="mostrarproducto" TypeName="DAOPedido">
                    <SelectParameters>
                        <asp:SessionParameter Name="consulta" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
            </td>
        </tr>
        </table>
</asp:Content>

