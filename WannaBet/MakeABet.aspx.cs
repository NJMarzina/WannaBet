using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WannaBetClassLibrary;

namespace WannaBet
{
    public partial class MakeABet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendBet_OnClick(object sender, EventArgs e)
        {
            //will be naturally incremented in stored procedure
            int wagerID = 1;

            //will have to grab from a cookie/other
            int userIDSender = 1;

            //stored procedure GetUserIDByUsername
            int userIDReciever = 2;

            //from textbox
            double wagerAmountSender;

            //from textbox
            double wagerMultiplier; //tb

            //calculated in Wager
            double wagerAmountReciever; //calculate

            //calculated in Wager
            double wagerAmountTotal;    //calculate

            //from textbox
            String description; //tb

            //defualt sent/pending
            String status;  //default sent/pending

            /*
            Wager newWager = new Wager
            {
                UserIDSender = grab from cookie,
                UserIDReciever = grab from GetUserIDByUsername,
                WagerAmountSender = txtWagerAmountSender,
                WagerMultiplier = ddlWagerMultiplier,
                WagerAmountReciever = Wager.CalculateWagerAmountReciever(txtWagerAmountSender, ddlWagerMultiplier),
                WagerAmountTotal = Wager.Caulcator(txtWagerAmountSender, newWager.WagerAmountReciever)
                Description = txtDescription,
                Status = "Sent & Pending"
            };
            */
        }
    }
}