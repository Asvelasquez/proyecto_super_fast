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
                <asp:DataList ID="DL_pedido" runat="server" DataSourceID="ODS_carrito7" OnItemCommand="DL_pedido_ItemCommand">
                    <ItemTemplate>
                        <asp:Label ID="LB_nombrealiado" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="LB_producto" runat="server" Text="Producto :" Height="25px"></asp:Label>
                        <asp:TextBox ID="TBX_nombreproducto" runat="server" Text='<%# Eval("nombre_producto") %>' Enabled="False"></asp:TextBox>
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
                        <asp:TextBox ID="TBX_cantidad" runat="server" Text='<%# Eval("cantidad_pedido") %>'></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="REV_Cantidad" runat="server" ControlToValidate="TBX_Cantidad" ErrorMessage="cantidad entre 1 y 9" ForeColor="White" ValidationExpression="\b(?![00]\b)\d{1,1}\b" ValidationGroup="VG_Comprar"></asp:RegularExpressionValidator>
                        <br />
                        <asp:Label ID="LB_preciodomicilio" runat="server" Text="Domicilio :" Height="25px"></asp:Label>
                        &nbsp;<asp:TextBox ID="TBX_domicilio" runat="server" Enabled="False" Height="22px" Width="128px"></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_total" runat="server" Text="Total :" Height="25px"></asp:Label>
                        <asp:TextBox ID="TBX_total" runat="server" Enabled="False"></asp:TextBox>
                        <br />
                        <asp:Label ID="LB_datosclientes" runat="server" Text="Datos del cliente"></asp:Label>
                        <br />
                        <asp:Label ID="LB_nombrecliente" runat="server" Height="25px" Text="Nombre : "></asp:Label>
                        <asp:TextBox ID="TBX_nombrecliente" runat="server" Text='<%# Eval("nombre_clientec") %>' Enabled="False"></asp:TextBox>
                        <br />
                    
                        <asp:Label ID="LB_direccion" runat="server" Height="25px" Text="Direccion :"></asp:Label>
                        <asp:TextBox ID="TBX_direccion" runat="server" Text='<%# Eval("direccion_cliente") %>'></asp:TextBox>
                        <asp:RegularExpressionValidator ID="REV_direccion" runat="server" ControlToValidate="TBX_direccion" ErrorMessage="*" ForeColor="Red" ValidationGroup="VG_Comprar"></asp:RegularExpressionValidator>
                        <br />
                        <asp:Label ID="LB_telefono" runat="server" Text="Telefono :"></asp:Label>
                        <asp:TextBox ID="TBX_telefono" runat="server" Text='<%# Eval("telefono_cliente") %>' TextMode="Number"></asp:TextBox>
                        <br />
                        <strong>
                        <asp:RegularExpressionValidator ID="REV_Telefono" runat="server" ControlToValidate="TB_Telefono" ErrorMessage="debe tener 6 o 10 digitos" ForeColor="White" ValidationExpression="[0-9]{6,10}" ValidationGroup="VG_Comprar"></asp:RegularExpressionValidator>
                        </strong>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BTN_comprar" runat="server" Text="Comprar"  CommandName="Comprar" CommandArgument='<%# Eval("Id_pedido") %>' ValidationGroup="VG_Comprar" />
                        &nbsp;
                        <asp:Button ID="BTN_cancelar" runat="server" Text="Cancelar" CommandName="Eliminar" CommandArgument='<%# Eval("Id_pedido") %>' />
                    </ItemTemplate>
                </asp:DataList>
                <br />
                <br />
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

