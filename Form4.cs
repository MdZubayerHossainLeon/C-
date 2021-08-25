using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medicineManagement
{
    public partial class Patient : Form
    {
        DataTable myDt;
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1E8M7R;Initial Catalog=Medicine_management;Integrated Security=True");
        public int serialNo;
        public int serialNoh;
        public String Period;
        public String mealTime;

        private void Set_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Patient values (@drugName,@startDate,@chooseDay,@mealTime,@Period)", con);
                    cmd.CommandType = CommandType.Text;

                    String cmbItemValue = chooseday.SelectedItem.ToString();

                     cmd.Parameters.AddWithValue("@drugName", textBox1.Text);
                     cmd.Parameters.AddWithValue("@startDate", this.dateTimePicker1.Text);
                     cmd.Parameters.AddWithValue("@chooseDay",cmbItemValue);
                     cmd.Parameters.AddWithValue("@mealTime", mealTime);
                     cmd.Parameters.AddWithValue("@Period", Period);

                    SqlCommand cmdh = new SqlCommand(@"INSERT INTO History values (@drugNameh,@startDateh,@chooseDayh,@mealTimeh,@Periodh)", con);
                    cmdh.CommandType = CommandType.Text;

                    cmdh.Parameters.AddWithValue("@drugNameh", textBox1.Text);
                    cmdh.Parameters.AddWithValue("@startDateh", this.dateTimePicker1.Text);
                    cmdh.Parameters.AddWithValue("@chooseDayh", cmbItemValue);
                    cmdh.Parameters.AddWithValue("@mealTimeh", mealTime);
                    cmdh.Parameters.AddWithValue("@Periodh", Period);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmdh.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Plan made successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getPatientRecord();
                    ResetFormControls();
                    getHistory();
                }
            }

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
        private void Patient_Load(object sender, EventArgs e)
        {
            getPatientRecord();
            getHistory();
        }

        private void getHistory()
        {
            SqlCommand cmd = new SqlCommand("Select * from History", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            myDt = dt;
        }

        private void getPatientRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Patient", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }
        private void ResetFormControls()
        {
            serialNo = 0;
            textBox1.Clear();

            textBox1.Focus();

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Period = "Before";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Period = "After";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Signin f1 = new Signin();
            f1.Show();
            this.Hide();
        }


        private void History_Click(object sender, EventArgs e)
        {
            History f8 = new History(myDt);
            f8.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (serialNo > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Patient SET drugName = @drugName,startDate = @startDate,chooseDay = @chooseDay,mealTime = @mealTime,Period = @Period WHERE serialNo = @serialNo", con);
                    cmd.CommandType = CommandType.Text;
                    String cmbItemValue = chooseday.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@drugName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@startDate", this.dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@chooseDay", cmbItemValue);
                    cmd.Parameters.AddWithValue("@mealTime", mealTime);
                    cmd.Parameters.AddWithValue("@Period", Period);
                    cmd.Parameters.AddWithValue("@serialNo", this.serialNo);

                    SqlCommand cmdh = new SqlCommand("UPDATE History SET drugNameh = @drugNameh,startDateh = @startDateh,chooseDayh = @chooseDayh,mealTimeh = @mealTimeh,Periodh = @Periodh WHERE serialNoh = @serialNoh", con);
                    cmdh.CommandType = CommandType.Text;

                    cmdh.Parameters.AddWithValue("@drugNameh", textBox1.Text);
                    cmdh.Parameters.AddWithValue("@startDateh", this.dateTimePicker1.Text);
                    cmdh.Parameters.AddWithValue("@chooseDayh", cmbItemValue);
                    cmdh.Parameters.AddWithValue("@mealTimeh", mealTime);
                    cmdh.Parameters.AddWithValue("@Periodh", Period);
                    cmdh.Parameters.AddWithValue("@serialNoh", this.serialNoh);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmdh.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Plan Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getPatientRecord();
                    ResetFormControls();
                    getHistory();
                }
                else
                {
                    MessageBox.Show("please select a Patient", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (serialNo > 0)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE serialNo = @serialNo", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@serialNo", this.serialNo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Plan Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getPatientRecord();
                    ResetFormControls();
                }
                else
                {
                    MessageBox.Show("please select a Patient", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serialNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            chooseday.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            mealTime = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Period = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Patient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            mealTime = "Dinner";
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            mealTime = "Lunch";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            mealTime = "Breakfast";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
