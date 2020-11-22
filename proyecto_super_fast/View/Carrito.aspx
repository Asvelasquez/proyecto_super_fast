﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Carrito.aspx.cs" Inherits="View_Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            width: 535px;
        }
        .auto-style35 {
            width: 535px;
            height: 58px;
        }
        .auto-style36 {
            height: 58px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td>
                <asp:GridView ID="GV_pedidocarrito" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_carrito9" OnRowDataBound="GV_pedidocarrito_RowDataBound" OnRowCommand="GV_pedidocarrito_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="Id_pedido" HeaderText="Pedido N°" SortExpression="Id_pedido" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        <asp:BoundField DataField="Comentario_cliente" HeaderText="Comentario_cliente" SortExpression="Comentario_cliente" />
                        <asp:BoundField DataField="Comentario_aliado" HeaderText="Comentario_aliado" SortExpression="Comentario_aliado" />
                        <asp:BoundField DataField="Nombre_estado_ped" HeaderText="Estado del pedido" SortExpression="Nombre_estado_ped" />
                        <asp:TemplateField HeaderText="Detalles del Pedido">
                            <ItemTemplate>
                                <asp:GridView ID="GV_detallespedido" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="Nombreprodet" HeaderText="Producto" SortExpression="Nombreprodet" />
                                    <asp:BoundField DataField="Especprodaliado" HeaderText="Descripcion" SortExpression="Especprodaliado" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" /> 
                                    <asp:BoundField DataField="Descripcion" HeaderText="Especificacion" SortExpression="Descripcion" />
                                    <asp:BoundField DataField="V_unitario" HeaderText="Valor unitario" SortExpression="V_unitario" />
                                    <asp:BoundField DataField="V_total" HeaderText="Valor Total" SortExpression="V_total" />
                                  </Columns>   
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Calcelar pedido">
                            <ItemTemplate>
                                <asp:Button ID="BTN_cancelar" runat="server" Text="Cancelar" CommandName="Cancelar" CommandArgument='<%# Eval("Id_pedido") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_carrito9" runat="server" SelectMethod="obtenerPedidoUsuario" TypeName="DAOPedido">
                    <SelectParameters>
                        <asp:SessionParameter Name="usuariopedido" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <table class="auto-style33">
                    <tr>
                        <td class="auto-style34">
                            <asp:Label ID="LB_telefono" runat="server" Text="Telefono"></asp:Label>
                        </td>
                        <td class="auto-style34">
                            <asp:Label ID="LB_direccion" runat="server" Text="Direccion"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="LB_total" runat="server" Text="Total"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style35">
                            <asp:TextBox ID="TBX_telefono" runat="server" Height="25px" TextMode="Number" Width="150px"></asp:TextBox>
                            <strong>
                            <br />
            <asp:RegularExpressionValidator ID="REV_Telefono" runat="server" ControlToValidate="TBX_telefono" ErrorMessage="el telefono no contiene entre 7 y  10 digitos" ValidationExpression="[0-9]{6,10}" ValidationGroup="VG_Comprar" ForeColor="White"></asp:RegularExpressionValidator>
            </strong></td>
                        <td class="auto-style35">
                            <asp:TextBox ID="TBX_direccion" runat="server" Height="25px" Width="150px"></asp:TextBox>
                            <strong>
                            <br />
            <asp:RegularExpressionValidator ID="REV_Direccion" runat="server" ControlToValidate="TBX_direccion" ErrorMessage="por favor revise la direccion" ValidationExpression="^[#.0-9a-zA-Z\s,-]+$" ValidationGroup="VG_Comprar" ForeColor="White"></asp:RegularExpressionValidator>
            </strong></td>
                        <td class="auto-style36">
                            <asp:TextBox ID="TBX_total" runat="server" Height="22px" Width="129px"></asp:TextBox>
&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style34">&nbsp;</td>
                        <td class="auto-style34">&nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_comprar" runat="server" Text="Compar" ValidationGroup="VG_Comprar" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style34">&nbsp;</td>
                        <td class="auto-style34"> <strong>
                            <br />
            </strong></td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:DataList ID="DL_pedido" runat="server" DataSourceID="ODS_carrito9" OnItemCommand="DL_pedido_ItemCommand" RepeatColumns="4">
                    <ItemTemplate>
                        Id_pedido:
                        <asp:Label ID="Id_pedidoLabel" runat="server" Text='<%# Eval("Id_pedido") %>' />
                        <br />
                        Cliente_id:
                        <asp:Label ID="Cliente_idLabel" runat="server" Text='<%# Eval("Cliente_id") %>' />
                        <br />
                        Fecha:
                        <asp:Label ID="FechaLabel" runat="server" Text='<%# Eval("Fecha") %>' />
                        <br />
                        Estado_id:
                        <asp:Label ID="Estado_idLabel" runat="server" Text='<%# Eval("Estado_id") %>' />
                        <br />
                        Valor_total:
                        <asp:Label ID="Valor_totalLabel" runat="server" Text='<%# Eval("Valor_total") %>' />
                        <br />
                        Domiciliario_id:
                        <asp:Label ID="Domiciliario_idLabel" runat="server" Text='<%# Eval("Domiciliario_id") %>' />
                        <br />
                        Comentario_cliente:
                        <asp:Label ID="Comentario_clienteLabel" runat="server" Text='<%# Eval("Comentario_cliente") %>' />
                        <br />
                        Comentario_aliado:
                        <asp:Label ID="Comentario_aliadoLabel" runat="server" Text='<%# Eval("Comentario_aliado") %>' />
                        <br />
                        Aliado_id:
                        <asp:Label ID="Aliado_idLabel" runat="server" Text='<%# Eval("Aliado_id") %>' />
                        <br />
                        Estado_pedido:
                        <asp:Label ID="Estado_pedidoLabel" runat="server" Text='<%# Eval("Estado_pedido") %>' />
                        <br />
                        Compras:
                        <asp:Label ID="ComprasLabel" runat="server" Text='<%# Eval("Compras") %>' />
                        <br />
                        Detnombrecliente:
                        <asp:Label ID="DetnombreclienteLabel" runat="server" Text='<%# Eval("Detnombrecliente") %>' />
                        <br />
                        Nombre_estado_ped:
                        <asp:Label ID="Nombre_estado_pedLabel" runat="server" Text='<%# Eval("Nombre_estado_ped") %>' />
                        <br />
                        <br />
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

