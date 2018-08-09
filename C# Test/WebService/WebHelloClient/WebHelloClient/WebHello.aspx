<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebHello.aspx.cs" Inherits="WebHelloClient.WebHello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" typeModel="MultiLine" runat="server" Height="32px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
