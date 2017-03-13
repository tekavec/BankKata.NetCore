using BankKata.NetCore.Infrastructure;
using BankKata.NetCore.Model;
using BankKata.NetCore.Services;
using BankKata.NetCore.Services.Print;
using NSubstitute;
using Xunit;

namespace BankKata.NetCore.Tests
{
    public class AccountShould
    {
        [Fact]
        public void print_a_statement()
        {
            IClock clock = Substitute.For<IClock>();
            ITransactionRepository transactionRepository = Substitute.For<ITransactionRepository>();
            IConsole console = Substitute.For<IConsole>();
            IStatementPrinter statementPrinter = new StatementPrinter(console);
            var account = new Account(clock, transactionRepository, statementPrinter);

            account.Deposit(1000);
            account.Withdraw(500);
            account.Deposit(2000);

            console.Received().WriteLine("date       ||     credit ||      debit ||    balance");
            console.Received().WriteLine("14/01/2012 ||            ||     500.00 ||    2500.00");
            console.Received().WriteLine("13/01/2012 ||    2000.00 ||            ||    3000.00");
            console.Received().WriteLine("10/01/2012 ||    1000.00 ||            ||    1000.00");
        }
    }
}