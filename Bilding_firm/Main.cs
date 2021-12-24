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

namespace Bilding_firm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            project project = new project();
            project.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            clients clients = new clients();
            clients.Show();
        }

        private void buttonStuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff staff = new staff();
            staff.Show();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            suplliers suppliers = new suplliers();
            suppliers.Show();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
