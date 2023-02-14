using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace FlappyBird
{
    public partial class AucForm : Form
    {
        public static string PlayerName { get; set; }

        private SqlConnection SqlConnection1 = null;

        public AucForm()
        {
            InitializeComponent();
        }
        private void AucForm_Load(object sender, EventArgs e)
        {
            SqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["StrDB"].ConnectionString);

            SqlConnection1.Open();

            if (SqlConnection1.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR! \n @Code: 031 \n \nConnection error or incorrect configuration");
            }

        }

        private void EnterAuthData_MouseEnter(object sender, EventArgs e)
        {
            EnterAuthData.ForeColor = Color.DarkSlateGray;
        }

        private void EnterAuthData_MouseLeave(object sender, EventArgs e)
        {
            EnterAuthData.ForeColor = Color.Black;
        }





        private void EnterAuthData_Click(object sender, EventArgs e)
        {
            string loginfield = LoginL1.Text;
            string passwordfield = PasswordL1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tempTable = new DataTable();

            
            SqlCommand command = new SqlCommand("SELECT * FROM [UsersLogOn] WHERE [Login] = @loginfield AND [Password_key] = @passwordfield", SqlConnection1);
            command.Parameters.Add("@loginfield", SqlDbType.NVarChar).Value = loginfield;
            command.Parameters.Add("@passwordfield", SqlDbType.NVarChar).Value = passwordfield;

            adapter.SelectCommand = command;
            adapter.Fill(tempTable);

            if (tempTable.Rows.Count > 0)
            {
                PlayerName = LoginL1.Text;
                this.Hide();
                Form formcall = new MainMenuUI();
                formcall.Show();

            }
            else
            {
                tempTable.Clear();
                command = new SqlCommand("SELECT * FROM [UsersLogOn] WHERE [Login] = @loginfield", SqlConnection1);
                command.Parameters.Add("@loginfield", SqlDbType.NVarChar).Value = loginfield;
                adapter.SelectCommand = command;
                adapter.Fill(tempTable);
                if (tempTable.Rows.Count == 0)
                {
                    SqlCommand command1 = new SqlCommand("INSERT INTO UsersLogOn (Login, Password_key) VALUES (@Login, @Password_key)", SqlConnection1);
                    command1.Parameters.AddWithValue("Login", LoginL1.Text);
                    command1.Parameters.AddWithValue("Password_key", PasswordL1.Text);
                    PlayerName = LoginL1.Text;
                    command1.ExecuteNonQuery();
                    MessageBox.Show("New account registred");
                    this.Hide();
                    Form formcall = new MainMenuUI();
                   
                    formcall.Show();
                } else { MessageBox.Show("This login already used or your password incorrect"); }
            }
            
        }


        bool Temporary = false;
        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Temporary == false) { PasswordL1.UseSystemPasswordChar = false; Temporary = true; }
            else { PasswordL1.UseSystemPasswordChar = true; Temporary = false; }
        }

        private void AucForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
