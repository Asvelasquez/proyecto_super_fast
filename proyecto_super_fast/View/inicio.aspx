﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/inicio.aspx.cs" Inherits="View_inicio" %>
<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>

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
            height: 50%;
            vertical-align: top;
            width: 36%;
        }
        .auto-style13 {
            height: 1%;
            font-size: medium;
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
        .auto-style67 {
            margin-right: 0px;
        }
        .auto-style68 {
            height: 41px;
            vertical-align: top;
            width: 36%;
        }
        .auto-style69 {
            height: 41px;
            vertical-align: top;
            width: 12%;
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
                <asp:Button ID="BTN_Restaurantes" runat="server" CssClass="auto-style40" Text="Restaurantes" OnClick="BTN_Restaurantes_Click1" />
            </h1>
        </td>
        <td class="auto-style42">
            <h1>
                <asp:Button ID="BTN_Supermecados" runat="server" CssClass="auto-style40" Text="Supermercados" />
            </h1>
        </td>
        <td class="auto-style64">
            <asp:ImageButton ID="IB_Carrito" runat="server" CommandArgument='<%# Eval("Id") %>'   ImageUrl="~/Imagenes/Iconos/carrito-de-compras.png" OnClick="IB_Carrito_Click" />
            <asp:Label ID="LB_Carrito" runat="server" ForeColor="#FF3300" Text="0"></asp:Label>
        </td>
    </tr>
    <tr>

        <td class="auto-style68" colspan="2">
            <h1 class="auto-style13">Filtros<asp:TextBox runat="server"></asp:TextBox>
            </h1>
        </td>
        <td class="auto-style69" colspan="3"></td>
    </tr>
    <tr>
        <td class="auto-style12" colspan="2">
            <asp:TextBox ID="TBX_filtro1" runat="server"></asp:TextBox>
            <asp:Button ID="BTN_buscar" runat="server" OnClick="BTN_buscar_Click" Text="buscar" />
            &nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="BTN_hamburguesa" runat="server" OnClick="BTN_hamburguesa_Click" Text="Hamburguesa" />
            
            &nbsp;
            <asp:Button ID="BTN_perrocaliente" runat="server" OnClick="BTN_perrocaliente_Click" Text="perro" />
            
            <br />
            <asp:TextBox ID="TBX_buscar" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="TBX_actividadcomercial" runat="server" Visible="False"></asp:TextBox>
            <br />
        </td>
        <td class="auto-style10" colspan="3"></td>
    </tr>
    <tr>
        <td class="auto-style38" colspan="5">
            <br />
            <br />
            <br />
            <asp:DataList ID="DL_Productos" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" DataSourceID="ODS_inicioproductos" OnItemCommand="DL_Productos_ItemCommand" CssClass="auto-style67">
                <ItemTemplate>
                    <table class="auto-style33">
                        <tr>
                            <td class="auto-style49">
                                &nbsp;</td>
                            <td class="auto-style50"><strong>
                                <asp:Label ID="LB_NombreAliado" runat="server" CssClass="auto-style40" Text='<%# Eval("actividad_comercial") %>' Width="170px"></asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style49"></td>
                            <td class="auto-style50"><strong>
                                <asp:TextBox ID="TBX_nombrealiado" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Width="170px" Text='<%# Eval("nombre_aliado") %>'></asp:TextBox>
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
                                <asp:TextBox ID="TBX_nombreproducto" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("nombre_producto") %>' Width="170px"></asp:TextBox>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style53"></td>
                            <td class="auto-style54"><strong>
                                <asp:Label ID="LB_Precio" runat="server" CssClass="auto-style40"  Width="170px">Precio</asp:Label>
                                </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style43">&nbsp;</td>
                            <td class="auto-style41"><strong>
                                <asp:TextBox ID="TBX_precio" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("precio_producto") %>' Height="20px" Width="170px"></asp:TextBox>
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
                                <br />
                                <asp:TextBox ID="TBX_correoaliado" runat="server"  Enabled="False" EnableTheming="True" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TBX_IDaliado" runat="server" Visible="False" Width="20px" Text='<%# Eval("Id_aliado") %>'></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style34"><%--CommandArgument='<%# Eval("Id") %>'--%>
                            </td>
                            <td class="auto-style41">
                                <asp:ImageButton ID="IB_Carrito" runat="server" CommandArgument='<%# Eval("Id") %>' ImageUrl="~/Imagenes/Iconos/anadir-al-carrito.png" ValidationGroup="VG_Cantidad" Width="32px"  />
                            </td>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="ODS_inicioproductos" runat="server" SelectMethod="mostrarproductoinicio" TypeName="DAOProductos"></asp:ObjectDataSource>
            <asp:GridView ID="GV_Filtros" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_filtro" Visible="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre_producto" SortExpression="Nombre_producto" />
                    <asp:BoundField DataField="Descripcion_producto" HeaderText="Descripcion_producto" SortExpression="Descripcion_producto" />
                    <asp:BoundField DataField="Precio_producto" HeaderText="Precio_producto" SortExpression="Precio_producto" />
                    <asp:BoundField DataField="Imagen_producto1" HeaderText="Imagen_producto1" SortExpression="Imagen_producto1" />
                    <asp:BoundField DataField="Estado_producto" HeaderText="Estado_producto" SortExpression="Estado_producto" />
                    <asp:BoundField DataField="Correo_aliado" HeaderText="Correo_aliado" SortExpression="Correo_aliado" />
                    <asp:BoundField DataField="Nombre_aliado" HeaderText="Nombre_aliado" SortExpression="Nombre_aliado" />
                    <asp:BoundField DataField="Actividad_comercial" HeaderText="Actividad_comercial" SortExpression="Actividad_comercial" />
                </Columns>
            </asp:GridView>

            <asp:ObjectDataSource ID="ODS_filtro" runat="server" SelectMethod="mostrarproductoiniciobusqueda" TypeName="DAOProductos">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TBX_buscar" Name="busqueda" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:DataList ID="DL_productosfiltros" runat="server" RepeatColumns="4" OnItemCommand="DL_productosfiltros_ItemCommand" DataSourceID="ODS_filtro" Visible="False">
                <ItemTemplate>
                    <table class="auto-style33">
                        <tr>
                            <td><strong>
                                <table class="auto-style33">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_NombreAliado1" runat="server" CssClass="auto-style40" Text='<%# Eval("actividad_comercial") %>' Width="170px"></asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_nombrealiado1" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("nombre_aliado") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Image ID="I_Productos1" runat="server" Height="170px" ImageUrl='<%# Eval("imagen_producto1") %>' Width="170px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Nombre1" runat="server" CssClass="auto-style40" Width="170px">Nombre</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_nombreproducto1" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("Nombre_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Precio1" runat="server" CssClass="auto-style40" Width="170px">Precio</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_precio1" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="20px" Text='<%# Eval("precio_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Descripcion1" runat="server" CssClass="auto-style40" Height="20px" Width="200px">Descripcion del producto</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TB_descripcion1" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="58px" Text='<%# Eval("descripcion_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Label ID="LB_especificacion1" runat="server" CssClass="auto-style40" Text="Especificacion del pedido"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TB_especificacion1" runat="server" Height="58px" Width="170px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Cantidad1" runat="server" CssClass="auto-style40" Height="20px" Width="170px">Cantidad</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_Cantidad1" runat="server" CssClass="auto-style63" Font-Names="Times New Roman" Height="20px" TextMode="Number" ValidationGroup="VG_Cantidad" Width="170px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="REV_Cantidad1" runat="server" ControlToValidate="TBX_Cantidad1" ErrorMessage="cantidad erronea" ValidationExpression="\b(?![00]\b)\d{1,1}\b" ValidationGroup="VG_Cantidad"></asp:RegularExpressionValidator>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TBX_correoaliado1" runat="server" Enabled="False" EnableTheming="True"  Visible="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TBX_actividadcomercialp1" runat="server" Text='<%# Eval("actividad_comercial") %>'></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:ImageButton ID="IB_Carrito1" runat="server" CommandArgument='<%# Eval("Id") %>' ImageUrl="~/Imagenes/Iconos/anadir-al-carrito.png" OnClick="IB_Carrito_Click" ValidationGroup="VG_Cantidad" Width="32px" />
                                        </td>
                                    </tr>
                                </table>
                                </strong>
                                <br />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <br />
            <asp:DataList ID="DL_productosfiltrorest" runat="server" RepeatColumns="4" OnItemCommand="DL_productosfiltros_ItemCommand" DataSourceID="ODS_filtrorest" Visible="False">
                <ItemTemplate>
                    <table class="auto-style33">
                        <tr>
                            <td><strong>
                                <table class="auto-style33">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_NombreAliado2" runat="server" CssClass="auto-style40" Text='<%# Eval("actividad_comercial") %>' Width="170px"></asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_nombrealiado2" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("nombre_aliado") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Image ID="I_Productos2" runat="server" Height="170px" ImageUrl='<%# Eval("imagen_producto1") %>' Width="170px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Nombre2" runat="server" CssClass="auto-style40" Width="170px">Nombre</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_nombreproducto2" runat="server" CssClass="auto-style61" Enabled="False" Font-Names="Times New Roman" Text='<%# Eval("Nombre_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Precio2" runat="server" CssClass="auto-style40" Width="170px">Precio</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_precio2" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="20px" Text='<%# Eval("precio_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Descripcion2" runat="server" CssClass="auto-style40" Height="20px" Width="200px">Descripcion del producto</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TB_descripcion2" runat="server" CssClass="auto-style63" Enabled="False" Font-Names="Times New Roman" Height="58px" Text='<%# Eval("descripcion_producto") %>' Width="170px"></asp:TextBox>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Label ID="LB_especificacion2" runat="server" CssClass="auto-style40" Text="Especificacion del pedido"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TB_especificacion2" runat="server" Height="58px" Width="170px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:Label ID="LB_Cantidad2" runat="server" CssClass="auto-style40" Height="20px" Width="170px">Cantidad</asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td><strong>
                                            <asp:TextBox ID="TBX_Cantidad2" runat="server" CssClass="auto-style63" Font-Names="Times New Roman" Height="20px" TextMode="Number" ValidationGroup="VG_Cantidad" Width="170px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="REV_Cantidad2" runat="server" ControlToValidate="TBX_Cantidad2" ErrorMessage="cantidad erronea" ValidationExpression="\b(?![00]\b)\d{1,1}\b" ValidationGroup="VG_Cantidad"></asp:RegularExpressionValidator>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TBX_correoaliado2" runat="server" Enabled="False" EnableTheming="True" Text='<%# Eval("correo_aliado") %>' Visible="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:TextBox ID="TBX_actividadcomercialp2" runat="server" Text='<%# Eval("actividad_comercial") %>'></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:ImageButton ID="IB_Carrito2" runat="server" CommandArgument='<%# Eval("Id") %>' ImageUrl="~/Imagenes/Iconos/anadir-al-carrito.png" OnClick="IB_Carrito_Click" ValidationGroup="VG_Cantidad" Width="32px" />
                                        </td>
                                    </tr>
                                </table>
                                </strong>
                                <br />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="ODS_filtrorest" runat="server" SelectMethod="mostrarproductoinicioactividad" TypeName="DAOProductos">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TBX_actividadcomercial" Name="busqueda" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
        </td>
    </tr>
</table>
</asp:Content>

