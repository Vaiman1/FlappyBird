using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlappyBird
{
    
    public partial class Scores : Form
    {
        private SqlConnection connection = null;
        public Scores()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Result] ORDER BY [Result]", connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                break;
                
                case 0:
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM [Result] WHERE [Name] = @search ORDER BY [Result]", connection);
                    adapter1.SelectCommand.Parameters.AddWithValue("@search", AucForm.PlayerName);
                    DataSet dataSet1 = new DataSet();
                    adapter1.Fill(dataSet1);
                    dataGridView1.DataSource = dataSet1.Tables[0];
                break;

            }

        }

        private void Scores_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StrDB"].ConnectionString);
            connection.Open();
            comboBox1.SelectedIndex = 0;
        }

        private void Scores_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuUI f = new MainMenuUI();
            f.Show();
        }
    }
}
