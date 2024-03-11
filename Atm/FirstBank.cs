using Atm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FirstBank
{
    // List to store debit cards of the bank
   
    private List<DebitCard> users = new List<DebitCard>();
    // this is simply intializing the list <debitcard> and assigning it to users

    // Constructor to initialize the bank with users
    public FirstBank()
    {
        // Adding users to the bank
        users.Add(new DebitCard("123456789", 1234, "John Smith", 1000.00, this));
        users.Add(new DebitCard("987654321", 4321, "Sarah Johnson", 2500.00, this));
        users.Add(new DebitCard("456789123", 5678, "Michael Lee", 1500.00, this));
        users.Add(new DebitCard("789123456", 8765, "Emily Davis", 500.00, this));
        users.Add(new DebitCard("321654987", 9876, "David Rodriguez", 3000.00, this));
    }

    // Method to get all cards of the bank
    public List<DebitCard> GetAllCards()
    {
        return users;
    }
}
