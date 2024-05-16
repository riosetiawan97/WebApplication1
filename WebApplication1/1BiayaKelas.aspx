<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1BiayaKelas.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="position: relative">
    <form id="form1" runat="server">
        <div style="text-align: left; font-weight: 700">
            <h1 style="text-align: center">Biaya Kelas</h1>
        </div>
        <p style="text-align: center">
            &nbsp;Input Nilai Test :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NilaiTest" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="HasilLabel" runat="server">
            </asp:Label>
        </p>
    </form>
</body>
</html>
