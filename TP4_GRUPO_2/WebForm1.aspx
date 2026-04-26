<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP4_GRUPO_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 80vh;
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
                    <td><u>DESTINO INICIO: </u></td>
                </tr>
                <tr>
                    <td><b>PROVINCIA: </b></td>
                    <td><asp:DropDownList ID="ddlProvinciaInicio" runat="server">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td><b>LOCALIDAD: </b></td>
                    <td><asp:DropDownList ID="ddlLocalidadInicio" runat="server"></asp:DropDownList></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
