<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset >
                <legend>inscription</legend>
                id:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />

                nom:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
            
                prenom:&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
        
                date_naiss:&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
                <br />
                <br />
            
                email:&nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
           
                <br />
                <br />
           
                pesudo:&nbsp;
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
          
                <br />
                <br />
          
                password:&nbsp;
                <asp:TextBox id="password1" runat="server"></asp:TextBox>

                <br />
                <br />

                password confarmation:&nbsp;
                <asp:TextBox id="password2" runat="server"></asp:TextBox>
           
                <br />
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
           
                <br />
                <asp:CheckBox id="genPassword" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="generer password" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="valider" />
                <asp:Button ID="Button2" runat="server" Text="anuller" />
                <br />
           
            </fieldset>
           <!-- <script>
function generatePassword() {
    var length = document.getElementById('TextBox7').value; // Longueur du mot de passe
    var charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+{}[]|:;<>,.?/~"; // Caractères possibles dans le mot de passe
    var password = "";
    for (var i = 0; i < length; ++i) {
        password += charset.charAt(Math.floor(Math.random() * charset.length));
    }
    return password;
}

document.getElementById('genPassword').addEventListener('change', function() {
    if (this.checked) {
        var password = generatePassword();
        document.getElementById('password1').value = password;
        document.getElementById('password2').value = password;
    } else {
        document.getElementById('password1').value = '';
        document.getElementById('password2').value = '';
    }
});
            </script>-->
        </div>
    </form>
</body>
</html>
