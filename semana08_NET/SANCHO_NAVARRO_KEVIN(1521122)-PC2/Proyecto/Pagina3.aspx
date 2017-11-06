<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 434px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>COMPRA DEL ARTEFACTO</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">CÓDIGO ARTEFACTO:</td>
                <td>
                    <asp:Label ID="lbCodArt" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">PRECIO CONTADO:</td>
                <td>
                    <asp:Label ID="lbPrecCont" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">CÓDIGO CLIENTE:</td>
                <td>
                    <asp:Label ID="lbCodCli" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">TIPO DE COMPRA:</td>
                <td>
                    <asp:RadioButtonList ID="rblTipoComp" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblTipoComp_SelectedIndexChanged">
                        <asp:ListItem Value="1">6 meses</asp:ListItem>
                        <asp:ListItem Value="2">12 meses</asp:ListItem>
                        <asp:ListItem Value="3">18 meses</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">INTERÉS A PAGAR:</td>
                <td>
                    <asp:Label ID="lbIntPag" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">SALDO:</td>
                <td>
                    <asp:Label ID="lbSaldo" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
                </td>
                <td>
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Regresar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:GridView ID="gvFact" runat="server" AllowPaging="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="gvFact_PageIndexChanging" PageSize="5" Width="755px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="nro_pro" HeaderText="Factura" />
                            <asp:BoundField DataField="cli_cod" HeaderText="Cod_Cliente" />
                            <asp:BoundField DataField="art_cod" HeaderText="Cod_Artic" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="meses" HeaderText="Meses" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
