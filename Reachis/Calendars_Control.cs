using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reachis
{
    public partial class Calendars_Control : UserControl
    {
        public Calendars_Control()
        {
            InitializeComponent();
            GetTaskForCL();
        }

        int possCL = 10;
        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void Add_taskCL(string TextCL, int TimeCL, int textPomo)
        {
            Task_items itemCL = new Reachis.Task_items(TextCL, TimeCL, textPomo);
            panel_For_CL.Controls.Add(itemCL);
            itemCL.Top = possCL;
            possCL = (itemCL.Top + itemCL.Height + 10);


        }

        void GetTaskForCL()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");


            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TaskTabl", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Add_taskCL("" + reader["TaskText"], Convert.ToInt32(reader["TaskTimeToday"]), Convert.ToInt32(reader["TaskID"]));

                    }
                }
            }
        }
    }
}
