using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;
using PremierServiceSolutions.DataAccessLayer;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PremierServiceSolutions
{

    [Serializable]

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
                employee.EmployeeID = this.EmployeeID;
                employee.Name = this.Name;
                employee.Surname = this.Surname;
                employee.Department = this.Department;
                employee.JobTitle = this.JobTitle;
                employee.Phone = this.Phone;
                employee.Email = this.Email;
                employee.Password = this.Password;

                //EmployeeBLL employeeData = new EmployeeBLL();
                //employeeData.InsertEmployee(employee);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on Employee Class: {e.Message}");
            }

        }
        //Returns false if employee details not found

        //public bool Login(string id, string password)
        //{
        //    EmployeeDAL employeeData = new EmployeeDAL();
        //    List<Employee> employees = employeeData.GetAllEmployees();
        //    bool valid = false;
        //    foreach (Employee emp in employees)
        //    {
        //        if (emp.EmployeeID.Equals(id) && emp.Password.Equals(password))
        //        {
        //            valid = true;
        //        }
        //    }
        //    return valid;
        //}

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        
    }
}
