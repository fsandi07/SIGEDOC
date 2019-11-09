<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Word.aspx.cs" Inherits="CrearWord1.Word" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 149px;
        }
        .auto-style3 {
            width: 896px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Asunto:</td>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtb1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Cliente:</td>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtb2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Numero de Referencia</td>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtb3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha:</td>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtb4" runat="server" TextMode="DateTime"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Label ID="lblm" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="btnCrear" runat="server" OnClick="btnCrear_Click" Text="Crear" />
    </form>
</body>
</html>
