using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bilding_firm
{
    public partial class project : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        public project()
        {
            InitializeComponent();
        }

     

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_project_Click(object sender, EventArgs e)
        {
            addProject addProject = new addProject();
            addProject.Show();
        }

        private void project_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Bild"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM add_project   ", sqlConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataAddProj.DataSource = dataSet.Tables[0];

        }

        
    }
}
