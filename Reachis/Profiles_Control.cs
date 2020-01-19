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
using System.Data.SqlTypes;

namespace Reachis
{
    public partial class Profiles_Control : UserControl
    {
        public Profiles_Control()
        {
            InitializeComponent();
            GetTaskForWL();
            label_Profile_Name.Text = NameUs;
            label_Profile_Email.Text = EmailUs;

        }
        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string NameUs, EmailUs;
        public string LabelName
        {
            set { NameUs = value; }
        }
        public string LabelEmail
        {
            set {EmailUs = value; }
        }

        public int UD;
        
        int possWL = 10;
        public void Add_taskWL(string Textwl, int Min)
        {
            WinList itemWL = new Reachis.WinList(Textwl, Min);
            panel_For_WL.Controls.Add(itemWL);
            itemWL.Top = possWL;
            possWL = (itemWL.Top + itemWL.Height + 10);


        }

        void GetTaskForWL()
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

                        Add_taskWL("" + reader["TaskText"], Convert.ToInt32(reader["TaskTimeToday"]));

                    }
                }
            }
        }

 
    }
}
