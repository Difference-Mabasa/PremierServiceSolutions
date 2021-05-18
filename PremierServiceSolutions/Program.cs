using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

using PremierServiceSolutions.PresentationLayer.CallCentre;
using PremierServiceSolutions.PresentationLayer.ContractMaintanance;
using PremierServiceSolutions.PresentationLayer.ServiceDapartment;
using PremierServiceSolutions.PresentationLayer.ClientMaintanance;
using PremierServiceSolutions.PresentationLayer.CallCentre;

namespace PremierServiceSolutions
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CallCentre());
        }
    }
}
