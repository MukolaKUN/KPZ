using System;
namespace ConsoleApplication2
{
    interface IAccount
    {
        int Capital { get; }
        void SetCapital(int money);
    }
}
