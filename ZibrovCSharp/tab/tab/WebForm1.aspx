<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tab.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    
    </div>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
