<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConcatPage.aspx.cs" Inherits="solution.ConcatPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Concat</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="s" />
            <asp:TextBox runat="server" ID="d" />
            <asp:Button runat="server" ID="concat" OnClick="concat_Click" Text="Concat" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" />
        </div>
    </form>
</body>
</html>
