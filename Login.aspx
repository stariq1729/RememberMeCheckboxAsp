<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RememberMeCheckboxAsp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 67%;
        }
        .auto-style2 {
            width: 167px;
        }
    </style>
</head>
<body>
   <%-- <this lecture is not completed so there are certain things which is not cover in this chapter--%>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">USERNAME</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="147px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PASSWORD</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="147px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Remeber Me" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click1" Text="Login" Width="55px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
