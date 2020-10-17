<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/RecuperarContrasenia.aspx.cs" Inherits="View_RecuperarContrasenia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="L_Contrasenia" runat="server" Text="Digite su nueva contaseña: "></asp:Label>
                        <asp:TextBox ID="TB_Contrasenia" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="L_ConfirmarContrasenia" runat="server" Text="Repita su nueva contraseña: "></asp:Label>
                        <asp:TextBox ID="TB_ConfirmarContrasenia" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Tb_Contraseña" ControlToValidate="TB_Repetir" ErrorMessage="CompareValidator"></asp:CompareValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTN_Cambiar" runat="server" OnClick="B_Cambiar_Click" Text="Cambiar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
