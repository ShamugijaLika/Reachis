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
    public partial class Task_items : UserControl
    {
        public Turtl trtl;
        public string TimeOverID;

        public Task_items()
        {
            InitializeComponent();
        }

        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Task_items(string text, int time, int textPomo)
        {
            InitializeComponent();
            label_add_task.Text = text;
            label_TimeToday.Text = time.ToString();
            string TP = textPomo.ToString();
            Button_Pomodoro.Text = TP;
        }
        
        public void Button_Pomodoro_Click(object sender, EventArgs e)
        {

            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT TaskID FROM TaskTabl WHERE TaskID='"+ Button_Pomodoro.Text+"'", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TimeOverID = ""+ (reader["TaskID"]);
                    }
                }
             }
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;

            trtl = new Turtl
            {
                Mylabel = TimeOverID
            };
            trtl.Show();

        }

        private void Button_del_task_Click(object sender, EventArgs e)
        {

            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TaskTabl WHERE TaskText = '" + label_add_task.Text + "'", SQL);

                command.ExecuteNonQuery();
            }
            this.BackColor = Color.FromArgb(255, 188, 27);
            label_add_task.Text = "Deleted";

        }

    }
}
