namespace NETInterrogation_Console_App.Encapsulation
{
    public class BankAccount : IBankAccount
    {
        // Private fields or Private class members
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        // Property for AccountNumber with encapsulation
        public string AccountNumber 
        { 
            get 
            {  
                return accountNumber; 
            }

            set
            {
                accountNumber = value;
            }
        }
        public double CheckBalance()
        {
            return balance;
        }

        // add interface implementation implicitely
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Amount deposited successfully. Total current balance: {balance}");
            } else
            {
                Console.WriteLine("Invalid amount. Unable to deposit.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Amount withdrawn successfully. Total current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount or Insufficient balance. Unable to withdraw.");
            }
        }
    }
}
