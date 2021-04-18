using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class IndividualClientBLL
    {
        public IndividualClient GetIndividualClientByID(string id)
        {

            IndividualClientDAL clientData = new IndividualClientDAL();
            IndividualClient client = clientData.SearchIndividualClientByID(id);

            return client;
        }

        public List<Job> GetIndividualClientJosbsByClientID(string id)
        {
            IndividualClientDAL clientData = new IndividualClientDAL();
            List<Job> jobs = clientData.GetIndividualClientJobByClientID(id);

            return jobs;

            List<String> a;
        }
    }
}
