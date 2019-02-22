<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <div>
            <h1 style="text-align: center">Elige una opción:</h1>
            <ul class="list-group">
                <li class="list-group-item active"><asp:Button ID="numeros" runat="server" Text="Números" style="width: 199px" OnClick="redireccionar"/></li>
                <li class="list-group-item"><asp:Button ID="cadenas" runat="server" Text="Cadenas" style="width: 199px" OnClick="redireccionar"/></li>
            </ul>
        </div>
    </form>
</body>
</html>
