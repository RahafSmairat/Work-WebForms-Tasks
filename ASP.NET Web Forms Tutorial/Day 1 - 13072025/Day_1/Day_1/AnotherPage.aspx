<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnotherPage.aspx.cs" Inherits="Day_1.AnotherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ShowFromSession" runat="server" OnClick="ShowFromSession_Click" Text="Show" />
        <br />
        <asp:Button ID="ShowFromSession2" runat="server" Text="Show2" OnClick="ShowFromSession2_Click" />

        <br />
        <asp:Label ID="output" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="home" runat="server" OnClick="home_Click" Text="Go To Home" />
    </form>
</body>
</html>
