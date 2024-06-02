<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormtp1.aspx.cs" Inherits="WebApplication1.WebFormtp1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 652px">
    <form id="form1" runat="server">
        <div style="font: 100% 'Bahnschrift SemiLight'; background: #FFFFFF; margin-left:100px">
             <fieldset style="height: 171px,; color: #000099;">
                <legend>exemple:</legend>
                <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="39px"></asp:TextBox>
                 <br />
                 <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="valider" Height="58px" OnClick="Button1_Click" BorderColor="#000099" BorderStyle="Solid" />
                   <br />
                      </fieldset>
                 <fieldset class="id">
                     <legend>les jours</legend>
                     <asp:CheckBox ID="CheckBox1" runat="server" Text="vendredi" />
                    <br />
                 <asp:CheckBox ID="CheckBox2" runat="server" Text="samedi" />
                    <br />
                 <asp:CheckBox ID="CheckBox3" runat="server" Text="dimenche" />
                    <br />
                 <asp:CheckBox ID="CheckBox4" runat="server" Text="lundi" />
                    <br />
                 <asp:CheckBox ID="CheckBox5" runat="server" Text="mardi"/>
                    <br />
                 <asp:CheckBox ID="CheckBox6" runat="server" Text="mercredi" />
                    <br />
                 <asp:CheckBox ID="CheckBox7" runat="server" Text="jeudi"/>
                <br />
                     <br />
                     <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                     <br />
                 </fieldset>
            <fieldset>
                <legend>liste box</legend>
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                    <asp:ListItem Value="1">Arabe</asp:ListItem>
                    <asp:ListItem Value="2">Anglais</asp:ListItem>
                    <asp:ListItem Value="3">Allemend</asp:ListItem>
                </asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            </fieldset>
            <fieldset>
                 <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>arabe</asp:ListItem>
                <asp:ListItem>anglais</asp:ListItem>
                <asp:ListItem>allmend</asp:ListItem>
             </asp:CheckBoxList>
             <br />
            <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" SelectionMode="Multiple" AutoPostBack="True">
                
             </asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </fieldset>
           
            </div>
           
    </form>
            </body>
</html>
