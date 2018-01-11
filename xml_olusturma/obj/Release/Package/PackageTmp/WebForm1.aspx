<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="xml_olusturma.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Aktarım Merkezi</h2>
            <p>Veri tabanı kayıtlarını XML'e aktar</p>
            <asp:Button ID="Button1" runat="server" Text="XML'i Hazırla" CssClass="btn btn-success" OnClick="Button1_Click" />
        </div>
       <br>
        <div class="container" id="link" runat="server">
             <a href="<% Response.Write(yol); %>" class="btn btn-warning" role="link">İndir</a>
        </div>
    </form>
</body>
</html>
