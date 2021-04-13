using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Teacher_info_insert_update_form
{
    public partial class teacher_info : Form
    {
        public teacher_info()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB;Integrated Security=True");
        public int teacherid;
        private void teacher_info_Load(object sender, EventArgs e)
        {
            GetTeacherRecords();
        }

        private void GetTeacherRecords()
        {
            
            SqlCommand cmd = new SqlCommand("select * from TeacherTb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            TeacherRecordGrid.DataSource = dt;
        }

        private void btn1_insert_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TeacherTb VALUES(@Name, @Subject, @Age, @City, @Salary, @phoneNo)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtbx1_tname.Text);
                cmd.Parameters.AddWithValue("@Subject", txtBx2_Sub.Text);
                cmd.Parameters.AddWithValue("@Age", txtBx3_age.Text);
                cmd.Parameters.AddWithValue("@City", txtBx4_city.Text);
                cmd.Parameters.AddWithValue("@Salary", txtBx5_sal.Text);
                cmd.Parameters.AddWithValue("@phoneNo", txtBx_phno.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New teacher information successully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTeacherRecords();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (txtbx1_tname.Text == string.Empty)
            {
                MessageBox.Show("Teacher name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
         
        }

        private void btn4_reset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            teacherid = 0;
            txtbx1_tname.Clear();
            txtBx2_Sub.Clear();
            txtBx3_age.Clear();
            txtBx4_city.Clear();
            txtBx5_sal.Clear();
            txtBx_phno.Clear();

            txtbx1_tname.Focus();
        }

        private void TeacherRecordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherid = Convert.ToInt32(TeacherRecordGrid.SelectedRows[0].Cells[0].Value);
            txtbx1_tname.Text = TeacherRecordGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtBx2_Sub.Text = TeacherRecordGrid.SelectedRows[0].Cells[2].Value.ToString();
            txtBx3_age.Text = TeacherRecordGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtBx4_city.Text = TeacherRecordGrid.SelectedRows[0].Cells[4].Value.ToString();
            txtBx5_sal.Text = TeacherRecordGrid.SelectedRows[0].Cells[5].Value.ToString();
            txtBx_phno.Text = TeacherRecordGrid.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btn2_update_Click(object sender, EventArgs e)
        {
            if(teacherid > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE TeacherTb SET Name = @Name, Subject = @Subject, Age = @Age, City = @City, Salary = @Salary, PhoneNo = @phoneNo WHERE teacher_ID = @ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtbx1_tname.Text);
                cmd.Parameters.AddWithValue("@Subject", txtBx2_Sub.Text);
                cmd.Parameters.AddWithValue("@Age", txtBx3_age.Text);
                cmd.Parameters.AddWithValue("@City", txtBx4_city.Text);
                cmd.Parameters.AddWithValue("@Salary", txtBx5_sal.Text);
                cmd.Parameters.AddWithValue("@phoneNo", txtBx_phno.Text);
                cmd.Parameters.AddWithValue("@ID", this.teacherid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Teacher information successully updated in the database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTeacherRecords();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select a row to update", "SELECT ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3_delete_Click(object sender, EventArgs e)
        {
           if ( teacherid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM TeacherTb WHERE teacher_ID = @ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.teacherid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Teacher information successully deleted from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTeacherRecords();
                ResetFormControls();
            }
           else
            {
                MessageBox.Show("Select a row to delete", "SELECT ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}