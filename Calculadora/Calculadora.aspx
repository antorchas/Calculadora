<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>calculadora</title>
</head>
    <script>
        function solonumeros(e) {

            var key;

            if (window.event) 
            {
                key = e.keyCode;
            }
            else if (e.which) 
            {
                key = e.which;
            }

            if ((key < 48 || key > 57) && key != 46) {
                return false;
            }

            return true;
        }
    </script>
<body>
    <div>
        <h2>Calculadora</h2>
         </div>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el primer numero:"></asp:Label>
            <asp:TextBox ID="txtnro1" onkeypress="javascript:return solonumeros(event)" MaxLength="9"  runat="server"></asp:TextBox>

            <br />
             <br />

            <asp:Label ID="Label2" runat="server" Text="Ingrese el segundo numero:"></asp:Label>
            <asp:TextBox ID="txtnro2" onkeypress="javascript:return solonumeros(event)" MaxLength="9" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="rbSumar" runat="server" GroupName="rdButtons" Text="Sumar" />
            <br />
            <asp:RadioButton ID="rbRestar" runat="server" GroupName="rdButtons" Text="Restar" />
            <br />
            <asp:RadioButton ID="rbMult" runat="server" GroupName="rdButtons" Text="Multiplicar" />
            <br />
            <asp:RadioButton ID="rbDividir" runat="server" GroupName="rdButtons" Text="Dividir" />
            <br />
            <br />
              <asp:Label ID="Label3" runat="server" Text="Resultado: "></asp:Label><asp:Label ID="lblResultado" runat="server" Text="0"></asp:Label>
             <br />
             <br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
        </div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
