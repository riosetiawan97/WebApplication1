<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2PerhitunganGaji.aspx.cs" Inherits="WebApplication1._2PerhitunganGaji" %>

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
            <h1 style="text-align: center">Perhitungan Gaji</h1>
        </div>
        <p style="text-align: center">
            <table class="center">
              <tr>
                <td>&nbsp;Nama&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Nama" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                <td>&nbsp;Jabatan&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Jabatan" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                <td>&nbsp;Jumlah hari masuk dalam sebulan&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Hari" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                <td>&nbsp;Jumlah jam lembur dalam sebulan&nbsp;&nbsp;&nbsp;</td>
                <td> : <asp:TextBox ID="Lembur" runat="server"></asp:TextBox></td>
              </tr>
            </table>
        </p>
        <div class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
        </div>
        <p style="text-align: center">
            <asp:Label ID="HasilLabel" runat="server">
            </asp:Label>
        </p>
    </form>
</body>
</html>
