using SVM_Webservice_Client.SVMWebservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Webservice_Client
{
    class SVM_WS_Handler
    {

        private ExportContestServicePortTypeClient stub;

        private ContestDTO[] contests;
        public ContestDTO[] Contests
        {
            get { return contests; }

            set
            {

                if (value != null)
                {

                    contests = value;
                }

                else
                {
                    contests = new ContestDTO[0];

                }

            }
        }

        private TeamDTO[] teams;
        public TeamDTO[] Teams
        {
            get
            {

                return teams;
            }

            set
            {

                teams = value;

            }
        }


        private MatchDTO[] matches;
        public MatchDTO[] Matches
        {
            get
            {


                return matches;

            }

            set
            {

                if (value != null)
                {

                    matches = value;
                }
                else
                {
                    matches = new MatchDTO[0];
                }

            }
        }


        public SVM_WS_Handler()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = Int32.MaxValue;
            binding.MaxBufferSize = Int32.MaxValue;

            stub = new ExportContestServicePortTypeClient("ExportContestServiceHttpSoap11Endpoint");
            

        }

        public void searchByDate(DateTime date)
        {

            Contests = stub.getListOfContestsByDate(date);

        }

        public void searchByTeam(String teamname)
        {
            foreach (var item in Teams)
            {
                if (item.name.Equals(teamname))
                {
                    Contests = stub.getListOfContestsByTeam(item.UID);
                    break;
                }
            }

        }

        public void getMatches(String contestName)
        {


            foreach (var item in Contests)
            {
                if (item.name.Equals(contestName))
                {
                    Matches = stub.getListOfMatches(item.UID);
                    break;
                }
            }

        }

        public void getTeams() {
            Teams = stub.getListOfTeams();
        }

    }
}
