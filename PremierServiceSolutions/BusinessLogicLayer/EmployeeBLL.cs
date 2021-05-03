using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class EmployeeBLL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> data = new List<Employee>();
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                data = employeeData.GetAllEmployees();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
            return data;
        }
        public void InsertEmployee(Employee emp)
        {
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                employeeData.InsertEmployee(emp);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error EmployeeBLL {e.Message}");
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                employeeData.UpdateEmployee(emp);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
        }
        public void RemoveEmployee(Employee emp)
        {
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                employeeData.RemoveEmployee(emp);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
        }

        public List<string> GetTechnicians()
        {
            List<string> data = new List<string>();
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                data = employeeData.GetTechnicians();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
            return data;
        }

        public List<Employee> GetTechnicianDetails(Job Tecjob)
        {
            List<Employee> data = new List<Employee>();
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                data = employeeData.GetTechniciansDetails(Tecjob);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on EmployeeBLL {e.Message}");
            }
            return data;
        }


    }
}
