using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace medicineManagement
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Full_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registration f6 = new Registration();
            f6.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                if (IsValid())
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1E8M7R;Initial Catalog=Medicine_management;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from [User] Where userName = '" + userName.Text + "' and Password = '" + Password.Text + "' ", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                      String cmbItemValue = userType.SelectedItem.ToString();
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["userType"].ToString() == cmbItemValue)
                            {
                                MessageBox.Show("You are Login as " + dt.Rows[i][5]);
                                if (userType.SelectedIndex == 0)
                                {
                                    Admin f2 = new Admin();
                                    f2.Show();
                                    this.Hide();
                                }
                                else if (userType.SelectedIndex == 1)
                                {
                                    Seller f3 = new Seller();
                                    f3.Show();
                                    this.Hide();
                                }
                                else if (userType.SelectedIndex == 2)
                                {
                                    Patient f4 = new Patient();
                                    f4.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    doctor f5 = new doctor();
                                    f5.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User name or Password is Wrong", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool IsValid()
        {
            if (userName.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
