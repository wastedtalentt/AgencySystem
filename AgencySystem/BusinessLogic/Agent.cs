using AgencySystem.Models;
using AgencySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgencySystem.BusinessLogic
{
    internal class Agent : Person
    {
        public decimal CommissionRate { get; set; }
        public Agent(int id, string name, int age, decimal commissionRate) : base(id, name, age) { CommissionRate = commissionRate; }
        List<Client>? clients { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id {Id}, Name {Name}, Age {Age}, CommissionRate {CommissionRate}");
        }
    }
}
