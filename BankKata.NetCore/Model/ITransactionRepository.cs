namespace BankKata.NetCore.Model
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
    }
}