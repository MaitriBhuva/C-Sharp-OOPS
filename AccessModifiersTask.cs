// Create a class called BankAccount with the following:

// Private field balance (double).
// Public method Deposit(double amount) to add money to the balance.
// Public method Withdraw(double amount) to deduct money if the balance is sufficient.
// Public method DisplayBalance() to show the current balance.
// Create an object of the BankAccount class in the Main method and test all the methods.

namespace day2;

public class BankAccount
{
    //private field
    private double balance;

    //public method to add money to the balance
    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount cannot be negative");
        }
        else
        {
            balance += amount;
        }
    }

    //public method to withdraw money from the balance
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount cannot be negative");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= amount;
        }
    }

    //public method to display the balance
    public void DisplayBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}
