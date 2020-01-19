using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Reachis
{
    public partial class Login : Form
    {
        public Profiles_Control PrCont;
         public Form1 UserID_ForForm1;
        public Login()
        {
            InitializeComponent();
            IsAuthen = false;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public bool IsAuthen;
        public string Uname, Uemail;
        public string ForID;
  
        public void Button_Sign_Click(object sender, EventArgs e)
        {
            string uname = textBox_UserName.Text;
            string upass = textBox_Password.Text;
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM UserTable WHERE UserName=@Name and UserPassword=@Pass", SQL);
                command.Parameters.AddWithValue("@Name", uname);
                command.Parameters.AddWithValue("@Pass", upass);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ForID = Convert.ToString(reader["UserID"]);

                }
                if (reader.HasRows)
                {
                    IsAuthen = true;
                    Profile(uname);                  
                }
                else IsAuthen = false;

            }


            if (IsAuthen == true)
                {
                UserID_ForForm1 = new Form1
                {
                    NumberUserForForm1 = ForID.ToString()
                };
                this.Hide();
                    UserID_ForForm1.Show();

                PrCont = new Profiles_Control
                {
                    LabelEmail = Uemail,
                    LabelName = Uname
                };
            }
                else { MessageBox.Show("Проверьте корректность данных"); }
            SQL.Close();
        }

        public void Profile(string UserText)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT UserName,UserEmail FROM UserTable WHERE UserName='" + UserText + "'", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Uname = "" + (reader["UserName"]);
                        Uemail = "" + (reader["UserEmail"]);
                    }
                }
            }
        }
        private void TextBox_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_UserName.Clear();
        }

        private void TextBox_Password_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Password.Clear();
        }

        private void TextBox_email_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_email.Clear();
        }

        private void Button_Registr_Click(object sender, EventArgs e)
        {
            AddUser(textBox_UserName.Text, textBox_Password.Text, textBox_email.Text);

        }

        void AddUser(string UName, string UPass, string UEmail)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();

                SqlCommand commandSC = new SqlCommand("INSERT INTO UserTable(UserName, UserPassword, UserEmail) VALUES(@name, @pass, @email)", SQL);
                commandSC.Parameters.AddWithValue("@name", UName);
                commandSC.Parameters.AddWithValue("@pass", UPass);
                commandSC.Parameters.AddWithValue("@email", UEmail);
                commandSC.ExecuteNonQuery();
              //  SQL.Close();
            }
             
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    }
}
