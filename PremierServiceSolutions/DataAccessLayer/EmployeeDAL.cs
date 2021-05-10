using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{
    class EmployeeDAL
    {
        SqlConnection conn = DBAccess.GetSQLConnection();
        SqlCommand cmd;
        string query;

        public void InsertEmployee(Employee emp)
        {
            string query = $"insert into Employees(EmployeeID,EmployeeName,EmployeeSurname,Department,JobTitle,Phone,Email,EmployeePassword) values" +
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

        public void UpdateEmployee(Employee emp)
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
            //here we are returning the employees list which will contain all the emplyee records that we have
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
                    emp.Password = row["EmployeePassword"].ToString();
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

       
        public List<string> GetTechnicians()
        {
            DataTable datatable = new DataTable();
            List<string> lst = new List<string>();
            string query = $"SELECT EmployeeName FROM Employees where JobTitle = 'Technician'";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(datatable);
                foreach (DataRow item in datatable.Rows)
                {
                    lst.Add(item["EmployeeName"].ToString());
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
            return lst;
        }

        public List<Employee> GetTechniciansDetails(Job job)
        {
            DataTable datatable = new DataTable();
            List<Employee> lst = new List<Employee>();
            string query = $"SELECT * FROM Employees where JobTitle = 'Technician' AND EmployeeID = '{job.EmployeeID}'";

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
                    emp.Password = row["EmployeePassword"].ToString();
                    emp.Email = row["Email"].ToString();
                    emp.JobTitle = row["JobTitle"].ToString();
                    emp.AddressID = row["AddressID"].ToString();
                    lst.Add(emp);
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
            return lst;
        }
    }
}
