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
                        <asp:BoundField DataField="Id_pedido" HeaderText="Id_pedido" SortExpression="Id_pedido" />
                        <asp:BoundField DataField="Cliente_id" HeaderText="Cliente_id" SortExpression="Cliente_id" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        <asp:BoundField DataField="Estado_id" HeaderText="Estado_id" SortExpression="Estado_id" />
                        <asp:BoundField DataField="Valor_total" HeaderText="Valor_total" SortExpression="Valor_total" />
                        <asp:BoundField DataField="Domiciliario_id" HeaderText="Domiciliario_id" SortExpression="Domiciliario_id" />
                        <asp:BoundField DataField="Comentario_cliente" HeaderText="Comentario_cliente" SortExpression="Comentario_cliente" />
                        <asp:BoundField DataField="Comentario_aliado" HeaderText="Comentario_aliado" SortExpression="Comentario_aliado" />
                        <asp:BoundField DataField="Aliado_id" HeaderText="Aliado_id" SortExpression="Aliado_id" />
                        <asp:BoundField DataField="Estado_pedido" HeaderText="Estado_pedido" SortExpression="Estado_pedido" />
                        <asp:BoundField DataField="Detnombrecliente" HeaderText="Detnombrecliente" SortExpression="Detnombrecliente" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_carrito9" runat="server" SelectMethod="obtenerFactura" TypeName="DAOPedido">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="" Name="usuariopedido" SessionField="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
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

