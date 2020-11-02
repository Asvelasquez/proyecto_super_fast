<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Carrito.aspx.cs" Inherits="View_Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_carrito7">
                    <Columns>
                        <asp:BoundField DataField="Id_pedido" HeaderText="Id_pedido" SortExpression="Id_pedido" />
                        <asp:BoundField DataField="Id_producto" HeaderText="Id_producto" SortExpression="Id_producto" />
                        <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
                        <asp:BoundField DataField="Especificacion_pedido" HeaderText="Especificacion_pedido" SortExpression="Especificacion_pedido" />
                        <asp:BoundField DataField="Descripcion_producto" HeaderText="Descripcion_producto" SortExpression="Descripcion_producto" />
                        <asp:BoundField DataField="Precio_pedido" HeaderText="Precio_pedido" SortExpression="Precio_pedido" />
                        <asp:BoundField DataField="Cantidad_pedido" HeaderText="Cantidad_pedido" SortExpression="Cantidad_pedido" />
                        <asp:BoundField DataField="Estado_pedido" HeaderText="Estado_pedido" SortExpression="Estado_pedido" />
                        <asp:BoundField DataField="Correo_cliente" HeaderText="Correo_cliente" SortExpression="Correo_cliente" />
                        <asp:BoundField DataField="Nombre_clientec" HeaderText="Nombre_clientec" SortExpression="Nombre_clientec" />
                        <asp:BoundField DataField="Direccion_cliente" HeaderText="Direccion_cliente" SortExpression="Direccion_cliente" />
                        <asp:BoundField DataField="Telefono_cliente" HeaderText="Telefono_cliente" SortExpression="Telefono_cliente" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_carrito7" runat="server" SelectMethod="mostrarpedidocarrito" TypeName="DAOPedido">
                    <SelectParameters>
                        <asp:SessionParameter Name="busqueda" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <br />
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ODS_carrito7">
                    <ItemTemplate>
                        <asp:Label ID="LB_producto" runat="server" Text="Producto :" Height="25px"></asp:Label>
                        <asp:TextBox ID="TBX_nombreproducto" runat="server" Text='<%# Eval("nombre_producto") %>'></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_Descripcionproducto" runat="server" Text="Descripcion del Producto"></asp:Label>
                        <br />
                        <asp:TextBox ID="TBX_descripcionproducto" runat="server" Enabled="False" Height="40px" Width="170px" Text='<%# Eval("descripcion_producto") %>'></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_especificacionpedido" runat="server" Text="Especificacion del pedido"></asp:Label>
                        <br />
                        <asp:TextBox ID="TBX_especificacionpedido" runat="server" Enabled="False" Height="40px" Width="170px" Text='<%# Eval("especificacion_pedido") %>'></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_subtotal" runat="server" Height="25px" Text="Precio producto :"></asp:Label>
                        <asp:TextBox ID="TBX_subtodal" runat="server" Enabled="False" Width="100px" Text='<%# Eval("precio_pedido") %>'></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_cantidad" runat="server" Height="25px" Text="Cantidad :"></asp:Label>
                        <asp:TextBox ID="TBX_cantidad" runat="server" Enabled="False" Text='<%# Eval("cantidad_pedido") %>'></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_preciodomicilio" runat="server" Text="Domicilio :" Height="25px"></asp:Label>
                        &nbsp;<asp:TextBox ID="TBX_domicilio" runat="server" Enabled="False" Height="22px" Width="128px"></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_total" runat="server" Text="Total :" Height="25px"></asp:Label>
                        <asp:TextBox ID="TBX_total" runat="server" Enabled="False"></asp:TextBox>
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
                        <asp:Label ID="Label10" runat="server" Text="Total"></asp:Label>
                <br />
                <asp:TextBox ID="TBX_total2" runat="server"></asp:TextBox>
                <br />
                        <asp:Label ID="LB_datoscliente" runat="server" Text="Datos del cliente"></asp:Label>
                        <br  />
                        <asp:Label ID="LB_nombrecliente" runat="server" Height="25px" Text="Nombre :"></asp:Label>
                        &nbsp;<asp:TextBox ID="TBX_nombrecliente" runat="server" ></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_direccion" runat="server" Height="25px" Text="Direccion :"></asp:Label>
                        &nbsp;<asp:TextBox ID="TBX_direccioncliente" runat="server" ></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_telefono" runat="server" Height="25px" Text="Telefono :"></asp:Label>
                        &nbsp;<asp:TextBox ID="TBX_telefonocliente" runat="server" ></asp:TextBox>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

