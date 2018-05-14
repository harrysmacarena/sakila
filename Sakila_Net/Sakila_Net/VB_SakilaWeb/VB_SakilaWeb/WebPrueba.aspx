<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebPrueba.aspx.vb" Inherits="VB_SakilaWeb.WebPrueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList  ID="ddPrueba" runat="server" Height="16px" Width="504px" Enabled="False">
            </asp:DropDownList>
            <br />
            <asp:Calendar ID="cldFecha" runat="server"></asp:Calendar>
        </div>
    </form>
</body>
</html>
