<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeABet.aspx.cs" Inherits="WannaBet.MakeABet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MakeABet</title>
</head>
<body>
    <form id="frmMakeABet" runat="server">
        <div>
            <asp:Label ID="lblWagerRecieverUsername" runat="server" Text="Send a bet to"></asp:Label>
            <asp:TextBox ID="txtWagerRecieverUsername" runat="server"></asp:TextBox>

            <asp:Label ID="lblWagerAmountSender" runat="server" Text="Wager amount"></asp:Label>
            <asp:TextBox ID="txtWagerAmountSender" runat="server"></asp:TextBox>

            <asp:DropDownList ID="ddlWagerMultiplier" runat="server"></asp:DropDownList>
            <!--Add  a thing here probably that computes the expected the reciever will wager.-->
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>

            <asp:Button ID="btnSendBet" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
