using BankKata.NetCore.Infrastructure;
using BankKata.NetCore.Model;
using BankKata.NetCore.Services.Print;

namespace BankKata.NetCore.Services
{
    public class Account
    {
        private readonly IClock clock;
        private readonly ITransactionRepository transactionRepository;
        private readonly IStatementPrinter statementPrinter;

        public Account(IClock clock, ITransactionRepository transactionRepository, IStatementPrinter statementPrinter)
        {
            this.clock = clock;
            this.transactionRepository = transactionRepository;
            this.statementPrinter = statementPrinter;
        }

        public void PrintStatement()
        {
            statementPrinter.PrintFormattedStatement(transactionRepository);
        }

        public void Deposit(decimal amount)
        {
            transactionRepository.Add(new Transaction(amount, clock.Today()));
        }

        public void Withdraw(decimal amount)
        {
            transactionRepository.Add(new Transaction(-amount, clock.Today()));
        }
    }
}