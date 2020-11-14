<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/pedidosaliado.aspx.cs" Inherits="View_pedidosaliado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td class="auto-style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:Button ID="BT_Productos" runat="server" BackColor="#3399FF" Height="30px" PostBackUrl="~/View/Aliado.aspx" Text="Productos" Width="95px" />

                </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="IB_recargar" runat="server" ImageUrl="~/Imagenes/Iconos/refrescar.png" OnClick="IB_recargar_Click" />
                <asp:GridView ID="GV_pedidos" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Pedido"  OnRowDataBound="GV_pedidos_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="Pedido_id" HeaderText="Pedido n°" SortExpression="Pedido_id" />
                        <asp:BoundField DataField="Nombreprodet" HeaderText="Nombre producto" SortExpression="Nombreprodet" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion producto" SortExpression="Descripcion" />
                        <asp:BoundField DataField="Especprodaliado" HeaderText="especificacion pedido" SortExpression="Especprodaliado" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                        <asp:BoundField DataField="V_unitario" HeaderText="V_unitario" SortExpression="V_unitario" />
                        <asp:BoundField DataField="V_total" HeaderText="V_total" SortExpression="V_total" />
                        <asp:TemplateField HeaderText="estado del pedido">
                            <ItemTemplate>
                                <asp:DropDownList ID="DDL_Categoria" runat="server" DataSourceID="ODS_Categorias" DataTextField="Nombre" DataValueField="Id">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="ODS_Categorias" runat="server" SelectMethod="estado_Pedidos" TypeName="DAOProductos"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Pedido" runat="server" SelectMethod="mostrarpedidoaliado" TypeName="DAOPedido"></asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

