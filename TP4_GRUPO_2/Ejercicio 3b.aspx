<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 3b.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio_3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
         body {
             background-image: url('img/bckg2.gif');
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
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="lblListado" runat="server" Text="Listado de Libros:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="gvLibros" runat="server" CssClass="gridview"></asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
