using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{
    class IndividualClientDAL
    {
        SqlConnection conn = new SqlConnection("Server= BAVHU\\SQLEXPRESS; Database = PremierServiceSolutionsDB; Trusted_Connection = true");


        public IndividualClient SearchIndividualClientByID(string id)
        {

            IndividualClient myClient = new IndividualClient();
            string query = $"SELECT * FROM IndividualClients WHERE ClientID = '{id}'";

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
                        myClient.Name = reader.GetString(1);
                        myClient.Surname = reader.GetString(2);
                        myClient.Phone = reader.GetString(3);
                        myClient.Email = reader.GetString(4);
                        myClient.AddressID = reader.GetString(5);
                        myClient.ContractID = reader.GetString(6);

                    }

                }

                else
                {
                    MessageBox.Show("No matches found");
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }

            return myClient;
        }

        public void InsertIndividualClient(IndividualClient client)
        {
            string query = $"insert into IndividualClients values" +
                $"('{client.clientID}', " +
                $"'{client.Name}', " +
                $"'{client.Surname}', " +
                $"{client.Phone}, " +
                $"'{client.Email}', " +
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

        public void UpdateIndividualClient(IndividualClient client)
        {
            string query = $"update IndividualClients set " +
                $"ClientID = '{client.clientID}', " +
                $"ClientName = '{client.Name}', " +
                $"ClientSurname = '{client.Surname}', " +
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
