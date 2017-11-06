<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            height: 23px;
            width: 461px;
        }
        .auto-style6 {
            width: 461px;
        }
        .auto-style7 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">PACIENTES CITADOS DEL MÉDICO: </td>
                <td>
                    <asp:Label ID="lbNomMed3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">ESPECIALIDAD:</td>
                <td>
                    <asp:Label ID="lbNomEsp3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">CODIGO MEDICO:</td>
                <td>
                    <asp:Label ID="lbCodMed3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">CODIGO ESPECIALIDAD:</td>
                <td>
                    <asp:Label ID="lbCodEsp3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>COSTO DE ESPECIALIDAD: </td>
                <td>
                    <asp:Label ID="lbCostoEsp" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>NOMBRE DEL PACIENTE: </td>
                <td>
                    <asp:TextBox ID="txtNomPac" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">TIPO DE PACIENTE: </td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="rblTipoPac" runat="server" Width="146px">
                        <asp:ListItem Value="1">AMBULATORIO</asp:ListItem>
                        <asp:ListItem Value="2">AFILIADO</asp:ListItem>
                        <asp:ListItem Value="3">EMPRESA</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>PAGO: </td>
                <td>
                    <asp:Label ID="lbPago" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="REGISTRAR" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
