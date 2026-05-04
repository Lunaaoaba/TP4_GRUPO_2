 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 3a.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio_3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
            background-image: url('img/FondoEJ3.jpeg');
            background-size: cover;
            background-position: center;
            background-attachment: fixed;
            cursor: url('img/cursor.png'), auto;
        }

        form {
            font-family: Arial, sans-serif;
        }

        .container {
            padding: 20px;
            background-color: #ffffff;
            width: 400px;
            border-radius: 10px;
            margin: 80px auto;
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
        <div class="container">
            <table>
                <tr>
                    <td>Seleccinar Tema: </td>
                    <td>
                        <asp:DropDownList ID="ddlTemas" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:LinkButton ID="LbtnLibros" runat="server" OnClick="LbtnLibros_Click">Ver libros</asp:LinkButton>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
