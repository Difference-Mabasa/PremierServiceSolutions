using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class Employee : Person
    {

        string employeeID, department;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Department { get => department; set => department = value; }

        public Employee()
        {
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
