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
    public partial class addProject : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        public addProject()
        {
            InitializeComponent();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProject_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Bild"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void SaveProj_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [add_project](name_proj,responsible_person,type_object,site_address,start_time,end_time) " +
                $"VALUES (@name_proj,@responsible_person,@type_object,@site_address,@start_time,@end_time)", sqlConnection);

            DateTime start_time = DateTime.Parse(TimeStart.Text);
            DateTime end_time = DateTime.Parse(EndTime.Text);

            command.Parameters.AddWithValue("name_proj", NameProj.Text);
            command.Parameters.AddWithValue("responsible_person", responsible_person.Text);
            command.Parameters.AddWithValue("type_object",TypeObj.Text);
            command.Parameters.AddWithValue("site_address", site_address.Text);
            command.Parameters.AddWithValue("start_time", $"{start_time.Month}/{start_time.Day}/{start_time.Year}");
            command.Parameters.AddWithValue("end_time", $"{end_time.Month}/{end_time.Day}/{end_time.Year}");
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

       
    }
}
