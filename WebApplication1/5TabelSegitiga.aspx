<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5TabelSegitiga.aspx.cs" Inherits="WebApplication1._5TabelSegitiga" %>

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
<body>
    <form id="form1" runat="server">
        <div style="text-align: left; font-weight: 700">
            <h1 style="text-align: center">Tabel Segitiga</h1>
        </div>
        <p style="text-align: center">
            <table class="center">
              <tr>
                <td>&nbsp;Masukan Jumlah Kolom&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Kolom" runat="server"></asp:TextBox></td>
              </tr>
            </table>
        </p>
        <div class="auto-style1">
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
            <asp:Button ID="BackButton" runat="server" OnClick="BackButton_Click" Text="Back" />
        </div>
        <p style="text-align: center">
            <asp:Label ID="HasilLabel" runat="server">
            </asp:Label>
        </p>
    </form>
</body>
</html>
