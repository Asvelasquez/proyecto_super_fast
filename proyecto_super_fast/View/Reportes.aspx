<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mastersuper.master" AutoEventWireup="true" CodeFile="~/Controller/Reportes.aspx.cs" Inherits="View_Reportes" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

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
        <td>&nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <CR:CrystalReportViewer ID="CRV_Factura" runat="server" AutoDataBind="True" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="CRS_Facturas" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" HasRefreshButton="True" Visible="False" />
            <CR:CrystalReportSource ID="CRS_Facturas" runat="server">
                <Report FileName="C:\Users\Sneider\source\repos\proyecto_super_fast\proyecto_super_fast\Reportes\Factura.rpt">
                </Report>
            </CR:CrystalReportSource>
            <CR:CrystalReportSource ID="CRS_Factura" runat="server">
                <Report FileName="C:\Users\nicol\Documents\GitHub\proyecto_super_fast\proyecto_super_fast\Reportes\Factura.rpt">
                </Report>
            </CR:CrystalReportSource>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

