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
                        <asp:TemplateField HeaderText="Pedido n°" SortExpression="Id_pedido">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="L_Pedido" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        <asp:BoundField DataField="Comentario_cliente" HeaderText="Comentario_cliente" SortExpression="Comentario_cliente" />
                        <asp:BoundField DataField="Comentario_aliado" HeaderText="Comentario_aliado" SortExpression="Comentario_aliado" />
                        <asp:BoundField DataField="Nombre_estado_ped" HeaderText="Estado pedido" SortExpression="Nombre_estado_ped" />
                        <asp:TemplateField HeaderText="Pedido">
                            <ItemTemplate>
                                <asp:GridView ID="GV_detallespedido" runat="server" AutoGenerateColumns="False">
                                     <Columns>
                                    <asp:BoundField DataField="Pedido_id" HeaderText="Pedido N°" SortExpression="Pedido_id" />
                                    <asp:BoundField DataField="Nombreprodet" HeaderText="Producto" SortExpression="Nombreprodet" />
                                    <asp:BoundField DataField="Especprodaliado" HeaderText="Descripcion" SortExpression="Especprodaliado" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" /> 
                                    <asp:BoundField DataField="Descripcion" HeaderText="Especificacion" SortExpression="Descripcion" />
                                    <asp:BoundField DataField="V_unitario" HeaderText="Valor unitario" SortExpression="V_unitario" />
                                    
                                  </Columns>   
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cambiar Estado">
                            <ItemTemplate>
                                <asp:DropDownList ID="DDL_Estado" runat="server" DataSourceID="ODS_EstadoDomicilio" DataTextField="Nombre" DataValueField="Id" OnSelectedIndexChanged="DDL_Estado_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="ODS_EstadoDomicilio" runat="server" SelectMethod="estado_Domicilios" TypeName="DAOProductos"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado domicilio">
                            <ItemTemplate>
                                <asp:GridView ID="GV_estadodomicilio" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                     
                                    <asp:BoundField DataField="Nombre_estado_domicilio" HeaderText="Estadodomicilio" SortExpression="Nombre_estado_domicilio" />
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

