using AgencySystem.BusinessLogic;
using AgencySystem.Models;



class Program
{
    static void Main(string[] args)
    {
        var agency = new AgencyFields();                            //this line is primarily about creating an instance of the
                                                                    //AgencyFields class to interact with its
                                                                    //methods and fields throughout application.




        UserChoices userChoices = new UserChoices(agency);                                                  // dependency injection.
        AgentManager agentManager = new AgentManager(userChoices);                                          //DI..  take a look at UserChoices.cs file.  (constructor)
        agentManager.ManageAgentAddition();

        InitializeClientsAndAgents(agency);

    }


    private static void InitializeClientsAndAgents(AgencyFields agency)
    {
        Person person1 = new Client(1, "John Doe", 24, 1700);


        if (person1 is Client client)
        {
            agency.AddClient(client);
        }

        Person person2 = new Agent(2, "Somebody", 45, 3);


        if (person2 is Agent agent)
        {
            agency.AddAgent(agent);
        }

        agency.DisplayList();
    }
}
