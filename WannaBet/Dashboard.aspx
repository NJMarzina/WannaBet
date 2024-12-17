<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WannaBet.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="DashboardStyles.css" />
    <title>WannaBet?</title>
</head>
<body>
    <form id="frmDashboard" runat="server">
        <!-- Header Section -->
        <div class="header">
            <h1>Wanna Bet?</h1>
            <div class="profile-link">
                <a href="Profile.aspx">View Profile</a>
            </div>
        </div>

        <!-- Dashboard Content -->
        <div class="dashboard-content">
            <p class="welcome-message">Welcome to your betting dashboard! You can manage your bets and search for users below.</p>
            
            <div class="links">
                <ul>
                    <li><a href="AllBets.aspx">See All Bets</a></li>
                    <li><a href="MakeABet.aspx">Search for Users to Send a Bet/Make a Quick Bet</a></li>
                </ul>
            </div>

            <!-- Additional Content -->
            <p class="other-info">Use the links above to view current bets or send new ones to other users.</p>
        </div>
    </form>
</body>
</html>
