﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/pedidosaliado.aspx.cs" Inherits="View_pedidosaliado" %>

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
                <br />
                <br />
                <asp:Label ID="LB_Pedidos" runat="server" Font-Size="Large" ForeColor="White" Text="Pedido(s)"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="GV_pedidos" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Pedido"  OnRowDataBound="GV_pedidos_RowDataBound" OnRowCommand="GV_pedidos_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Pedido N°" SortExpression="Id_pedido">
                            <EditItemTemplate>
                                <asp:TextBox ID="TBX_L_Pedido" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="L_Pedido" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        <asp:BoundField DataField="Valor_total" HeaderText="Valor_total" SortExpression="Valor_total" />
                        <asp:BoundField DataField="Comentario_cliente" HeaderText="Comentario_cliente" SortExpression="Comentario_cliente" />
                        <asp:TemplateField HeaderText="Comentario_aliado" SortExpression="Comentario_aliado">
                            <EditItemTemplate>
                                <asp:TextBox ID="TBX_LB_comentarioadliado" runat="server" Text='<%# Bind("Comentario_aliado") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="LB_comentarioadliado" runat="server" Text='<%# Bind("Comentario_aliado") %>'></asp:Label>
                                <br />
                                <asp:TextBox ID="TBX_comentarioaliado" runat="server" Height="32px" Width="137px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="IB_guardarcomentario" runat="server" ImageUrl="~/Imagenes/Iconos/guardar.png" CommandName="Guardar" CommandArgument='<%# Eval("Id_pedido") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Pedido" SortExpression="Compras">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Compras") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:GridView ID="GV_Compras" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                    
                                    <asp:BoundField DataField="Nombreprodet" HeaderText="Producto" SortExpression="Nombreprodet" />
                                    <asp:BoundField DataField="Especprodaliado" HeaderText="Descripcion" SortExpression="Especprodaliado" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" /> 
                                    <asp:BoundField DataField="Descripcion" HeaderText="Especificacion" SortExpression="Descripcion" />
                                     

                                    </Columns>
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Nombre_estado_ped" HeaderText="Estado pedido" SortExpression="Nombre_estado_ped" />
                        <asp:TemplateField HeaderText="Cambiar estado">
                            <ItemTemplate>
                                <asp:DropDownList ID="DDL_Categoria" runat="server" DataSourceID="ODS_categorias" DataTextField="Nombre" DataValueField="Id" OnSelectedIndexChanged="DDL_Categoria_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="ODS_categorias" runat="server" SelectMethod="estado_Pedidos" TypeName="DAOProductos"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Pedido" runat="server" SelectMethod="obtenerEstadoPedido" TypeName="DAOPedido"></asp:ObjectDataSource>
                <asp:ImageButton ID="IB_recargar0" runat="server" ImageUrl="~/Imagenes/Iconos/refrescar.png" OnClick="IB_recargar1_Click" />
                <br />
                <asp:Label ID="Label10" runat="server" Font-Size="Large" ForeColor="White" Text="Pedido(s) Terminados"></asp:Label>
                <br />
                <br />

                <asp:GridView ID="GV_pedidosterminado" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Pedidoterminado"  OnRowDataBound="GV_pedidosterminado_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="Pedido N°" SortExpression="Id_pedido">
                            <EditItemTemplate>
                                <asp:TextBox ID="TBX_L_Pedido1" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="L_Pedido1" runat="server" Text='<%# Bind("Id_pedido") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        <asp:BoundField DataField="Valor_total" HeaderText="Valor_total" SortExpression="Valor_total" />
                        <asp:BoundField DataField="Comentario_cliente" HeaderText="Comentario_cliente" SortExpression="Comentario_cliente" />
                        <asp:BoundField DataField="Comentario_aliado" HeaderText="Comentario_aliado" SortExpression="Comentario_aliado" />
                        <asp:TemplateField HeaderText="Pedido" SortExpression="Compras">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Compras") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:GridView ID="GV_Compras1" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                    
                                    <asp:BoundField DataField="Nombreprodet" HeaderText="Producto" SortExpression="Nombreprodet" />
                                    <asp:BoundField DataField="Especprodaliado" HeaderText="Descripcion" SortExpression="Especprodaliado" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" /> 
                                    <asp:BoundField DataField="Descripcion" HeaderText="Especificacion" SortExpression="Descripcion" />
                                     

                                    </Columns>
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Nombre_estado_ped" HeaderText="Estado pedido" SortExpression="Nombre_estado_ped" />
                        <asp:TemplateField HeaderText="Cambiar estado">
                            <ItemTemplate>
                                <asp:DropDownList ID="DDL_Categoria1" runat="server" DataSourceID="ODS_categorias0" DataTextField="Nombre" DataValueField="Id" OnSelectedIndexChanged="DDL_Categoria_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="ODS_categorias0" runat="server" SelectMethod="estado_Pedidos" TypeName="DAOProductos"></asp:ObjectDataSource>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Pedidoterminado" runat="server" SelectMethod="obtenerEstadoPedidoterminado" TypeName="DAOPedido"></asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

