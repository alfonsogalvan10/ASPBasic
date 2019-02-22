<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Numeros.aspx.cs" Inherits="Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="../style.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="row calculator">
    <div class="mycalc">
        <h2>Calculadora</h2>
	<form id="calculator" runat="server">
		<asp:TextBox ID="txtnumero1" runat="server" OnInit="textBox_Enter"></asp:TextBox>
        <asp:Label ID="labelOperacion" runat="server"></asp:Label>
        <asp:TextBox ID="txtnumero2" runat="server" OnInit="textBox_Enter"></asp:TextBox>
        <br />
        <asp:Label ID="labelIgual" runat="server"></asp:Label>
        <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
		<div>
        <asp:Button ID="Button1" runat="server" Text="1" OnClick="PonerNumerito" />
        <asp:Button ID="Button2" runat="server" Text="2" OnClick="PonerNumerito" />
        <asp:Button ID="Button3" runat="server" Text="3" OnClick="PonerNumerito" />
        <asp:Button ID="ButtonSumar" runat="server" Text="+" OnClick="SumarCick"/>
	    </div>
	    <div>
        <asp:Button ID="Button4" runat="server" Text="4" OnClick="PonerNumerito" />
        <asp:Button ID="Button5" runat="server" Text="5" OnClick="PonerNumerito" />
        <asp:Button ID="Button6" runat="server" Text="6" OnClick="PonerNumerito" />
        <asp:Button ID="ButtonRestar" runat="server" Text="-" OnClick="RestarClick"/>
		</div>
		<div>
        <asp:Button ID="Button7" runat="server" Text="7" OnClick="PonerNumerito" />
        <asp:Button ID="Button8" runat="server" Text="8" OnClick="PonerNumerito" />
        <asp:Button ID="Button9" runat="server" Text="9" OnClick="PonerNumerito" />
        <asp:Button ID="ButtonMultiplicar" runat="server" Text="*" OnClick="MultiplicarClick"/>
	    </div>
	    <div>
        <asp:Button ID="Button0" runat="server" Text="0" OnClick="PonerNumerito" />
        <asp:Button ID="ButtonDividir" runat="server" Text="/" OnClick="DividirClick" />
	    </div>
	    <div class="results">
		<asp:Button ID="clear" runat="server" Text="LIMPIAR" OnClick="Clear"/>
	    </div>

	</form>	
    </div>
</div>
</body>
</html>
