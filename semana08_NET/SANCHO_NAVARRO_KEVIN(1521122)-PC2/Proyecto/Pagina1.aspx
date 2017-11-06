<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina1.aspx.cs" Inherits="Pagina1" %>

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
        .auto-style3 {
            width: 375px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 375px;
            font-size: x-large;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">SELECCIONE LÍNEA DE ARTEFACTO</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cbLineas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbLineas_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>ARTEFACTOS</strong></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:GridView ID="gvArtef" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="176px" Width="713px" OnSelectedIndexChanged="gvArtef_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="art_cod" HeaderText="CODIGO" />
                            <asp:BoundField DataField="art_nom" HeaderText="DESCRIPCIÓN" />
                            <asp:BoundField DataField="art_pre" HeaderText="PRECIO" />
                            <asp:TemplateField HeaderText="IMAGEN">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="57px" ImageUrl='<%# Eval("art_img","artefactos/{0}") %>' Width="66px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField HeaderText="COMPRAR" SelectText="Comprar" ShowSelectButton="True" />
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
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
