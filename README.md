# ATM-updated

1. DebitCard Class:
This class represents a debit card and holds information about it.
It has properties for the card number, PIN, name, balance, and a reference to the bank the card belongs to (FirstBank).
The constructor initializes the card information including the bank reference.
2. FirstBank Class:
This class represents a bank and manages its users' debit cards.
It contains a list of DebitCard objects representing users' accounts.
The constructor initializes the bank with some predefined user accounts.
It provides a method GetAllCards() to retrieve all debit cards associated with the bank.
3. Transaction Class:
This class handles various transactions such as deposit, withdrawal, balance inquiry, and transfer.
It provides a method Options() to display transaction options to the user.
It contains methods for deposit, withdrawal, and transfer, each performing the respective transaction after user input.
Transfer method ensures that transfers can only occur between users of the same bank.
4. Program Class:
This is the entry point of the ATM console application.
It initializes a FirstBank object and prompts the user to insert their debit card.
After validating the card number, it displays a welcome message and presents transaction options using the Transaction class.
Based on the user's choice, it executes the corresponding transaction method from the Transaction class.
It prompts the user for their PIN and validates it before proceeding with the transaction.
After completing the transaction, it prompts the user if they want to perform another transaction or exit.

Summary:
The ATM console app simulates basic banking operations including deposit, withdrawal, balance inquiry, and transfer.
It ensures security by validating the card number and PIN before allowing transactions.
Transfers are restricted to users within the same bank to maintain security and prevent unauthorized transactions.
The app provides a user-friendly interface and allows users to perform multiple transactions in a single session.
