<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 312px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">REGISTRO DE ALUMNOS</td>
            </tr>
            <tr>
                <td class="auto-style2">APELLIDO</td>
                <td>
                    <asp:TextBox ID="txtape" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">NOMBRE</td>
                <td>
                    <asp:TextBox ID="txtnom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">ESPECIALIDAD</td>
                <td>
                    <asp:DropDownList ID="cbesp" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbesp_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PROCEDENCIA</td>
                <td>
                    <asp:RadioButtonList ID="rbp" runat="server">
                        <asp:ListItem Value="N">Nacional</asp:ListItem>
                        <asp:ListItem Value="P">Particular</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btGrabar" runat="server" Text="Grabar" />
                </td>
                <td>
                    <asp:Button ID="btNuevo" runat="server" Text="Nuevo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
