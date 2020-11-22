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
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_Factura" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
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

