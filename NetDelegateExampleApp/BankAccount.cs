using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDelegateExampleApp
{
    delegate void AccountHandler(string message);

    class BankAccount
    {
        int amount;

        AccountHandler? handler;

        public BankAccount(int amount = 0) 
        {
            this.amount = amount;
        }

        public void AddMoney(int amount) => this.amount += amount;

        public void TakeMoney(int amount)
        {
            if (amount <= this.amount)
            {
                this.amount -= amount;
                handler?.Invoke($"from account takes {amount} rub.");
            }
            else
                handler?.Invoke($"Balance of account {this.amount} less than {amount}");
        }

        public void RegisterAccountHandler(AccountHandler handler) 
            => this.handler += handler;

        public void UnregisterAccountHandler(AccountHandler handler)
            => this.handler -= handler;

    }
}
