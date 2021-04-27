using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions.DataAccessLayer;
using System.Windows.Forms;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class EmployeeBLL
    {
        public void InsertEmployee(Employee emp)
        {   
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                employeeData.InsertEmployee(emp);
            }
            catch(Exception e)
            {
                MessageBox.Show($"Error EmployeeBLL {e.Message}");
            }
        }
        
        public void UpdateEmployee(Employee emp)
        {
            try
            {
                EmployeeDAL employeeData = new EmployeeDAL();
                employeeData.UpdateEmployees(emp);
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
    }
}
