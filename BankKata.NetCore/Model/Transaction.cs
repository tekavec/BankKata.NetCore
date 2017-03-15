using System;

namespace BankKata.NetCore.Model
{
    public struct Transaction
    {
        private readonly decimal amount;
        private readonly DateTime today;

        public Transaction(decimal amount, DateTime today)
        {
            this.amount = amount;
            this.today = today;
        }
    }
}