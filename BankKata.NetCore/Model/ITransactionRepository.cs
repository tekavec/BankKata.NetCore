using System;

namespace BankKata.NetCore.Model
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
    }

    public class Transaction
    {
        public Transaction(decimal amount, DateTime today)
        {
            throw new NotImplementedException();
        }
    }
}