<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forminicio.aspx.cs" Inherits="Tarea10.forminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonCardatos" runat="server" OnClick="ButtonCardatos_Click" Text="Cargar datos de SQL" />
        </div>
        <p>
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonbuscarID" runat="server" OnClick="ButtonbuscarID_Click" Text="Buscar ID SQL" />
        </p>
        <p>
            <asp:TextBox ID="TextBoxNombre" runat="server" Width="503px"></asp:TextBox>
            <asp:Button ID="Buttonbuscpornombre" runat="server" OnClick="Buttonbuscpornombre_Click" Text="Buscar por nombre SQL" />
        </p>
        <asp:Button ID="ButtonCargardatosMysql" runat="server" OnClick="ButtonCargardatosMysql_Click" Text="Cargar Datos de MYSQL" />
        <p>
            <asp:TextBox ID="TextBoxBuscarIDMY" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonBUSCARIDMY" runat="server" OnClick="ButtonBUSCARIDMY_Click" Text="Buscar ID MYSQL" />
        </p>
        <asp:TextBox ID="TextBoxBuscarpornombreMY" runat="server" Width="506px"></asp:TextBox>
        <asp:Button ID="ButtonBUSCARNOMMY" runat="server" OnClick="ButtonBUSCARNOMMY_Click" Text="Buscar por nombre MYSQL" Width="276px" />
    </form>
</body>
</html>
