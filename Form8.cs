using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicineManagement
{
    public partial class History : Form
    {
        public History(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Patient f4 = new Patient();
            f4.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void History_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
