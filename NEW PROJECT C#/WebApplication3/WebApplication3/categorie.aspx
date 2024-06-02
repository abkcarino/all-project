<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorie.aspx.cs" Inherits="WebApplication3.categorie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            id:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            nom:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="inseret" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="renitialiser" />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="679px">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
