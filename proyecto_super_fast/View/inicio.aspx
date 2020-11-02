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
        .auto-style42 {
            height: 131px;
            vertical-align: top;
            width: 12%;
            text-align: center;
        }
        .auto-style43 {
            text-align: right;
        }
        .auto-style46 {
            width: 50%;
            text-align: right;
            height: 9px;
        }
        .auto-style47 {
            height: 9px;
        }
        .auto-style48 {
            text-align: left;
            height: 83px;
        }
        .auto-style49 {
            text-align: center;
            height: 26px;
        }
        .auto-style50 {
            text-align: left;
            height: 26px;
        }
        .auto-style51 {
            text-align: center;
            height: 31px;
        }
        .auto-style52 {
            text-align: left;
            height: 31px;
        }
        .auto-style53 {
            text-align: center;
            height: 11px;
        }
        .auto-style54 {
            text-align: left;
            height: 11px;
        }
        .auto-style55 {
            text-align: right;
            height: 20px;
        }
        .auto-style56 {
            text-align: left;
            height: 20px;
        }
        .auto-style59 {
            text-align: right;
            height: 14px;
        }
        .auto-style60 {
            text-align: left;
            height: 14px;
        }
        .auto-style61 {
            font-size: large;
            font-weight: bold;
        }
        .auto-style63 {
            font-weight: bold;
        }
        .auto-style64 {
            height: 131px;
            vertical-align: top;
            width: 12%;
            text-align: right;
        }
        .auto-style65 {
            text-align: right;
            height: 19px;
        }
        .auto-style66 {
            text-align: left;
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style11">
            <h1 class="auto-style34">
                <asp:Button ID="BTN_Todos" runat="server" CssClass="auto-style40" Text="Todo" />
            </h1>
        </td>
        <td class="auto-style42" colspan="2">
            <h1>
                <asp:Button ID="BTN_Restaurantes" runat="server" CssClass="auto-style40" Text="Restaurantes" />
            </h1>
        </td>
        <td class="auto-style42">
            <h1>
                <asp:Button ID="BTN_Supermecados" runat="server" CssClass="auto-style40" Text="Supermercados" />
            </h1>
        </td>
        <td class="auto-style64">
            <asp:ImageButton ID="IB_Carrito" runat="server" CommandArgument='<%# Eval("Id") %>'   ImageUrl="~/Imagenes/Iconos/carrito-de-compras.png" PostBackUrl="~/View/Carrito.aspx" />
            <asp:Label ID="LB_Carrito" runat="server" ForeColor="#FF3300" Text="0"></asp:Label>
        </td>
    </tr>
    <tr>

        <td class="auto-style14" colspan="2">
            <h1 class="auto-style13">Filtros</h1>
        </td>
        <td class="auto-style11" colspan="3"></td>
    </tr>
    <tr>
        <td class="auto-style12" colspan="2">
            <asp:TextBox ID="TBX_buscar" runat="server"></asp:TextBox>
            <asp:Button ID="BTN_buscar" runat="server" OnClick="BTN_buscar_Click" Text="buscar" />
        </td>
        <td class="auto-style10" colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style38" colspan="5">
            <asp:DataList ID="DL_Productos" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" DataSourceID="ODS_inicioproductos" OnItemCommand="DL_Productos_ItemCommand">
                <ItemTemplate>
                    <table class="auto-style33">
                        <tr>
                            <td class="auto-style49">
                                &nbsp;</td>
                            <td class="auto-style50"><strong>
                                <asp:Label ID="LB_NombreAliado" runat="server" CssClass="auto-style40" Width="170px"> Aliado</asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style49"></td>
                            <td class="auto-style50"><strong>
                                <asp:TextBox ID="TBX_nombrealiado" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("nombre_aliado") %>' Width="170px"></asp:TextBox>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style37">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                            <td class="auto-style48">
                                <asp:Image ID="I_Productos" runat="server" Height="170px" ImageUrl='<%# Eval("imagen_producto1") %>' Width="170px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style49"></td>
                            <td class="auto-style50"><strong>
                                <asp:Label ID="LB_Nombre" runat="server" CssClass="auto-style40" Width="170px">Nombre</asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style51"></td>
                            <td class="auto-style52"><strong>
                                <asp:TextBox ID="TBX_nombreproducto" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("Nombre_producto") %>' Width="170px"></asp:TextBox>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style53"></td>
                            <td class="auto-style54"><strong>
                                <asp:Label ID="LB_Precio" runat="server" CssClass="auto-style40" Width="170px">Precio</asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style43">&nbsp;</td>
                            <td class="auto-style41"><strong>
                                <asp:TextBox ID="TBX_precio" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="20px" Text='<%# Eval("precio_producto") %>' Width="170px"></asp:TextBox>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style55">
                            </td>
                            <td class="auto-style56"><strong>
                                <asp:Label ID="LB_Descripcion" runat="server" CssClass="auto-style40" Height="20px" Width="200px">Descripcion del producto</asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style65">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <h1><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></h1>
                            </td>
                            <td class="auto-style66"><strong>
                                <asp:TextBox ID="TB_descripcion" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="58px" Text='<%# Eval("descripcion_producto") %>' Width="170px"></asp:TextBox>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style59">&nbsp;</td>
                            <td class="auto-style60">
                                <asp:Label ID="LB_especificacion" runat="server" CssClass="auto-style40" Text="Especificacion del pedido"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style59">&nbsp;</td>
                            <td class="auto-style60">
                                <asp:TextBox ID="TB_especificacion" runat="server" Height="58px" Width="170px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style59">&nbsp;</td>
                            <td class="auto-style60">
                                <strong>
                                <asp:Label ID="LB_Cantidad" runat="server" CssClass="auto-style40" Height="20px" Width="170px">Cantidad</asp:Label>
                                </strong>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style46">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                            <td class="auto-style47">
                                <strong>
                                <asp:TextBox ID="TBX_Cantidad" runat="server" CssClass="auto-style63" Font-Names="Times New Roman" Height="20px" TextMode="Number" ValidationGroup="VG_Cantidad" Width="170px"></asp:TextBox>
                                </strong>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style39">&nbsp;&nbsp; &nbsp;&nbsp;
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="REV_Cantidad" runat="server" ControlToValidate="TBX_Cantidad" ErrorMessage="cantidad erronea" ValidationExpression="\b(?![00]\b)\d{1,1}\b" ValidationGroup="VG_Cantidad"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style34"><%--CommandArgument='<%# Eval("Id") %>'--%>
                            </td>
                            <td class="auto-style41">
                                <asp:ImageButton ID="IB_Carrito" runat="server" CommandArgument='<%# Eval("Id") %>' ImageUrl="~/Imagenes/Iconos/anadir-al-carrito.png" ValidationGroup="VG_Cantidad"  />
                            </td>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="ODS_inicioproductos" runat="server" SelectMethod="mostrarproductoinicio" TypeName="DAOProductos"></asp:ObjectDataSource>
            <br />
        </td>
    </tr>
</table>
</asp:Content>

