<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_3c.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio_3c" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
         .tabla-libros {
         width: 100%;
         border-collapse: collapse;
         background-color: white;
         border-radius: 10px;
         overflow: hidden;
         margin-top: 15px;
         }
         .tabla-libros th {
         background-color: #4CAF50;
         color: white;
         padding: 10px;
         text-align: left;
         }
         .tabla-libros td {
         padding: 8px;
         border-bottom: 1px solid #ddd;
         }
         .tabla-libros tr:nth-child(even) {
         background-color: #f9f9f9;
         }
         .tabla-libros tr:hover {
         background-color: #f1f1f1;
         }
         .botonVolverDiseño {
         display: inline-block;
         padding: 10px 20px;
         background-color: #4CAF50;
         color: white;
         text-decoration: none;
         border-radius: 8px;
         font-weight: bold;
         border: none;
         transition: 0.3s;
         }

         .botonVolverDiseño:hover {
         background-color: #45a049;
         transform: scale(1.05);
         }
         body {
             background-image: url('img/gatitolibreria.jpg');
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
            <td>
                <asp:GridView ID="gvTodosLibros" runat="server" CssClass="tabla-libros"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LNBVolver" runat="server" CssClass="botonVolverDiseño" OnClick="LNBVolver_Click">Volver</asp:LinkButton>
            </td>
        </tr>
    </table>
</div>
    </form>
</body>
</html>
