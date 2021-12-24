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
    public partial class add_employee : Form
    {
        public add_employee()
        {
            InitializeComponent();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff staff = new staff();
            staff.Show();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void add_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
