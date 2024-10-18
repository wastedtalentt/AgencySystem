using AgencySystem.BusinessLogic;

namespace AgencySystem.BusinessLogic
{
    partial class AgencyFields
    {
        private List<Agent> agents;
        private List<Client> clients;

        public AgencyFields()
        {
            agents = new List<Agent>();  // Initialize to avoid null reference
            clients = new List<Client>();
        }

    }
}
