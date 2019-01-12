<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Summa.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Введите два числа</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
