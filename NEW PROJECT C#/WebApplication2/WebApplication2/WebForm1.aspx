<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            max-height:100%;
            max-width:100%;
        }
        .auto-style1 {
            height: 150px;
        }
        .auto-style2 {
            border-style: double ;
           
            width: 64%;
        }
        .auto-style3 {
            display:flex;
            flex-direction:column;
        }
        .auto-style4 {
            height: 157px;
        }
        .auto-style5 {
            width: 64%;
        }
        .auto-style6 {
            width: 384px;
        }
        .auto-style7 {
            width: 375px;
        }
        .auto-style8 {
            width: 211px;
        }
        .auto-style9 {
            width: 209px;
        }
        .auto-style10 {
            width: 64%;
        }
        .auto-style11 {
            width: 385px;
        }
        .auto-style12 {
            width: 385px;
            height: 31px;
        }
        .auto-style13 {
            height: 31px;
            width: 1206px;
        }
        .auto-style14 {
            width: 1206px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
        <div class="auto-style3">
            <fieldset class="auto-style1">
                <legend>informations de connexion </legend>
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style7">Email:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="verifier email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="inseret email" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">Mot de passe:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="verifier mot de pass" ForeColor="Red" ValidationExpression=".*[!@#&amp;%*].*"></asp:RegularExpressionValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="inseret mot de pass" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">Nouveau mot de passe:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="CompareValidator"></asp:CompareValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="inseret mot de pass" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset class="auto-style4">
                <legend>informations ppersonnels</legend>
                <table class="auto-style5">
                    <tr>
                        <td class="auto-style6">Prenom:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Nom:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Adresse:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox6" runat="server" TextMode="Email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Etat:</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="TextBox7" runat="server" TextMode="Email" Width="162px"></asp:TextBox>
                        </td>
                        <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Code postal:</td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" TextMode="Email"></asp:TextBox>
                            <br />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="VERIFIER CODE POSTAL" ForeColor="Red" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Telephone:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox8" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="VERIFIER numero" ForeColor="Red" ValidationExpression="\(\d{3}\) \d{3}-\d{6}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <legend>informations de carte de credit</legend>

                <table class="auto-style10">
                    <tr>
                        <td class="auto-style12">Type de carte:</td>
                        <td class="auto-style13">&nbsp;&nbsp;&nbsp;
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem>Master card</asp:ListItem>
                                <asp:ListItem>Visa</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Numero de carte:</td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox10" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox10" Display="Dynamic" ErrorMessage="verifier numero de carte" ForeColor="Red" ValidationExpression="\d{16}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Date d&#39;expiration:</td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox11" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TextBox11" Display="Dynamic" ErrorMessage="verifier numero de carte" ForeColor="Red" ValidationExpression="\d\d/\d\d"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>

            </fieldset>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
