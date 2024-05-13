using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Encapsulation
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double CheckBalance();
    }
}
