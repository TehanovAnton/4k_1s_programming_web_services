<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="WebApplication1.Sum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="x_obj">X params</label>
            <p id="x_obj">
                <asp:TextBox runat="server" ID="x_s"/>
                <asp:TextBox runat="server" ID="x_k" />
                <asp:TextBox runat="server" ID="x_f" />
            </p>

            <label for="y_obj">Y params</label>
            <p id="y_obj">
                <asp:TextBox runat="server" ID="y_s" />
                <asp:TextBox runat="server" ID="y_k" />
                <asp:TextBox runat="server" ID="y_f" />
            </p>

            <asp:Button runat="server" ID="get_sum" OnClick="sum_Click" Text="Sum" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" />
        </div>
    </form>
</body>
</html>
