using Atm;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Our Bank!");

        FirstBank firstBank = new FirstBank();

        // Prompt user to insert their debit card
        Console.WriteLine("Please insert your debit card:");

        // Read card number from the user
        string cardNumber = Console.ReadLine();

        // Find the user with the provided card number
        DebitCard user = firstBank.GetAllCards().Find(c => c.CardNum == cardNumber);

        // Check if the user exists
        if (user == null)
        {
            Console.WriteLine("Invalid account number. Please enter the correct account number.");
            return;
        }

        Console.WriteLine($"Welcome, {user.Name}!");

        // Initialize Transaction class
        Transaction transaction = new Transaction();

        // Display options
        Transaction.Options();

        // Read user's option
        string option = Console.ReadLine();

        switch (option.ToLower())
        {
            case "deposit":
                Console.WriteLine("Please enter the amount you want to deposit:");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                // Call the deposit method
                transaction.Deposit(user, depositAmount);
                break;

            case "withdraw":
                Console.WriteLine("Please enter the amount you want to withdraw:");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                // Call the withdraw method
                transaction.Withdraw(user, withdrawAmount);
                break;

            case "show balance":
                Console.WriteLine($"Your current balance is: {user.Balance}");
                break;

            case "transfer":
                Console.WriteLine("Please enter the recipient's account number:");
                string recipientAccountNumber = Console.ReadLine();
                // Find the recipient user
                DebitCard recipient = firstBank.GetAllCards().Find(c => c.CardNum == recipientAccountNumber);
                if (recipient == null)
                {
                    Console.WriteLine("Recipient account number not found.");
                    return;
                }
                Console.WriteLine("Enter the amount you want to transfer:");
                double transferAmount = Convert.ToDouble(Console.ReadLine());
                // Call the transfer method
                transaction.Transfer(user, recipient, transferAmount);
                break;

            default:
                Console.WriteLine("Invalid option. Please choose a valid option.");
                break;
        }

        // If the option involves a transaction, prompt for pin
        if (option.ToLower() == "deposit" || option.ToLower() == "withdraw" || option.ToLower() == "transfer")
        {
            Console.WriteLine("Please enter your PIN:");
            int pinAttempts = 3;
            while (pinAttempts > 0)
            {
                int enteredPin = Convert.ToInt32(Console.ReadLine());
                if (enteredPin == user.Pin)
                {
                    // Correct pin, proceed with the transaction
                    Console.WriteLine("PIN correct. Transaction successful.");
                    break;
                }
                else
                {
                    // Incorrect pin, decrement pin attempts
                    pinAttempts--;
                    if (pinAttempts == 0)
                    {
                        // Block the account after three failed attempts
                        Console.WriteLine("PIN incorrect. Account blocked.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"PIN incorrect. {pinAttempts} more trials remaining.");
                    }
                }
            }
        }

        // Prompt the user if they want to perform another transaction or exit
        Console.WriteLine("Thank you for banking with us!");
        Console.WriteLine("Do you want to perform another transaction? (yes/no)");

        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            // If the user wants to perform another transaction, call Main method recursively
            Main(args);
        }
        else
        {
            // If the user wants to exit, display a goodbye message and exit the application
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}