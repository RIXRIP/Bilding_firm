using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilding_firm
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            add_employee add_employee = new add_employee();
            add_employee.Show();
        }
    }
}
