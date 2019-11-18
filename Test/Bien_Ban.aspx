<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bien_Ban.aspx.cs" Inherits="Test.Bien_Ban" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 189px;
        }

        .auto-style3 {
            width: 189px;
            height: 45px;
        }

        .auto-style4 {
            width: 11px;
        }

        .auto-style5 {
            width: 109px;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tr>
        <th class="auto-style2">Số Biên Bản</th>
        <th class="auto-style4">&nbsp;</th>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:TextBox ID="txtSoBB" runat="server" Width="179px" OnTextChanged="txtSoBB_TextChanged"></asp:TextBox>
        </td>
        <td class="auto-style4"></td>
        <td class="auto-style5">
            <asp:Button ID="btnExport" runat="server" Text="Export" Width="90px" OnClick="btnExport_Click" Font-Bold="True" Font-Names="Arial" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2" align="center">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
</table>
        </div>
</body>

</form>

</html>
