using BankKata.NetCore.Model;

namespace BankKata.NetCore.Services.Print
{
    public interface IStatementPrinter
    {
        void PrintFormattedStatement(ITransactionRepository transactionRepository);
    }
}