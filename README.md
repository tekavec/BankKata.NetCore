# BankKata.NetCore
Bank kata exercise, developed with .NET Core, xUnit, FluentAssertions, StructureMap...

<b>Below is the description from [Sandro's Git repository] (https://github.com/sandromancuso/Bank-kata)</b>:

Think of your personal bank account experience
When in doubt, go for the simplest solution

*Requirements*
------------

Deposit and Withdrawal  
Transfer  
Account statement (date, amount, balance)  
Statement printing  
Statement filters (just deposits, withdrawal, date)


*Started from defining an acceptance test:*

> Given a client makes a deposit of 1000 on 10-01-2012  
And a withdrawal of 500 on 14-01-2012  
And a deposit of 2000 on 13-01-2012  
When she prints her bank statement  
Then she would see  
date       || credit   || debit    || balance  
14/01/2012 ||          || 500.00   || 2500.00   
13/01/2012 || 2000.00  ||          || 3000.00  
10/01/2012 || 1000.00  ||          || 1000.00   
