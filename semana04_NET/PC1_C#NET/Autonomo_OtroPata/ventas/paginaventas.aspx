<%@ Page Language="C#" AutoEventWireup="true" CodeFile="paginaventas.aspx.cs" Inherits="paginaventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #000000;
            font-size: x-large;
        }
        .auto-style3 {
            color: #0066CC;
            height: 26px;
        }
        .auto-style4 {
            color: #000000;
            text-align: center;
        }
        .auto-style5 {
            background-color: #FF0000;
            }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body style="width: 592px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" style="text-align: center; background-color: #FF0000"><strong class="auto-style5">CLIENTES</strong></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gwalu" runat="server" CellPadding="4" Width="592px" AutoGenerateColumns="False" OnSelectedIndexChanged="gwalu_SelectedIndexChanged" AllowPaging="True" DataSourceID="LinqDataSource1" PageSize="5" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField HeaderText="cli_cod" DataField="cli_cod" ReadOnly="True" SortExpression="cli_cod" />
                            <asp:BoundField HeaderText="Nombre" DataField="cli_nom" ReadOnly="True" SortExpression="cli_nom" />
                            <asp:BoundField HeaderText="Telef" DataField="cli_tel" ReadOnly="True" SortExpression="cli_tel" />
                            <asp:CommandField HeaderText="ver factura" ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataVentas2DataContext" EntityTypeName="" Select="new (cli_cod, cli_nom, cli_tel)" TableName="Clientes">
                    </asp:LinqDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong class="auto-style4">FACTURAS</strong></td>
                <td class="auto-style6">
                    <asp:DropDownList ID="cbe" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbe_SelectedIndexChanged" Height="16px" Width="190px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gwcurso" runat="server" CellPadding="4" Width="596px" OnSelectedIndexChanged="gwcurso_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
