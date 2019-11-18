<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Test.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1524px;
            height: 468px;
        }
        .auto-style5 {
            width: 291px;
            height: 41px;
        }
        .auto-style6 {
            width: 176px;
            height: 41px;
        }
    </style>
</head>
<body style="width: 1530px; height: 619px">
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        &nbsp;
        &nbsp;&nbsp;
        <table>
            <tr>
                <td class="auto-style5">1<asp:Button ID="Button2" runat="server" Height="75px" Text="Button" Width="151px" OnClick="Button2_Click" />
                </td>
                <td class="auto-style6">
        <asp:Image ID="Image1" runat="server" Width="600px" ImageUrl="~/Image/6892330-chinese-city-wallpaper.jpg" Height="374px" />
                </td>
                <td class="auto-style6">
            <asp:Button ID="Button1" runat="server" Height="68px" OnClick="Button1_Click" Text="Button" Width="120px" />
                </td>
            </tr>
            <tr>
                <td>1</td>
                <td>2</td>
                <td>3</td>
            </tr>
        </table>
    </form>
</body>
</html>
