using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class frm_Doctor : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\DB_User.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public frm_Doctor()
        {
            InitializeComponent();
        }
       public void veiw_method()
        {
            con.Open();
            doctor view = new doctor("SELECT * from DoctorTable");
            OleDbDataAdapter da = new OleDbDataAdapter(view.qry_select, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_dctr.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btn_dctr_home_Click(object sender, EventArgs e)
        {
            frm_home frm_Home = new frm_home();
            frm_Home.Show();
            this.Hide();
        }

        private void btn_dctr_add_Click(object sender, EventArgs e)
        {
            if (textBox_dctr_id.Text == " " || textBox_dctr_name.Text == " " || textBox_dctr_cnic.Text == " " || textBox_dctr_year_of_ex.Text == " ")
            {
                MessageBox.Show("Error", "No Empty Field Accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string add = "INSERT INTO DoctorTable(DoctorID, DoctorName, CNIC, ExpiryDate) values (" + textBox_dctr_id.Text + " , '" + textBox_dctr_name.Text + "' , '" + textBox_dctr_cnic.Text + "' , '" + textBox_dctr_year_of_ex.Text + "')";
                cmd = new OleDbCommand(add, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "Doctor Information Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                doctor Empty3 = new doctor();
                Empty3.Empty_fields(textBox_dctr_id.Text = "");
                Empty3.Empty_fields(textBox_dctr_name.Text = "", textBox_dctr_cnic.Text = "", textBox_dctr_year_of_ex.Text = "");
                veiw_method();
            }
        }
        private void frm_Doctor_Load(object sender, EventArgs e)
        {
            veiw_method();
        }
        private void btn_dctr_delete_Click(object sender, EventArgs e)
        {
            if (textBox_dctr_id.Text == "")
            {
                MessageBox.Show("Enter The Doctor ID" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string qry_delete = "DELETE from DoctorTable WHERE DoctorID=?";
                cmd = new OleDbCommand(qry_delete, con);
                cmd.Parameters.Add("Parameter3", OleDbType.Integer).Value = textBox_dctr_id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information!" , "Delete SuccessFully" ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                con.Close();
                doctor Empty3 = new doctor();
                Empty3.Empty_fields(textBox_dctr_id.Text = "");
                Empty3.Empty_fields(textBox_dctr_name.Text = "", textBox_dctr_cnic.Text = "", textBox_dctr_year_of_ex.Text = "");
                veiw_method();
            }           
        }     
        private void dataGridView_dctr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_dctr_id.Text = dataGridView_dctr.SelectedRows[0].Cells[0].Value.ToString();
            textBox_dctr_name.Text = dataGridView_dctr.SelectedRows[0].Cells[1].Value.ToString();
            textBox_dctr_cnic.Text = dataGridView_dctr.SelectedRows[0].Cells[2].Value.ToString();
            textBox_dctr_year_of_ex.Text = dataGridView_dctr.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void btn_dctr_update_Click(object sender, EventArgs e)
        {
            if (textBox_dctr_id.Text == "")
            {
                MessageBox.Show("Enter The Doctor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string qry_update = "UPDATE DoctorTable set DoctorName = '" + textBox_dctr_name.Text + "' ,ExpiryDate = '" + textBox_dctr_year_of_ex.Text + "' ,CNIC = '" + textBox_dctr_cnic.Text + "' WHERE DoctorID =  ?";
                cmd = new OleDbCommand(qry_update, con);
                cmd.Parameters.Add("Parameter3", OleDbType.Integer).Value = textBox_dctr_id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update SuccessFully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                doctor Empty3 = new doctor();
                Empty3.Empty_fields(textBox_dctr_id.Text = "");
                Empty3.Empty_fields(textBox_dctr_name.Text = "", textBox_dctr_cnic.Text = "", textBox_dctr_year_of_ex.Text = "");
                veiw_method();
            }           
        }
    }
}
