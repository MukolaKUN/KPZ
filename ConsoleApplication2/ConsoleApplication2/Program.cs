using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Account : IAccount
    {
        public int Capital { get; protected set; }
        public virtual void SetCapital(int money)
        {
            if (money < 0)
                throw new Exception("Не можна покласти на рахунок менше 0");
            this.Capital = money;
        }
    }
    class MicroAccount : IAccount
    {
        public int Capital { get; protected set; }
        public void SetCapital(int money)
        {
            if (money < 0)
                throw new Exception("Не можна покласти на рахунок менше 0");
            if (money > 100)
                throw new Exception("Не можна покласти на рахунок більше 100");
            this.Capital = money;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount acc = new MicroAccount();
            InitializeAccount(acc);
            Console.Read();
        }
        public static void InitializeAccount(IAccount account)
        {
            //account.SetCapital(20); // умова, що задовільняє об’єкти обох класів
             account.SetCapital(200); // умова, що не задовільняє об’єкт класу MicroAccount
            Console.WriteLine(account.Capital);
        }
    }
}
