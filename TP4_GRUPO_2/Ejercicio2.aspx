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
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="120px"></asp:TextBox>
                    </td> 
                    <td>
                        <asp:RegularExpressionValidator ID="revIdProd" runat="server" ErrorMessage="Ingresar solo numeros" ValidationExpression="^[0-9]+$" ControlToValidate="txtIdProducto" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                        <asp:CustomValidator ID="cverrores" runat="server" ErrorMessage="Debe de completar ambos campos" OnServerValidate="cverrores_ServerValidate" ValidationGroup="grupo1">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>IdCategoria:</td><td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="100px">
                    </asp:DropDownList>
                    </td> <td>
                        <asp:TextBox ID="txtCategoria" runat="server" Width="120px"></asp:TextBox>
                    </td> <td>

                          <asp:RegularExpressionValidator ID="revCategorias" runat="server" ControlToValidate="txtCategoria" ValidationExpression="^[0-9]+$" ErrorMessage="Ingresar solo numeros" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                          </td>
                        
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnFiltro" runat="server" OnClick="btnFiltro_Click" Text="Filtrar" ValidationGroup="grupo1" />
                    </td>
                    <td>
                        <asp:Button ID="btQuitarFiltro" runat="server" OnClick="btQuitarFiltro_Click" Text="Quitar Filtro" /></td>
                    <td>
                        <asp:Label ID="lberrorfiltro" runat="server"></asp:Label></td>
                </tr>
                <asp:GridView ID="gvProductos" runat="server" CssClass="gridview"></asp:GridView>
            </table>
        </div>
        <div>
            <asp:ValidationSummary ID="VSerrores" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="grupo1" />
        </div>
    </form>
</body>
</html>
