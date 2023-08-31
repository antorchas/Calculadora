<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>calculadora</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el primer numero:"></asp:Label>
            <asp:TextBox ID="txtnro1" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="Label2" runat="server" Text="Ingrese el segundo numero:"></asp:Label>
            <asp:TextBox ID="txtnro2" runat="server"></asp:TextBox>
            
        </div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
