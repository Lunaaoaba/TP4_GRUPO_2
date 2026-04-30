<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        table 
        {
        maegin: auto;
        border: 2px solid black;
        background-color : #f9f9f9;
        padding: 10 px;
        }
        form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 80vh;
            font-family: Arial, sans-serif;
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
                    <td style="padding-left: 90px"><u>DESTINO INICIAL</u></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>PROVINCIA:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>LOCALIDAD:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddlLocalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><u>DESTINO FINAL</u></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>PROVINCIA:</b></td> <td>
                    <asp:DropDownList ID="ddlProvinciaDestino" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>LOCALIDAD:</b></td> <td>
                    <asp:DropDownList ID="ddlLocalidadDestino" runat="server">
                    </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
