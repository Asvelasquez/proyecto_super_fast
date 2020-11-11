<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Carrito.aspx.cs" Inherits="View_Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            text-align: center;
        }
        .auto-style35 {
            text-align: right;
            width: 9px;
        }
        .auto-style36 {
            text-align: left;
        }
        .auto-style37 {
            width: 9px;
        }
        .auto-style38 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_carrito9">
                    <Columns>
                        <asp:BoundField DataField="Id_dpedido" HeaderText="Id_dpedido" SortExpression="Id_dpedido" />
                        <asp:BoundField DataField="Pedido_id" HeaderText="Pedido_id" SortExpression="Pedido_id" />
                        <asp:BoundField DataField="Producto_id" HeaderText="Producto_id" SortExpression="Producto_id" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        <asp:BoundField DataField="V_unitario" HeaderText="V_unitario" SortExpression="V_unitario" />
                        <asp:BoundField DataField="V_total" HeaderText="V_total" SortExpression="V_total" />
                        <asp:BoundField DataField="Direccion_cliente" HeaderText="Direccion_cliente" SortExpression="Direccion_cliente" />
                        <asp:BoundField DataField="Telefono_cliente" HeaderText="Telefono_cliente" SortExpression="Telefono_cliente" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_carrito9" runat="server" SelectMethod="obtenercarrito" TypeName="DAOPedido">
                    <SelectParameters>
                        <asp:Parameter Name="usuariop" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <br />
                <asp:DataList ID="DL_pedido" runat="server" DataSourceID="ODS_carrito9" OnItemCommand="DL_pedido_ItemCommand" RepeatColumns="4">
                    <ItemTemplate>
                        <table class="auto-style33">
                            <tr>
                                <td class="auto-style34" colspan="2">
                                    <asp:Label ID="LB_nombrealiado" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style35">&nbsp;</td>
                                <td class="auto-style36">
                                    <asp:Label ID="LB_producto" runat="server" Height="25px" Text="Producto :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_nombreproducto" runat="server" Enabled="False" Text='<%# Eval("nombre_producto") %>'></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_Descripcionproducto" runat="server" Text="Descripcion del Producto"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_descripcionproducto" runat="server" Enabled="False" Height="40px" Text='<%# Eval("descripcion_producto") %>' Width="170px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_especificacionpedido" runat="server" Text="Especificacion del pedido"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_especificacionpedido" runat="server" Enabled="False" Height="40px" Text='<%# Eval("especificacion_pedido") %>' Width="170px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_subtotal" runat="server" Height="25px" Text="Precio producto :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_subtodal" runat="server" Enabled="False" Text='<%# Eval("precio_pedido") %>' Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_cantidad" runat="server" Height="25px" Text="Cantidad :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_cantidad" runat="server" Text='<%# Eval("cantidad_pedido") %>' Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:RegularExpressionValidator ID="REV_Cantidad" runat="server" ControlToValidate="TBX_Cantidad" ErrorMessage="cantidad entre 1 y 9" ForeColor="White" ValidationExpression="\b(?![00]\b)\d{1,1}\b" ValidationGroup="VG_Comprar"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_preciodomicilio" runat="server" Height="25px" Text="Domicilio :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_domicilio" runat="server" Enabled="False" Height="22px" Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_total" runat="server" Height="25px" Text="Total :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_total" runat="server" Enabled="False" Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_datosclientes" runat="server" Text="Datos del cliente"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_nombrecliente" runat="server" Height="25px" Text="Nombre : "></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_nombrecliente" runat="server" Enabled="False" Text='<%# Eval("nombre_clientec") %>'></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_direccion" runat="server" Height="25px" Text="Direccion :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_direccion" runat="server" Text='<%# Eval("direccion_cliente") %>'></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:Label ID="LB_telefono" runat="server" Text="Telefono :"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TBX_telefono" runat="server" Text='<%# Eval("telefono_cliente") %>' TextMode="Number"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style37">&nbsp;</td>
                                <td><strong>
                                    <asp:RegularExpressionValidator ID="REV_Telefono" runat="server" ControlToValidate="TBX_telefono" ErrorMessage="debe tener 6 o 10 digitos" ForeColor="White" ValidationExpression="[0-9]{6,10}" ValidationGroup="VG_Comprar"></asp:RegularExpressionValidator>
                                    </strong></td>
                            </tr>
                        </table>
                        <table class="auto-style33">
                            <tr>
                                <td>
                                    <asp:Button ID="BTN_comprar" runat="server" CommandArgument='<%# Eval("Id_pedido") %>' CommandName="Comprar" Text="Comprar" ValidationGroup="VG_Comprar" />
                                </td>
                                <td class="auto-style38">
                                    <asp:Button ID="BTN_cancelar" runat="server" CommandArgument='<%# Eval("Id_pedido") %>' CommandName="Eliminar" Text="Cancelar" />
                                </td>
                            </tr>
                        </table>
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

