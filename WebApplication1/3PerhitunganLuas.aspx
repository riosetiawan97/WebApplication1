<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3PerhitunganLuas.aspx.cs" Inherits="WebApplication1._3PerhitunganLuas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .center {
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</head>
<body style="position: relative">
    <form id="form1" runat="server">
        <div style="text-align: left; font-weight: 700">
            <h1 style="text-align: center">Perhitungan Luas</h1>
        </div>
        <p style="text-align: center">
            <table class="center">
              <tr>
                <td>&nbsp;Pilih Rumus&nbsp;&nbsp;&nbsp;</td>
                <td> : 
                    <asp:DropDownList ID="Rumus" runat="server">
                        <asp:ListItem Enabled="true" Text="Pilih Rumus" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Perhitungan Luas Segitiga" Value="Segitiga"></asp:ListItem>
                        <asp:ListItem Text="Perhitungan Luas Persegi Panjang" Value="Persegi"></asp:ListItem>
                        <asp:ListItem Text="Perhitungan Luas Lingkaran" Value="Lingkaran"></asp:ListItem>
                    </asp:DropDownList>

                </td>
              </tr>
              <tr>
                <td>&nbsp;Alas/Panjang/Radius&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Panjang" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                <td>&nbsp;Tinggi/Lebar&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Lebar" runat="server"></asp:TextBox></td>
              </tr>
            </table>
        </p>
        <div class="auto-style1">
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
        </div>
        <p style="text-align: center">
            <asp:Label ID="HasilLabel" runat="server">
            </asp:Label>
        </p>
    </form>
</body>
</html>
