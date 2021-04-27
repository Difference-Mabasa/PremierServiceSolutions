using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;
using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions
{
    class Employee : Person
    {

        string employeeID, department, password;
        string jobTitle;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Department { get => department; set => department = value; }
        public string Password { get => password; set => password = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public Employee()
        {
        }
        public Employee(string id, string password)
        {
            this.EmployeeID = id;
            this.Password = password;
        }
        public Employee(string id, string name, string surname, string phone, string department)
        {
            this.EmployeeID = id;
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.Department = department;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Regiter()
        {
            try
            {
                Employee employee = new Employee();
                this.EmployeeID = employee.EmployeeID;
                this.Name = employee.Name;
                this.Surname = employee.Surname;
                this.Department = employee.Department;
                this.JobTitle = employee.JobTitle;
                this.Phone = employee.Phone;
                this.Email = employee.Email;
                this.Password = employee.Password;

                EmployeeBLL employeeData = new EmployeeBLL();
                employeeData.InsertEmployee(employee);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on Employee Class: {e.Message}");
            }

        }
        //Returns false if employee details not found 
        public bool Login(string id, string password)
        {
            EmployeeDAL employeeData = new EmployeeDAL();
            List<Employee> employees = employeeData.GetAllEmployees();
            bool valid = false;
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeID.Equals(id) && emp.Password.Equals(password))
                {
                    valid = true;
                }
            }
            return valid;
        } 

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
