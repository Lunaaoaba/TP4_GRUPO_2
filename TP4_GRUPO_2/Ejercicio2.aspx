<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Id Producto:</td><td>
                    <asp:DropDownList ID="ddlProducto" runat="server" Width="120px">
                    </asp:DropDownList>
                    </td> <td>
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>IdCategoria:</td><td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="120px">
                    </asp:DropDownList>
                    </td> <td>
                        <asp:TextBox ID="txtCategoria" runat="server" Width="250px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
