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
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">SELECCIONE CLIENTE</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnAdiCli" runat="server" OnClick="btnAdiCli_Click" Text="Agregar" />
                </td>
                <td>
                    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Regresar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:GridView ID="gvCli" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="gvCli_RowCommand" OnSelectedIndexChanged="gvCli_SelectedIndexChanged" Width="752px">
                        <Columns>
                            <asp:BoundField DataField="cli_cod" HeaderText="CODIGO" />
                            <asp:BoundField DataField="cli_nom" HeaderText="NOMBRE" />
                            <asp:BoundField DataField="cli_tel" HeaderText="TELEFONO" />
                            <asp:CommandField HeaderText="ELEGIR" ShowSelectButton="True" />
                            <asp:ButtonField CommandName="Modificar" HeaderText="EDITAR" Text="EDIT" />
                            <asp:ButtonField CommandName="Eliminar" HeaderText="DEL" Text="DEL" />
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
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Panel ID="PanelCli" runat="server">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">
                                    <asp:Label ID="lbTitCli" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5">NOMBRES:</td>
                                <td>
                                    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">TELEFONO:</td>
                                <td>
                                    <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">RUC:</td>
                                <td>
                                    <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">DIRECCIÓN:</td>
                                <td>
                                    <asp:TextBox ID="txtDirec" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                                </td>
                                <td>
                                    <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
