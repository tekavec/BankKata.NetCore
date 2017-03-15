using System;
using BankKata.NetCore.Infrastructure;
using BankKata.NetCore.Model;
using BankKata.NetCore.Services;
using BankKata.NetCore.Services.Print;
using NSubstitute;
using Xunit;

namespace BankKata.NetCore.Tests.Services
{
    public class AccountShould
    {
        private readonly IClock clock = Substitute.For<IClock>();
        private readonly ITransactionRepository transactionRepository = Substitute.For<ITransactionRepository>();
        private readonly IStatementPrinter statementPrinter = Substitute.For<IStatementPrinter>();
        private readonly DateTime aDate = new DateTime(2017, 1, 1);

        [Fact]
        public void store_a_deposit()
        {
            clock.Today().Returns(aDate);
            var account = new Account(clock, transactionRepository, statementPrinter);

            account.Deposit(1000m);

            transactionRepository.Received().Add(new Transaction(1000m, aDate));
        }

    }
}