using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class BusinessClientCallReportsBLL
    {
        public List<Call> GetAllBusinessCallReports()
        {
            List<Call> data = new List<Call>();
            try
            {
                BusinessClientCallReportsDAL reports = new BusinessClientCallReportsDAL();
                data = reports.GetAllBusinessCallReports();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on GetAllBusinessCallReports BLL : {e.Message}");
            }
            return data;
        }

        public void InsertBusinessCallReport(Call call)
        {
            try
            {
                BusinessClientCallReportsDAL callreport = new BusinessClientCallReportsDAL();
                callreport.InsertBusinessCallReport(call);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on InsertBusinessCallReport BLL : {e.Message}");
            }
        }

        public int CountBusinessClientCallReports()
        {
            int total = 0;

            try
            {
                BusinessClientCallReportsDAL dal = new BusinessClientCallReportsDAL();
                total = dal.CountBusinessClientCallReports();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }


            return total;
        }
    }
}
