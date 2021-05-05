using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class IndividualClientCallReportsBLL
    {
        public List<Call> GetAllIndividualCallReports()
        {
            List<Call> data = new List<Call>();
            try
            {
                IndividualClientCallReportsDAL reports = new IndividualClientCallReportsDAL();
                data = reports.GetAllIndividualCallReports();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
            return data;
        }
    }
}
