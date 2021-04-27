using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PremierServiceSolutions.DataAccessLayer
{
    //Employee Data access Class
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

        public void RemoveEmployee(Employee emp)
        {
            string query = $"DELETE FROM Employees WHERE EmployeeID = '{emp.EmployeeID}'";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");
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

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            DataTable datatable = new DataTable();
            string query = $"SELECT * FROM Employees ";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(datatable);
                foreach (DataRow row in datatable.Rows)
                {
                    Employee emp = new Employee();
                    emp.EmployeeID = row["EmployeeID"].ToString();
                    emp.Name = row["EmployeeName"].ToString();
                    emp.Surname = row["EmployeeSurname"].ToString();
                    emp.Phone = row["Phone"].ToString();
                    emp.Department = row["EmployeeSurname"].ToString();
                    emp.Password = row["Password"].ToString();
                    emp.Email = row["Email"].ToString();
                    emp.JobTitle = row["JobTitle"].ToString();
                    emp.AddressID = row["AddressID"].ToString();
                    employees.Add(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return employees;
        }
    }
}
