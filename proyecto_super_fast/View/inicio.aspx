<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/inicio.aspx.cs" Inherits="View_inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style10 {
        height: 50%;
        vertical-align:top;
    }
        .auto-style11 {
            height: 2%;
            vertical-align: top;
        }
        .auto-style12 {
            height: 1%;
            vertical-align: top;
            width: 50%;
        }
        .auto-style13 {
            height: 1%;
            font-size: medium;
        }
        .auto-style14 {
            height: 1%;
            vertical-align: top;
            width: 50%;
        }
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            text-align: center;
        }
        .auto-style37 {
            text-align: center;
            height: 83px;
        }
        .auto-style38 {
            height: 1%;
            vertical-align: top;
        }
        .auto-style39 {
            width: 50%;
            text-align: right;
        }
        .auto-style40 {
            font-size: large;
        }
        .auto-style41 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style11" colspan="2">
            <asp:Menu ID="Menu_principal" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px" Width="100%" StaticDisplayLevels="5">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#B5C7DE" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem Text="Todo" Value="Inicio"></asp:MenuItem>
                    <asp:MenuItem Text="Restaurantes" Value="Restaurantes"></asp:MenuItem>
                    <asp:MenuItem Text="Supermercados" Value="Supermercados"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
            <br />
        </td>
    </tr>
    <tr>

        <td class="auto-style14">
            <h1 class="auto-style13">Filtros</h1>
        </td>
        <td class="auto-style11"></td>
    </tr>
    <tr>
        <td class="auto-style12">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style38" colspan="2">
            <asp:DataList ID="DL_Productos" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" DataSourceID="ODS_inicioproductos">
                <ItemTemplate>
                    <table class="auto-style33">
                        <tr>
                            <td class="auto-style37" colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <strong>
                                <asp:TextBox ID="TBX_nombrealiado" runat="server" CssClass="auto-style40" Enabled="False" Text='<%# Eval("nombre_aliado") %>'></asp:TextBox>
                                </strong>&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Image ID="I_Productos" runat="server" Height="200px" Width="200px" ImageUrl='<%# Eval("imagen_producto1") %>' />
                                <br />
                                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TBX_nombreproducto" runat="server" CssClass="auto-style40" Enabled="False" Text='<%# Eval("Nombre_producto") %>' Width="160px"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                                <asp:Label ID="LB_Precio" runat="server">Precio</asp:Label>
                                &nbsp;<asp:TextBox ID="TBX_precio" runat="server" Text='<%# Eval("precio_producto") %>' Enabled="False" Height="20px" Width="160px"></asp:TextBox>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="LB_Descripcion" runat="server" Height="35px">Descripcion</asp:Label>
                                <asp:TextBox ID="TB_descripcion" runat="server" Enabled="False" Height="41px" Text='<%# Eval("descripcion_producto") %>' Width="160px"></asp:TextBox>
                                <asp:ImageButton ID="IB_Carrito" runat="server" CommandArgument="id" ImageUrl="~/Imagenes/Iconos/anadir-al-carrito.png" />
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style34">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <h1><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></h1>
                            </td>
                            <td class="auto-style41">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style39">&nbsp;&nbsp;
                                </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style39">&nbsp;&nbsp; &nbsp;&nbsp;
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style34"><%--CommandArgument='<%# Eval("Id") %>'--%>
                            </td>
                            <td class="auto-style41">&nbsp;</td>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="ODS_inicioproductos" runat="server" SelectMethod="mostrarproductoinicio" TypeName="DAOProductos"></asp:ObjectDataSource>
            <br />
        </td>
    </tr>
</table>
</asp:Content>

