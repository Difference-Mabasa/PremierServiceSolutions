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

        public List<Call> GetIndividualCallReportsByClientID(String id)
        {
            IndividualClientCallReportsDAL data = new IndividualClientCallReportsDAL();
            List<Call> calls = data.GetIndividualClientCallReportsByClientID(id);

            return calls;
        }

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
                MessageBox.Show($"Error on GetAllIndividualCallReports BLL : {e.Message}");
            }
            return data;
        }

        public void InsertIndividualCallReport(Call call)
        {
            try
            {
                IndividualClientCallReportsDAL callreport = new IndividualClientCallReportsDAL();
                callreport.InsertIndividualCallReport(call);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on InsertIndividualCallReport BLL : {e.Message}");
            }
        }

        public int CountIndividualClientCallReports()
        {
            int total = 0;

            try
            {
                IndividualClientCallReportsDAL dal = new IndividualClientCallReportsDAL();
                total = dal.CountIndividualClientCallReports();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }


            return total;
        }
    }
}
