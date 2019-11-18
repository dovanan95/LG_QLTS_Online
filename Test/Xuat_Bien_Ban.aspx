<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuat_Bien_Ban.aspx.cs" Inherits="Test.Xuat_Bien_Ban" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 161px;
            height: 59px;
        }
        .auto-style3 {
            width: 868px;
            height: 59px;
        }
        .auto-style4 {
            width: 331px;
            height: 23px;
        }
        .auto-style5 {
            width: 694px;
            height: 23px;
        }
        .auto-style7 {
            width: 322px;
        }
        .auto-style9 {
            width: 264px;
        }
        .auto-style10 {
            margin-left: 68px;
        }
        .auto-style13 {
            margin-left: 10px;
        }
        .auto-style14 {
            margin-left: 40px;
        }
        .auto-style15 {
            width: 281px;
        }
        .auto-style16 {
            width: 105px;
        }
        .auto-style17 {
            width: 913px;
        }
        .auto-style18 {
            width: 281px;
            height: 24px;
        }
        .auto-style19 {
            height: 24px;
        }
        .auto-style20 {
            width: 264px;
            height: 24px;
        }
        .auto-style21 {
            width: 1024px;
        }
        .auto-style22 {
            width: 105px;
            height: 23px;
        }
        .auto-style23 {
            width: 913px;
            height: 23px;
        }
        .auto-style30 {
            width: 201px;
        }
        .auto-style31 {
            width: 42px;
        }
        .auto-style32 {
            width: 308px;
        }
        .auto-style35 {
            width: 64px;
        }
        .auto-style38 {
            width: 61px;
        }
        .auto-style41 {
            width: 207px;
        }
        .auto-style42 {
            width: 1026px;
        }
        .auto-style45 {
            width: 331px;
        }
        .auto-style46 {
            width: 333px;
        }
        .auto-style47 {
            width: 94px;
        }
        .auto-style48 {
            width: 935px;
        }
        .auto-style49 {
            width: 94px;
            height: 23px;
        }
        .auto-style50 {
            width: 935px;
            height: 23px;
        }
        .auto-style52 {
            width: 415px;
        }
        .auto-style53 {
            width: 121px;
        }
        .auto-style54 {
            width: 487px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style3">

                        <asp:Label ID="HeaderLG" Width="800px" Font-Size="Large" runat="server" Font-Bold="True" Text="Công ty TNHH LG Electronics Vietnam Haiphong" Height="39px"></asp:Label>
                        
                    </td>
                    <td class="auto-style2">

                        <asp:Image ID="Image1" ImageUrl="~/Image/share-default.jpg" ImageAlign="Middle" runat="server" Height="62px" Width="116px" CssClass="auto-style14" />

                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table>
                <tr>
                    <td class="auto-style4">
                        
                        <asp:Label ID="lblDate" runat="server" Text="..../..../......"></asp:Label>
                        
                    </td>
                    <td class="auto-style5">

                        <br />
                        <br />

                        <br />

                    </td>
                </tr>
                
            </table>
            <table class="auto-style21">
                <tr>
                    <td class="auto-style15">

                    </td>
                    <td class="auto-style7">

                        <asp:Label ID="lblBBBGTS" Font-Bold="True" Width ="288px" Font-Size ="Large" runat="server" Text="BIÊN BẢN GIAO NHẬN TÀI SẢN" CssClass="auto-style10"></asp:Label>

                    </td>
                    <td class="auto-style9">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">

                    </td>
                    <td class="auto-style19">

                        <asp:Label ID="lblBBBGTSENG" Font-Bold="True" Width ="312px" Font-Size ="Large" runat="server" Text="ASSET HANDOVER DOCUMENT" CssClass="auto-style10"></asp:Label>

                    </td>
                    <td class="auto-style20">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">

                    </td>
                    <td>

                        <asp:Label ID="ITWH" Font-Bold="False" Width ="130px" Font-Size ="Medium" runat="server" Text="IT WAREHOUSE:" CssClass="auto-style10"></asp:Label>

                        <asp:Label ID="lblTYPE_BB" Font-Bold="False" Width ="151px" Font-Size ="Medium" runat="server" Text=".............................." CssClass="auto-style13"></asp:Label>

                    </td>
                    <td class="auto-style9">

                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style16">

                    </td>
                    <td class="auto-style17">

                        <br />

                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">

                        <asp:Label ID="lblBBNO" runat="server" Text="Số Biên Bản:"></asp:Label>

                    </td>
                    <td class="auto-style23">

                        <asp:Label ID="lblSoBB" runat="server" Text="................................."></asp:Label>

                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>

                        Deliver/Bên Giao:</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style31">

                        ID:</td>
                    <td class="auto-style32">

                        <asp:Label ID="lblID_dlv" runat="server" Text="................................."></asp:Label>

                    </td>
                    <td class="auto-style38">

                        Name:</td>
                    <td class="auto-style45">

                        <asp:Label ID="lblName_dlv" runat="server" Text="........................................."></asp:Label>

                    </td>
                    <td class="auto-style35">

                        &nbsp;</td>
                    <td class="auto-style30">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">

                        Dept:</td>
                    <td class="auto-style32">

                        <asp:Label ID="lblDept_dlv" runat="server" Text="..........................................."></asp:Label>

                    </td>
                    <td class="auto-style38">

                        Mail:</td>
                    <td class="auto-style45">

                        <asp:Label ID="lblMail_dlv" runat="server" Text="..........................................."></asp:Label>

                    </td>
                    <td class="auto-style35">

                        Phone:</td>
                    <td class="auto-style30">

                        <asp:Label ID="lblPhone_dlv" runat="server" Text="............................................"></asp:Label>

                    </td>
                </tr>
            </table>
             <table>
                <tr>
                    <td>

                        Receiver/Bên Nhận:</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style31">

                        ID:</td>
                    <td class="auto-style32">

                        <asp:Label ID="lblID_Rcv" runat="server" Text="............................................"></asp:Label>

                    </td>
                    <td class="auto-style38">

                        Name:</td>
                    <td class="auto-style46">

                        <asp:Label ID="lblName_Rcv" runat="server" Text="............................................"></asp:Label>

                    </td>
                    <td class="auto-style35">

                        &nbsp;</td>
                    <td class="auto-style41">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">

                        Dept:</td>
                    <td class="auto-style32">

                        <asp:Label ID="lblDept_Rcv" runat="server" Text="............................................"></asp:Label>

                    </td>
                    <td class="auto-style38">

                        Mail:</td>
                    <td class="auto-style46">

                        <asp:Label ID="lblMail_Rcv" runat="server" Text="............................................"></asp:Label>

                    </td>
                    <td class="auto-style35">

                        Phone:</td>
                    <td class="auto-style41">

                        <asp:Label ID="lblPhone_Rcv" runat="server" Text="............................................"></asp:Label>

                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>

                        List of Asset/ Xác nhận việc giao nhận tài sản như sau:</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style42">

                        <asp:GridView ID="dgvDevice" runat="server" Width="1030px">
                        </asp:GridView>

                    </td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>

                        ADDITIONAL ITEM/ Dụng cụ, phụ tùng kèm theo:</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style42">

                        <asp:GridView ID="dgvMaterial" runat="server" Width="1030px">
                        </asp:GridView>

                    </td>

                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style47">

                        Reason/Lý do:</td>
                    <td class="auto-style48">

                        <asp:Label ID="lblReason" runat="server" Text=".............................................................................................."></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">

                        Note/Ghi chú:</td>
                    <td class="auto-style50">

                        <asp:Label ID="lblNote" runat="server" Text=".............................................................................................."></asp:Label>

                    </td>
                </tr>
            </table>
        </div>
        <div>

            <br />
            Biên bản này được lập thành ... bản. Khi có bất kỳ yêu cầu nào liên quan đến thiết bị, cần mang biên bản này theo để làm chứng.<br />
            There are ... copy of this document. For any request related to devices/equipment, need to show a copy for evidence.<br />
            <br />
            Các bên giữ biên bản/Copies of this document are kept by:<br />
            - Deliver/Bên quản lý tài sản: ................bộ<br />
            - Receiver/Bên nhận tài sản: ................bộ<br />
            <br />

        </div>
        <table>
            <tr>
                <td class="auto-style54">

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" Font-Bold ="true" runat="server" Text="Đại diện quản lý tài sản"></asp:Label>

                </td>
                <td class="auto-style52">

                    &nbsp;<asp:Label ID="Label7" Font-Bold ="True" runat="server" Text="Người nhận"></asp:Label>

                    &nbsp;</td>
                <td class="auto-style53">

                    <asp:Label ID="Label8" Font-Bold ="True" runat="server" Text="Người giao"></asp:Label>

                </td>
            </tr>
             <tr>
                <td class="auto-style54">

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:Label ID="Label4" Font-Italic="true" runat="server" Text="(Ký, họ tên, đóng dấu)"></asp:Label>

                &nbsp;&nbsp;</td>
                <td class="auto-style52">

                    <asp:Label ID="Label5" Font-Italic="true" runat="server" Text="(Ký, họ tên)"></asp:Label>

                </td>
                <td class="auto-style53">

                    <asp:Label ID="Label9" Font-Italic="true" runat="server" Text="(Ký, họ tên)"></asp:Label>

                </td>
            </tr>
        </table>
        <div>

            <br />
            <br />
            <br />
            <br />
            ______________________________________________________________________________________________________________________________________<br />
            Tôi hiểu và hoàn toàn tuân thủ theo quy định quản lý tài sản dưới đây của công ty:<br />
            1. Không tự ý chuyển giao thiết bị này cho người khác. Trong trường hợp không có nhu cầu sử dụng thiết bị, phải trả lại bộ phận quản lý tài sản.
            <br />
            2. Luôn đảm bảo máy tính/thiết bị ở trạng thái tốt nhất.
            <br />
            3. Phải hoàn trả toàn bộ chi phí trong trường hợp làm mất hoặc làm hỏng thiết bị (ngoại trừ lỗi của nhà sản xuất).

        </div>
    </form>
</body>
</html>
