<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RW_txt.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="69px" Width="201px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" Width="94px" 
            OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Button" 
            Width="85px" OnClick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>
