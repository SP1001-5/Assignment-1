<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Assignment_1.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Product:
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                <asp:ListItem Text="--Select Product--" Value="--Select Product--"></asp:ListItem>
                <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
                <asp:ListItem Text="Smartphone" Value="Smartphone"></asp:ListItem>
                <asp:ListItem Text="Headphones" Value="Headphones"></asp:ListItem>
            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="imgProduct" runat="server" Width="200px" Height="200px" />
            <br /><br />

            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            <br /><br />

            Price: <asp:Label ID="lblPrice" runat="server" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
