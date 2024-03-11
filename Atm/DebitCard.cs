using System;
using System.Collections.Generic;

namespace Atm
{
    public class DebitCard
    {
        // creating field variables that would store the 4 info of debit card
        string cardNum;
        int pin;
        string name;
        double balance;

        //am creating reference to the bank it belongs to
        public FirstBank Bank { get; set; }

        //intializing the debit card info
        public DebitCard(string cardNum, int pin, string name, double balance, FirstBank bank)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.name = name;
            this.balance = balance;
            this.Bank = bank;
            // the this word refers to the current intance of their variables
        }

        // defining properties for Debit card info
        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}