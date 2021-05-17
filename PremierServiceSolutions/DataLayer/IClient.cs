using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{

    interface IClient
    {
        string clientID { get; set; }
        void sendRequest();

        string GenerateClientID();


    }
}
