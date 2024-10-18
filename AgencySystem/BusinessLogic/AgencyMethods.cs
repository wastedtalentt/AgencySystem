using AgencySystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencySystem.BusinessLogic
{
    partial class AgencyFields
    {
        public void AddAgent(Agent agent)
        {
            if (agent != null && !agents.Any(a => a.Id == agent.Id))
            {
                agents.Add(agent);
            }
            else
            {
                Console.WriteLine("Agent with this ID already exists or is null.");
            }
        }

        public void RemoveAgent(Agent agent)
        {
            if (agent != null && agents.Contains(agent))
            {
                agents.Remove(agent);
            }
        }

        public void AddClient(Client client)
        {
            if (client != null && !clients.Contains(client))
            {
                clients.Add(client);
            }
        }

        public void RemoveClient(Client client)
        {
            if (!clients.Contains(client))
            {
                clients.Remove(client);
            }
        }

        public void DisplayList()
        {
            foreach (var agent in agents)
            {
                Console.WriteLine(agent);
            }
        }
    }
}
