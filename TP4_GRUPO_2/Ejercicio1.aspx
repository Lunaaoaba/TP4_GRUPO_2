<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
            background: linear-gradient(270deg, #ad9191, #a0a0bc, #99af99);
            background-size: 400% 400%;
            animation: move 10s linear infinite;
        }
        @keyframes move {
            0% {
                background-position: 0% 50%;
            }

            50% {
                background-position: 100% 50%;
            }

            100% {
                background-position: 0% 50%;
            }
        }
        form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 90vh;
            padding-right: 20px;
            font-family: Arial, sans-serif;
        }
        .tarjeta {
            background: rgba(255, 255, 255, 0.3);
            backdrop-filter: blur(10px);
            border-radius: 20px;
            border: 1px solid rgba(255, 255, 255, 0.5);
            padding: 40px;
            box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.1);
        }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="tarjeta">
                <tr>
                    <td><u>DESTINO INICIAL</u></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td><b>PROVINCIA:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" Width="180px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><b>LOCALIDAD:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddlLocalidad" runat="server" Width="180px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td><u>DESTINO FINAL</u></td>
                </tr>
                <tr>
                    <td><br /></td>
                </tr>
                <tr>
                    <td><b>PROVINCIA:</b></td> <td>
                    <asp:DropDownList ID="ddlProvinciaDestino" runat="server" AutoPostBack="True" Width="180px" OnSelectedIndexChanged="ddlProvinciaDestino_SelectedIndexChanged">
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><b>LOCALIDAD:</b></td> <td>
                    <asp:DropDownList ID="ddlLocalidadDestino" runat="server" Width="180px">
                    </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
