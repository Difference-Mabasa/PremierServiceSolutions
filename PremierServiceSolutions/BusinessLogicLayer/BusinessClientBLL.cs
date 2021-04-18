using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class BusinessClientBLL
    {
        public BusinessClient GetBusinessClientByID(string id)
        {
            BusinessClientDAL clientData = new BusinessClientDAL();
            BusinessClient client = clientData.SearchBusinessClientByID(id);

            return client;
        }

        public List<Job> GetBusinessClientJosbsByClientID(string id)
        {
            BusinessClientDAL clientData = new BusinessClientDAL();
            List<Job> jobs = clientData.GetBusinessClientJobByClientID(id);

            return jobs;

        }
    }
}
