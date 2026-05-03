<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
            background-image: url('img/bckg.jpg');
            background-size: cover;
            background-position: center;
            background-attachment: fixed;
        }
        form {
            font-family: Arial, sans-serif;
        }
        div {
            padding: 0 0 0 20px;
        }
        .gridview {
            background-color: #ffffff;
            border: 1px solid #ccc;
        }
        .gridview tr {
            background-color: #ffffff;
        }
        .gridview tr:hover {
            background-color: #f0f0f0;
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
                    <td>Id Producto:</td>
                    <td>
                        <asp:DropDownList ID="ddlProducto" runat="server" Width="100px">
                        </asp:DropDownList>
                    </td> 
                    <td>
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="100px"></asp:TextBox>
                    </td> 
                    <td>
                        <asp:RegularExpressionValidator ID="revIdProd" runat="server" ErrorMessage="Ingresar solo numeros" ValidationExpression="^[0-9]+$" ControlToValidate="txtIdProducto"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="padding-bottom: 30px;">IdCategoria:</td><td style="padding-bottom: 30px;">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="100px">
                    </asp:DropDownList>
                    </td> <td style="padding-bottom: 30px;">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="100px"></asp:TextBox>
                    </td>
                    <tr>
                        <td></td> <td>
                        <asp:Button ID="btnFiltro" runat="server" OnClick="btnFiltro_Click" Text="Filtrar" />
                        </td>
                    </tr>
                </tr>
                <asp:GridView ID="gvProductos" runat="server" CssClass="gridview"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
