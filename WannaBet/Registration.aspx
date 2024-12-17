<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WannaBet.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="RegistrationStyles.css" />
    <title>WannaBet Registration</title>
</head>
<body>
    <form id="frmRegistration" runat="server">
        <div class="registration-container">
    <h2>User Registration</h2>
        <div class="form-group">
            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtPassword">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtFirstName">First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtLastName">Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtPhoneNumber">Phone Number:</label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" TextMode="Phone" CssClass="form-control" required></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Button ID="btnSubmit" runat="server" Text="Register" 
                CssClass="btn btn-primary" OnClick="btnSubmit_OnClick" />
        </div>
        
        <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
</div>
    </form>
</body>
</html>
