namespace NETInterrogation_Console_App.Encapsulation
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double CheckBalance();
    }
}
