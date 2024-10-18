using AgencySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AgencySystem.BusinessLogic
{
    internal class Client : Person
    {
        public decimal Balance { get; set; }
        public Client(int id, string name, int age, decimal balance) : base(id, name, age) { Balance = balance; }


        public void FillBalance(decimal balance)
        {
            Balance += balance;
        }
        public void WithDraw(decimal balance)
        {
            Balance -= balance;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id {Id}, Name {Name}, Age {Age}, Balance {Balance}");
        }

    }
}
