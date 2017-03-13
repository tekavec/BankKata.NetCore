using BankKata.NetCore.Infrastructure;
using BankKata.NetCore.Model;

namespace BankKata.NetCore.Services.Print
{
    public class StatementPrinter : IStatementPrinter
    {
        public StatementPrinter(IConsole console)
        {
            throw new System.NotImplementedException();
        }

        public void PrintFormattedStatement(ITransactionRepository transactionRepository)
        {
            throw new System.NotImplementedException();
        }
    }
}