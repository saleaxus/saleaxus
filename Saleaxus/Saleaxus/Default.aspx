<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Saleaxus.Default" %>
<%@ Register Src="~/controls/ProductControl.ascx" TagPrefix="uc" TagName="Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ProductList" runat="server">
                <ItemTemplate>
                    <uc:Product runat="server" Product="<%# Container.DataItem %>"/>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
