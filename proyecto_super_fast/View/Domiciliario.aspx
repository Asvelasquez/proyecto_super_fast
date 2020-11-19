<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Domiciliario.aspx.cs" Inherits="View_Domiciliario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td class="auto-style34" colspan="2">
                <asp:GridView ID="GV_PedDomi" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Domiciliario" OnRowDataBound="GV_PedDomi_RowDataBound">
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
                        <asp:BoundField DataField="Nombre_estado_ped" HeaderText="Nombre_estado_ped" SortExpression="Nombre_estado_ped" />
                        <asp:TemplateField HeaderText="Datos">
                            <ItemTemplate>
                                <asp:GridView ID="GV_detallespedido" runat="server" AutoGenerateColumns="False">
                                     <Columns>
                                    <asp:BoundField DataField="Nombreprodet" HeaderText="Producto" SortExpression="Nombreprodet" />
                                    <asp:BoundField DataField="Especprodaliado" HeaderText="Descripcion" SortExpression="Especprodaliado" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" /> 
                                    <asp:BoundField DataField="Descripcion" HeaderText="Especificacion" SortExpression="Descripcion" />
                                    <asp:BoundField DataField="V_unitario" HeaderText="Valor unitario" SortExpression="V_unitario" />
                                    
                                  </Columns>   
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Domiciliario" runat="server" SelectMethod="obtenerPedidoDomiciliario" TypeName="DAOPedido"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

