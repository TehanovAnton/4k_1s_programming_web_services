﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox runat="server" ID="x" />
            <asp:TextBox runat="server" ID="y" />
            <asp:Button runat="server" ID="concat" OnClick="add_Click" Text="Concat" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" />
        </div>
    </form>
</body>
</html>
