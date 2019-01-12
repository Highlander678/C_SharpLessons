<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Valid1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ErrorMessage="CompareValidator"></asp:CompareValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:CompareValidator ID="CompareValidator2" runat="server" 
        ErrorMessage="CompareValidator"></asp:CompareValidator>
    </form>
</body>
</html>
