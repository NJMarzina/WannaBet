using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannaBetClassLibrary
{

    public class Wager
    {
        int wagerID;
        int userIDSender;
        int userIDReciever;
        double wagerAmountSender;
        double wagerMultiplier;
        double wagerAmountReciever;
        double wagerAmountTotal;
        String description;
        String status;

        public int WagerID
        {
            get
            {
                return this.wagerID;
            }
            set
            {
                this.wagerID = value;
            }
        }

        public int UserIDSender
        {
            get
            {
                return this.userIDSender;
            }
            set
            {
                this.userIDSender = value;
            }
        }

        public int UserIDReciever
        {
            get
            {
                return this.userIDReciever;
            }
            set
            {
                this.userIDReciever = value;
            }
        }

        public double WagerAmountSender
        {
            get
            {
                return this.wagerAmountSender;
            }
            set
            {
                this.wagerAmountSender = value;
            }
        }

        public double WagerMultiplier
        {
            get
            {
                return this.wagerMultiplier;
            }
            set
            {
                this.wagerMultiplier = value;
            }
        }

        public double WagerAmountReciever
        {
            get
            {
                return this.wagerAmountReciever;
            }
            set
            {
                this.wagerAmountReciever = value;
            }
        }

        public double WagerAmountTotal
        {
            get
            {
                return this.wagerAmountTotal;
            }
            set
            {
                this.wagerAmountTotal = value;
            }
        }

        public String Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public String Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        //Calculator for wagerAmountSender
        public double CalculateWagerAmountReciever(double amountSender, double multiplier)
        {
            return (amountSender * multiplier) - amountSender;
        }

        public double CalculateWagerAmountReciever(Wager wager)
        {
            return (wager.wagerAmountSender * wager.WagerMultiplier) - wager.wagerAmountSender;
        }

        //Calculator for wagerAmountTotal
        public double CalculateWagerAmountTotal(double amountSender, double amountReciever)
        {
            return amountSender + amountReciever;
        }

        public double CalculateWagerAmountTotal(Wager wager)
        {
            return wager.wagerAmountSender + wager.wagerAmountReciever;
        }
    }
}
