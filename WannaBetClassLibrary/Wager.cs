using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannaBetClassLibrary
{

    public class Wager
    {
        String description;
        double senderAmount;
        double senderMultiplier;

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

        public double SenderAmount
        {
            get
            {
                return this.senderAmount;
            }
            set
            {
                this.senderAmount = value;
            }
        }

        public double SenderMultiplier
        {
            get
            {
                return this.senderMultiplier;
            }
            set
            {
                this.senderMultiplier = value;
            }
        }
    }
}
