<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina4.aspx.cs" Inherits="Pagina4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 271px;
        }
        .auto-style3 {
            width: 150px;
        }
        .auto-style4 {
            width: 271px;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"><strong>CONSULTA DE COMPRAS</strong></td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">CÓDIGO DE CLIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCodCli" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnBuscFact" runat="server" Text="Buscar" OnClick="btnBuscFact_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="gvFactForm2" runat="server" AllowPaging="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="gvFactForm2_PageIndexChanging" PageSize="5" Width="796px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="nro_pro" HeaderText="Factura" />
                            <asp:BoundField DataField="cli_cod" HeaderText="Cod_Cli" />
                            <asp:BoundField DataField="art_cod" HeaderText="Cod_Art" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="meses" HeaderText="Meses" />
                            <asp:BoundField DataField="interes" HeaderText="Interes" />
                            <asp:BoundField DataField="saldo" HeaderText="Saldo" />
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
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
