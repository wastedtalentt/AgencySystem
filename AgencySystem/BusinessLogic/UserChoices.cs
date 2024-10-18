using AgencySystem.BusinessLogic;

namespace AgencySystem.BusinessLogic
{
    internal class UserChoices
    {
        private AgencyFields fields;

        // Constructor to accept AgencyFields instance
        public UserChoices(AgencyFields fields)
        {
            this.fields = fields;
        }

        public void CreateDynamically()
        {
            Console.WriteLine("Creating a new agent");

            Console.WriteLine("Enter Agent Id");
            if (!int.TryParse(Console.ReadLine(), out int agentId))
            {
                Console.WriteLine("Invalid input for Agent Id. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter Agent Name");
            string? agentName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(agentName))
            {
                Console.WriteLine("Agent Name cannot be empty.");
                return;
            }

            Console.WriteLine("Enter Agent Age");
            if (!int.TryParse(Console.ReadLine(), out int agentAge))
            {
                Console.WriteLine("Invalid input for Agent Age. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter Commission Rate");
            if (!decimal.TryParse(Console.ReadLine(), out decimal agentCommissionRate))
            {
                Console.WriteLine("Invalid input for Commission Rate. Please enter a valid decimal.");
                return;
            }


            Agent agent = new Agent(agentId, agentName, agentAge, agentCommissionRate);


            fields.AddAgent(agent);

            Console.WriteLine($"Agent created: Id = {agent.Id}, Name = {agent.Name}, Age = {agent.Age}, Commission Rate = {agent.CommissionRate}");
        }
    }
}