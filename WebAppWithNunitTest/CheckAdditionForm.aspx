<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckAdditionForm.aspx.cs" Inherits="WebAppWithNunitTest.CheckAdditionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 573px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Variable 1"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Variable2"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sum" Width="93px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Result" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
