using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{

    class EmployeeDAL
    {
        SqlConnection conn = new SqlConnection("Server= (local); Database = PremierServiceSolutionsDB; Trusted_Connection = true");
        SqlCommand cmd;
        string query;
        public void InsertEmployee(Employee emp)
        {
            string query = $"insert into Employees(EmployeeID,EmployeeName,EmployeeSurname,Department,JobTitle,Phone,Email,Password) values" +
            $"('{emp.EmployeeID}', " +
            $"'{emp.Name}', " +
            $"'{emp.Surname}', " +
            $"'{emp.Department}', " +
            $"'{emp.JobTitle}', " +
            $"'{emp.Phone}', " +
            $"'{emp.Email}', " +
            $"'{emp.Password}')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        public void UpdateEmployees(Employee emp)
        {
            query = $"update Employees set " +
            $"EmployeeID = '{emp.EmployeeID}', " +
            $"EmployeeName = '{emp.Name}', " +
            $"EmployeeSurname = '{emp.Surname}', " +
            $"Department = '{emp.Department}', " +
            $"JobTitle = '{emp.JobTitle}', " +
            $"Phone = {emp.Phone}, " +
            $"Email = '{emp.Email}' " +
            $"WHERE EmployeeID = '{emp.EmployeeID}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
