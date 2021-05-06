using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PremierServiceSolutions.BusinessLogicLayer
{

    [Serializable]

    class ObjectSerializer
    {   
        public void SerializeEmployee(Employee employee)
        {

            string path = "C:\\Users\\Public\\Documents\\PSSData\\Employee.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(s, employee);

            s.Close();

        }

        public Employee DeSerializeEmployee()
        {
            string path = "C:\\Users\\Public\\Documents\\PSSData\\Employee.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);

            Employee employee = (Employee)formatter.Deserialize(s);

            return employee;
        }

        public void SerializeCall(Call call)
        {

            string path = "C:\\Users\\Public\\Documents\\PSSData\\Call.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(s, call);

            s.Close();

        }

        public Call DeSerializeCall()
        {
            string path = "C:\\Users\\Public\\Documents\\PSSData\\Call.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);

            Call call = (Call)formatter.Deserialize(s);

            return call;
        }

        public void SerializeIndividualClient(IndividualClient individualClient)
        {

            string path = "C:\\Users\\Public\\Documents\\PSSData\\Caller.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(s, individualClient);

            s.Close();

        }

        public IndividualClient DeSerializeIndividualClient()
        {
            string path = "C:\\Users\\Public\\Documents\\PSSData\\Caller.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);

            IndividualClient individualClient = (IndividualClient)formatter.Deserialize(s);

            return individualClient;
        }

        public void SerializeBusinessClient(BusinessClient businessClient)
        {

            string path = "C:\\Users\\Public\\Documents\\PSSData\\Caller.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(s, businessClient);

            s.Close();

        }

        public BusinessClient DeSerializeBusinessClient()
        {
            string path = "C:\\Users\\Public\\Documents\\PSSData\\Caller.dat";
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);

            BusinessClient businessClient = (BusinessClient)formatter.Deserialize(s);

            return businessClient;
        }
    }
}
