using AgencySystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencySystem.BusinessLogic
{
    internal class AgentManager
    {
        private readonly UserChoices _userChoices;

        public AgentManager(UserChoices userChoices)
        {
            _userChoices = userChoices;
        }

        public void ManageAgentAddition()
        {
            while (true)
            {
                Console.WriteLine("Do you want to add an agent dynamically? (y/n)");
                string? input = Console.ReadLine();

                if (input?.ToLower() == "y")
                {
                    _userChoices.CreateDynamically();
                }
                else if (input?.ToLower() == "n")
                {
                    Console.WriteLine("Exiting dynamic addition.");
                    break;
                }
                else
                {
                    Console.WriteLine("Choose a valid option (y/n)!");
                }
            }
        }
    }
}
