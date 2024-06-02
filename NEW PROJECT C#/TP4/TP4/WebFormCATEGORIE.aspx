<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCATEGORIE.aspx.cs" Inherits="TP4.WebFormCATEGORIE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 64px;
            width: 660px;
        }
        .auto-style2 {
            width: 155px;
            height: 52px;
        }
        .auto-style5 {
            width: 660px;
        }
        .auto-style6 {
            width: 247px;
        }
        .auto-style7 {
            height: 64px;
            width: 247px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>recharcher</legend>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="go" CausesValidation="false" OnClick="Button2_Click" />
            </fieldset>
            <fieldset>
                <legend> categorie</legend>
            <table>
               <tr>
                   <td class="auto-style6"><asp:Label ID="lblIdCat" runat="server" Text="Id :"></asp:Label></td>
                   <td class="auto-style5"> <asp:TextBox ID="tbIdCat" runat="server" TextMode="Number" Width="175px"></asp:TextBox> 
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbIdCat" ErrorMessage="inserer le Id !" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                   </td>
               </tr>
                <tr>
                    <td class="auto-style6"> <asp:Label ID="lblNomCat" runat="server" Text="Nom :"></asp:Label> </td>
                    <td class="auto-style5"> <asp:TextBox ID="tbNomCat" runat="server" Width="175px"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbNomCat" ErrorMessage="inserer le Nom !" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"> <asp:Button ID="btnInsereCat" runat="server" Text="inserer" OnClick="BtnInsereCat_Click" BackColor="#FF3300" BorderStyle="Ridge" ForeColor="Black" Height="49px" Width="151px" />  </td>
                    <td class="auto-style1"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="Button1" type="reset" value="reset" class="auto-style2" />
                        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
            </table>
                </fieldset>
         <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="Black" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="idcat" OnSelectedIndexChanging="GridView2_SelectedIndexChanging" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" Width="810px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
    <Columns>
        <asp:CommandField ShowSelectButton="True" HeaderText="Sélectionner" />
        <asp:CommandField ShowEditButton="True" HeaderText="Modi" CausesValidation="False" />
        <asp:TemplateField HeaderText="Suppri" ShowHeader="False">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Supprimer"
                    
                   
                   OnClientClick ="return confirm ('Êtes-vous sûr de supprimer !!!')"></asp:LinkButton>


            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>

        </div>
       
    </form>
</body>
</html>
