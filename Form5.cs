using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medicineManagement
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1E8M7R;Initial Catalog=Medicine_management;Integrated Security=True");
        public int Id;
        DataTable dt;
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
        private bool IsValid()
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Medicine name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO MedicineInfo values (@genericName,@tradeName,@patientGroup,@doseLimit,@rootofAdministration,@Price)", con);
                    cmd.CommandType = CommandType.Text;

                    String cmbItemValue0 = group.SelectedItem.ToString();
                    String cmbItemValue1 = root.SelectedItem.ToString();

                     cmd.Parameters.AddWithValue("@genericName", textBox1.Text);
                     cmd.Parameters.AddWithValue("@tradeName", textBox2.Text);
                     cmd.Parameters.AddWithValue("@patientGroup", cmbItemValue0);
                     cmd.Parameters.AddWithValue("@doseLimit", Dose.Text);
                     cmd.Parameters.AddWithValue("@rootofAdministration", cmbItemValue1);
                     cmd.Parameters.AddWithValue("@Price", Price.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getMedicineInformation();
                    ResetFormControls();
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Signin f1 = new Signin();
            f1.Show();
            this.Hide();
        }

        private void Full_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Doctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            getMedicineInformation();
        }

        private void getMedicineInformation()
        {
            SqlCommand cmd = new SqlCommand("Select * from MedicineInfo", con);
            dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void ResetFormControls()
        {
            Id = 0;
            textBox1.Clear();
            textBox2.Clear();
            Dose.Clear();
            Price.Clear();

            textBox1.Focus();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Id > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE MedicineInfo SET genericName = @genericName,tradeName = @tradeName,patientGroup = @patientGroup,doseLimit = @doseLimit,rootofAdministration = @rootofAdministration,Price = @Price WHERE Id = @Id", con);
                    cmd.CommandType = CommandType.Text;
                    String cmbItemValue0 = group.SelectedItem.ToString();
                    String cmbItemValue1 = root.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@genericName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@tradeName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@patientGroup", cmbItemValue0);
                    cmd.Parameters.AddWithValue("@doseLimit", Dose.Text);
                    cmd.Parameters.AddWithValue("@rootofAdministration", cmbItemValue1);
                    cmd.Parameters.AddWithValue("@Price", Price.Text);
                    cmd.Parameters.AddWithValue("@Id", this.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine list Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getMedicineInformation();
                    ResetFormControls();
                    
                }
                else
                {
                    MessageBox.Show("please select a medicine", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Id > 0)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM MedicineInfo WHERE Id = @Id", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Id", this.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getMedicineInformation();
                    ResetFormControls();
                }
                else
                {
                    MessageBox.Show("please select a Medicine", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            group.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Dose.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            root.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Price.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = String.Format("genericName Like '%{0}%'", findg.Text);
            dataGridView1.DataSource = dv;
        }

        private void Findt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = String.Format("tradeName Like '%{0}%'", findt.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
