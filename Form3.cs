using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medicineManagement
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1E8M7R;Initial Catalog=Medicine_management;Integrated Security=True");
        public int medicineId;
        DataTable dt;
        private void Insert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Medicine values (@medicineName,@medicineCatagory,@medicineQuantity,@purchaseDate,@Cost)", con);
                    cmd.CommandType = CommandType.Text;

                    String cmbItemValue = catagory.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@medicineName", name.Text);
                    cmd.Parameters.AddWithValue("@medicineCatagory", cmbItemValue);
                    cmd.Parameters.AddWithValue("@medicineQuantity", quantity.Text);
                    cmd.Parameters.AddWithValue("@purchaseDate", this.dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Cost", cost.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine added successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getMedicineRecord();
                    ResetFormControls();
                }
            }
        }
        private bool IsValid()
        {
            if (name.Text == String.Empty)
            {
                MessageBox.Show("Medicine name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            getMedicineRecord();
        }

        private void getMedicineRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Medicine", con);
            dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void ResetFormControls()
        {
            medicineId = 0;
            name.Clear();
            quantity.Clear();
            cost.Clear();
            find.Clear();

            name.Focus();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Signin f1 = new Signin();
            f1.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (medicineId > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Medicine SET medicineName = @medicineName,medicineCatagory = @medicineCatagory,medicineQuantity = @medicineQuantity,purchaseDate = @purchaseDate,cost = @cost WHERE medicineId = @medicineId", con);
                    cmd.CommandType = CommandType.Text;
                    String cmbItemValue = catagory.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@medicineName", name.Text);
                    cmd.Parameters.AddWithValue("@medicineCatagory", cmbItemValue);
                    cmd.Parameters.AddWithValue("@medicineQuantity", quantity.Text);
                    cmd.Parameters.AddWithValue("@purchaseDate", this.dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Cost", cost.Text);
                    cmd.Parameters.AddWithValue("@medicineId", this.medicineId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getMedicineRecord();
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

        private void Full_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Seller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            medicineId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            catagory.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cost.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = String.Format("medicineName Like '%{0}%'", find.Text);
            dataGridView1.DataSource = dv;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void catagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
