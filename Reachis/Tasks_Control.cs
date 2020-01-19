using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Reachis
{
    public partial class Tasks_Control : UserControl
    {
        string NU;
       public string NumberUser
        {
            get { return NU; }
            set { NU = value; }
        }
        public Tasks_Control()
        {
            InitializeComponent();
            GetTask();
        }
        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        int poss = 10;
        public void Add_task(string Text, int Time, int TextPomo)
        {

            Task_items item = new Task_items(Text, Time, TextPomo);
            flowLayoutPanel_Tasks.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
            textBox_add_tasks.Clear();

        }

        public void Button_add_task_Click(object sender, EventArgs e)
        {
            countId += 1;
            string TaskName = textBox_add_tasks.Text;
            int TaskTime = 0;
            int TextPomo = countId;
            Add_task(TaskName, TaskTime, TextPomo); 
            AddTask(TaskName);
            textBox_add_tasks.Clear();

        }

        void GetTask()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");


            using (SQL)
            {
                SQL.Open();
              //SqlCommand command = new SqlCommand("SELECT * FROM TaskTabl WHERE Task_D='"+Convert.ToInt32(NU) +"'", SQL);
                SqlCommand command = new SqlCommand("SELECT * FROM TaskTabl", SQL);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Add_task("" + reader["TaskText"],Convert.ToInt32(reader["TaskTimeToday"]), Convert.ToInt32(reader["TaskID"]));
                            
                    }
                }
            }
        }

        int countId = 0;
        private void AddTask(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");
            SQL.Open();

            using (SQL)
            {
                
                SqlCommand commandSC = new SqlCommand("INSERT INTO TaskTabl (TaskText, TaskTimeToday, Task_D) VALUES ('" + insert +"', '"+0+"', '"+1+"') ", SQL);
                commandSC.ExecuteNonQuery();
            }
        }


        public void TextBox_add_tasks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                countId += 1;
                string TaskName = textBox_add_tasks.Text;
                int TaskTime = 0;
                int TextPomo = countId;
                Add_task(TaskName, TaskTime, TextPomo);
                AddTask(TaskName);
                textBox_add_tasks.Clear();
            }
        }

    }
}
