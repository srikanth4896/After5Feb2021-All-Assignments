<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryStateCity.aspx.cs" Inherits="DrDnLiCountryStateCity.CountryStateCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Choose Country"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" Height="46px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--Choose Country--</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Choose State"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>--Choose State--</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Choose City"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="True" AutoPostBack="True">
            <asp:ListItem>--Choose City--</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
