<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/administrador.aspx.cs" Inherits="View_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style33 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style33">
        <tr>
            <td>&nbsp;<br />
        <asp:Label ID="LB_solicitudesaliados" runat="server" Font-Size="X-Large" Height="25px" Text="Solicitudes de aliados"></asp:Label>
                <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODSaliado" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="NIT" SortExpression="Documento" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Actividadcomercial" HeaderText="Actividad comercial" SortExpression="Actividadcomercial" />
                <asp:TemplateField HeaderText="Logo" >
                    <ItemTemplate>
                        <asp:Image ID="IM_perfil" runat="server" Height="38px" Width="75px" ImageUrl='<%# Eval("Imagenperfil") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_aceptaraliado" runat="server" CommandName="Aceptar" CommandArgument='<%# Eval("Id") %>' Text="Aceptar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rechazar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_rechazaraliado" runat="server" CommandName="Rechazar" CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rut2"></asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSaliado" runat="server" SelectMethod="mostrarsolicitudaliado" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
        <asp:Label ID="LB_solicituddomicilios" runat="server" Font-Size="X-Large" Height="25px" Text="Solicitudes de domiciliarios"></asp:Label>
       
                <br />
       
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODSDom" OnRowCommand="GridView2_RowCommand">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                <asp:TemplateField HeaderText="Imagen Perfil">
                    <ItemTemplate>
                        <asp:Image ID="IM_perfil2" runat="server" Height="33px" Width="42px" ImageUrl='<%# Eval("Imagenperfil") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Tipovehiculo" HeaderText="Tipovehiculo" SortExpression="Tipovehiculo" />
                <asp:TemplateField HeaderText="aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_aceptardomiciliario" runat="server"  CommandName="Aceptar" CommandArgument='<%# Eval("Id") %>' Text="Aceptar"    />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rechazar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_rechazardomiciliario" runat="server" CommandName="Rechazar"  CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hoja de Vida">
                    <ItemTemplate>
                        <asp:HyperLink ID="HYL_hojavida"  NavigateUrl='<%# Eval("hojavida") %>' Target="_blank" runat="server">Hoja de vida</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSDom" runat="server" SelectMethod="mostrarsolicituddomiciliario" TypeName="DAOUsuario"></asp:ObjectDataSource>
   
                <br />
   
         <asp:Label ID="LB_solicitudalaadosrechazados" runat="server" Text="Solicitud de aliados rechazados" Font-Size="X-Large"></asp:Label>
                <br />
        <asp:GridView ID="GV_aliadorechazado" runat="server" AutoGenerateColumns="False" DataSourceID="ODSaliadorechazado" OnRowCommand="GV_aliadorechazado_RowCommand">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="NIT" SortExpression="Documento" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Actividadcomercial" HeaderText="Actividadcomercial" SortExpression="Actividadcomercial" />
                <asp:TemplateField HeaderText="Logo">
                    <ItemTemplate>
                        <asp:Image ID="IM_perfil3" runat="server" Height="32px" Width="48px" ImageUrl='<%# Eval("Imagenperfil") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_aceptar" runat="server" CommandName="Aceptar"  CommandArgument='<%# Eval("Id") %>' Text="Aceptar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Revision">
                    <ItemTemplate>
                        <asp:Button ID="BTN_revision" runat="server" CommandName="Revision"  CommandArgument='<%# Eval("Id") %>' Text="Revision" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         <asp:ObjectDataSource ID="ODSaliadorechazado" runat="server" SelectMethod="mostrarsolicitudaliadorechazado" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
        <asp:Label ID="LB_solicituddomiciliariosrechazados" runat="server" Text="Solicitud de domiciliarios rechazados" Font-Size="X-Large"></asp:Label>
                <br />
        <asp:GridView ID="GV_domiciliariorechazado" runat="server" AutoGenerateColumns="False" DataSourceID="ODSdomiciliariorechazados" OnRowCommand="GV_domiciliariorechazado_RowCommand">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                <asp:BoundField DataField="Imagenperfil" HeaderText="Imagenperfil" SortExpression="Imagenperfil" />
                <asp:BoundField DataField="Hojavida" HeaderText="Hojavida" SortExpression="Hojavida" />
                <asp:BoundField DataField="Tipovehiculo" HeaderText="Tipovehiculo" SortExpression="Tipovehiculo" />
                <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
                <asp:TemplateField HeaderText="Aceptar">
                    <ItemTemplate>
                        <asp:Button ID="BTN_acpetar" runat="server" CommandName="Aceptar"  CommandArgument='<%# Eval("Id") %>' Text="Aceptar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Revision">
                    <ItemTemplate>
                        <asp:Button ID="BTN_revision0" runat="server" CommandName="Revision"  CommandArgument='<%# Eval("Id") %>' Text="Revision" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         <asp:ObjectDataSource ID="ODSdomiciliariorechazados" runat="server" SelectMethod="mostrarsolicituddomiciliariorechazado" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
       &nbsp;<asp:Label ID="LB_solicitudalidosaceptados" runat="server" Text="Solicitud de aliados aceptados" Font-Size="X-Large"></asp:Label>
         &nbsp;&nbsp;<br />
                <asp:GridView ID="GV_solicitudaliadosaceptados" runat="server" AutoGenerateColumns="False" DataSourceID="ODSalidadoaceptado" OnRowCommand="GV_solicitudaliadosaceptados_RowCommand">
             <Columns>
                 <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                 <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                 <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                 <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                 <asp:BoundField DataField="Documento" HeaderText="NIT" SortExpression="Documento" />
                 <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                 <asp:BoundField DataField="Actividadcomercial" HeaderText="Actividadcomercial" SortExpression="Actividadcomercial" />
                 <asp:BoundField DataField="Imagenperfil" HeaderText="Logo" SortExpression="Imagenperfil" />
                 <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
                 <asp:TemplateField HeaderText="Rechazar">
                     <ItemTemplate>
                         <asp:Button ID="BTN_Rechazaraliadosaceptados" runat="server" CommandName="Rechazar"  CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
         <asp:ObjectDataSource ID="ODSalidadoaceptado" runat="server" SelectMethod="mostrarsolicitudaliadoaceptado" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
         <asp:Label ID="LB_solicituddedomiciliariosaceptados" runat="server" Text="Solicitud de domiciliarios aceptados" Font-Size="X-Large"></asp:Label>
         &nbsp;<br />
                <asp:GridView ID="GV_domiciliariosaceptados" runat="server" AutoGenerateColumns="False" DataSourceID="ODSdomiciliarioaceptado" OnRowCommand="GV_domiciliariosaceptados_RowCommand">
             <Columns>
                 <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                 <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                 <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                 <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                 <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                 <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                 <asp:BoundField DataField="Imagenperfil" HeaderText="Imagenperfil" SortExpression="Imagenperfil" />
                 <asp:BoundField DataField="Hojavida" HeaderText="Hojavida" SortExpression="Hojavida" />
                 <asp:BoundField DataField="Tipovehiculo" HeaderText="Tipovehiculo" SortExpression="Tipovehiculo" />
                 <asp:BoundField DataField="Aprobacion" HeaderText="Aprobacion" SortExpression="Aprobacion" />
                 <asp:TemplateField HeaderText="Rechazar">
                     <ItemTemplate>
                         <asp:Button ID="BTN_rechazardomiciiarioaceptado" runat="server" CommandName="Rechazar"  CommandArgument='<%# Eval("Id") %>' Text="Rechazar" />
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
         <asp:ObjectDataSource ID="ODSdomiciliarioaceptado" runat="server" SelectMethod="mostrarsolicituddomiciliarioaceptado" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
         <asp:Button ID="BTN_solicitudesrechazas" runat="server"  Text="Solicitudes Rechazadas" OnClick="BTN_solicitudesrechazas_Click" Width="179px" BorderColor="Black" Height="30px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTN_solicitudesaceptadas" runat="server" Text="Solicitudes Aceptadas" Width="179px" OnClick="BTN_solicitudesaceptadas_Click" BorderColor="Black" Height="30px" />
         &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTN_solicitudesaprobar" runat="server" Text="Solicitudes por aprobar" BorderColor="Black" Height="30px" Width="179px" />
         <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
    </table>
   
  
    
</asp:Content>

