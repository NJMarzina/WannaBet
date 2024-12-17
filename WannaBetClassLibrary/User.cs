using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WannaBetClassLibrary
{
    public class User
    {
        int userID;
        String username;
        String password;
        String firstName;
        String lastName;
        String email;
        //add address shit later
        int phone;
        double balance;
        int numBets;
        int numWins;
        int numLoses;

        public int UserID
        {
            get
            {
                return this.userID;
            }
            set
            {
                this.userID = value;
            }
        }

        public String Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public String Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public String FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public String Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public int NumBets
        {
            get
            {
                return this.numBets;
            }
            set
            {
                this.numBets = value;
            }
        }

        public int NumWins
        {
            get
            {
                return this.numWins;
            }
            set
            {
                this.numWins = value;
            }
        }

        public int NumLoses
        {
            get
            {
                return this.numLoses;
            }
            set
            {
                this.numLoses = value;
            }
        }
    }
}
