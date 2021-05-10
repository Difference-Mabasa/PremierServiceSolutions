﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PremierServiceSolutions.DataAccessLayer
{
    class DBAccess
    {
        public static SqlConnection GetSQLConnection()
        {
            String connectionString = "Data Source = (local); Initial Catalog = master; Integrated Security = SSPI";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}