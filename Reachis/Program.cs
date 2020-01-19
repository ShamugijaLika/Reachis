using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reachis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
#if DEBUG == false 
            String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // String dbPathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String dbPath = Path.Combine(dbPathMyDocs, "ReachisLocalData");
            AppDomain.CurrentDomain.SetData("DataDirectory", dbPath);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login logonForm = new Login();

            Application.Run(logonForm);

            
        }
    }
}

