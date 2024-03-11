using Atm;
using System.Reflection.Metadata.Ecma335;

public class Transaction
{
    public static void Options()
    {
        Console.WriteLine("Please choose from one of these options");
        Console.WriteLine("Deposit");
        Console.WriteLine("Withdraw");
        Console.WriteLine("Show Balance");
        Console.WriteLine("Transfer");
    }

    //Method for depositing

    //Note: By passing a DebitCard object as a parameter, the method gains
    //access to all the properties and methods associated with a DebitCard,
    public void Deposit(DebitCard currentUser, double depositAmount)
    {
        // Update the balance by adding the deposit amount
        currentUser.Balance += depositAmount;
        Console.WriteLine($"Deposit successful. New balance: {currentUser.Balance}");
    }

    //Method for withdrawing
    public void Withdraw(DebitCard currentUser, double withdrawal)
    {
        // Checking if the user has enough money to withdraw
        if (currentUser.Balance < withdrawal)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            currentUser.Balance -= withdrawal; // Subtract withdrawal from balance
            Console.WriteLine("Withdrawal successful...");
        }
    }

    // Method for transferring money between accounts
    public void Transfer(DebitCard sender, DebitCard receiver, double transferAmount)
    {
        // Check if sender and receiver belong to the same bank
        if (sender.Bank != receiver.Bank)
        {
            Console.WriteLine("Transfers can only take place between two people from the same bank.");
        }
        else
        {
            // Checking if the sender has enough balance to transfer
            if (sender.Balance < transferAmount)
            {
                Console.WriteLine("Insufficient funds for transfer");
            }
            else
            {
                // Subtract transfer amount from sender's balance
                sender.Balance -= transferAmount;

                // Add transfer amount to receiver's balance
                receiver.Balance += transferAmount;

                Console.WriteLine($"Transfer of {transferAmount} successful.");
                Console.WriteLine($"Sender's new balance: {sender.Balance}");
                Console.WriteLine($"Receiver's new balance: {receiver.Balance}");
            }
        }
    }
}

