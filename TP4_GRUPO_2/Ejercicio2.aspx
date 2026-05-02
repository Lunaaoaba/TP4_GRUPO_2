<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        form {
            font-family: Arial, sans-serif;
        }
        div {
            padding: 0 0 0 20px;
        }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Id Producto:</td><td>
                    <asp:DropDownList ID="ddlProducto" runat="server" Width="100px">
                    </asp:DropDownList>
                    </td> <td>
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="padding-bottom: 30px;">IdCategoria:</td><td style="padding-bottom: 30px;">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="100px">
                    </asp:DropDownList>
                    </td> <td style="padding-bottom: 30px;">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <asp:GridView ID="gvProductos" runat="server"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
