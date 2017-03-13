using System;

namespace BankKata.NetCore.Infrastructure
{
    public interface IClock
    {
        DateTime Today();
    }
}