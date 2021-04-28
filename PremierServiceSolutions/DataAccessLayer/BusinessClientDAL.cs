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
    class BusinessClientDAL
    {
        SqlConnection conn = new SqlConnection("Server= BAVHU\\SQLEXPRESS; Database = PremierServiceSolutionsDB; Trusted_Connection = true");


        public List<BusinessClient> GetAllBusinessClients()
        {
            List<BusinessClient> businessClients = new List<BusinessClient>();

            DataTable datatable = new DataTable();
            string query = $"SELECT * FROM BusinessClients ";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(datatable);
                foreach (DataRow row in datatable.Rows)
                {
                    BusinessClient businessClient = new BusinessClient();

                    businessClient.clientID = row["clientID"].ToString();
                    businessClient.CompanyName = row["CompanyName"].ToString();
                    businessClient.Phone = row["Phone"].ToString();
                    businessClient.Email = row["Email"].ToString();
                    businessClient.AddressID = row["AddressID"].ToString();
                    businessClient.ContractID = row["ContractID"].ToString();
                    businessClients.Add(businessClient);
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
            return businessClients;
        }
        public BusinessClient SearchBusinessClientByID(string id)
        {

            BusinessClient myClient = new BusinessClient();
            string query = $"SELECT * FROM BusinessClients WHERE ClientID = '{id}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        myClient.clientID = reader.GetString(0);
                        myClient.CompanyName = reader.GetString(1);
                        myClient.Phone = reader.GetString(2);
                        myClient.Email = reader.GetString(3);
                        myClient.AddressID = reader.GetString(4);
                        myClient.ContractID = reader.GetString(5);

                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return myClient;
        }

        

        public void InsertBusinessClient(BusinessClient client)
        {
            string query = $"insert into BusinessClients values" +
                $"('{client.clientID}', " +
                $"'{client.CompanyName}', " +
                $"'{client.Phone}', " +
                $"{client.Email}, " +
                $"'{client.AddressID}', " +
                $"'{client.ContractID}')";

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

        public void UpdateBusinessClient(BusinessClient client)
        {
            string query = $"update BusinessClients set " +
                $"ClientID = '{client.clientID}', " +
                $"CompanyName = '{client.CompanyName}', " +
                $"Phone = {client.Phone}, " +
                $"Email = '{client.Email}', " +
                $"AddressID = '{client.AddressID}', " +
                $"ContractID = '{client.ContractID}' where " +
                $"ClientID = '{client.clientID}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
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
