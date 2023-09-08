<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculos.aspx.cs" Inherits="Calculadora.Calculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="1° Numero         "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="2° Numero   "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-bottom: 0px">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
            <asp:ListItem>Dividir</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Resultado   "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="158px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
