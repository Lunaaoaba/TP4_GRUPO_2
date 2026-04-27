<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_2.Ejercicio1" %>

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
                    <td style="padding-left: 90px"><u>DESTINO INICIAL</u></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>PROVINCIA:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddlProvincia" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>LOCALIDAD:</b></td>
                    <td> 
                        <asp:DropDownList ID="ddpLocalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><u>DESTINO FINAL</u></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td style="padding-left: 90px"><b>PROVINCIA:</b></td> <td>
                    <asp:DropDownList ID="ddlProvinciaDestino" runat="server">
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
