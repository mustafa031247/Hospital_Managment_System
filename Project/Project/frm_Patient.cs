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
    public partial class frm_Patient : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\DB_User.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public frm_Patient()
        {
            InitializeComponent();
        }
      public void veiw_method()
        {
            con.Open();
            patient obj = new patient("SELECT * from PatientTable");
            OleDbDataAdapter da = new OleDbDataAdapter(obj.qry_select, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_patient.DataSource = ds.Tables[0];
            con.Close();
        } 
        private void btn_dctr_home_Click(object sender, EventArgs e)
        {
            frm_home frm_Home = new frm_home();
            frm_Home.Show();
            this.Hide();
        }

        private void btn_patient_add_Click(object sender, EventArgs e)
        {
            if (textBox_patient_id.Text == "" || textBox_patient_name.Text == "" || textBox_patient_address.Text == "" || textBox_patient_phone.Text == "" || textBox_patient_age.Text == "" || textBox_patient_major_disease.Text == "")
            {
                MessageBox.Show("Error", "Empty Field Are not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string qry_add = " INSERT INTO PatientTable(PatientID,PatientName, PatientAddress,PatientPhone,PatientAge,PatientGender,PatientBloodgrp,PatientDisease) values (" + textBox_patient_id.Text + " , '" + textBox_patient_name.Text + "' , '" + textBox_patient_address.Text + "' , '" + textBox_patient_phone.Text + "' , '" + textBox_patient_age.Text + "' , '" + comboBox_patient_gender.SelectedItem.ToString() + "' , '" + comboBox_patient_blood_grp.SelectedItem.ToString() + "' ,'" + textBox_patient_major_disease.Text + "')";
                cmd = new OleDbCommand(qry_add, con);
                cmd.ExecuteNonQuery();
                con.Close();
                veiw_method();
                patient empty1 = new patient();
                empty1.Empty_text_field(textBox_patient_id.Text = "", textBox_patient_name.Text = "", textBox_patient_address.Text = "");
                empty1.Empty_text_field(textBox_patient_phone.Text = "", textBox_patient_age.Text = "", comboBox_patient_gender.Text ="", comboBox_patient_blood_grp.Text  = "",textBox_patient_major_disease.Text = "");
            }
        }
                private void dataGridView_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_patient_id.Text = dataGridView_patient.SelectedRows[0].Cells[0].Value.ToString();
            textBox_patient_name.Text = dataGridView_patient.SelectedRows[0].Cells[1].Value.ToString();
            textBox_patient_address.Text = dataGridView_patient.SelectedRows[0].Cells[2].Value.ToString();
            textBox_patient_phone.Text = dataGridView_patient.SelectedRows[0].Cells[3].Value.ToString();
            textBox_patient_age.Text = dataGridView_patient.SelectedRows[0].Cells[4].Value.ToString();
            comboBox_patient_gender.SelectedItem = dataGridView_patient.SelectedRows[0].Cells[5].Value.ToString();
            comboBox_patient_blood_grp.SelectedItem = dataGridView_patient.SelectedRows[0].Cells[6].Value.ToString();
            textBox_patient_major_disease.Text = dataGridView_patient.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void frm_Patient_Load(object sender, EventArgs e)
        {
            veiw_method();
        }

        private void btn_patient_delete_Click(object sender, EventArgs e)
        {
            if (textBox_patient_id.Text == "")
            {
                MessageBox.Show("Error","Enter Patient ID", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string qry_delete = "DELETE from PatientTable Where PatientID = ?";
                cmd = new OleDbCommand(qry_delete, con);
                cmd.Parameters.Add("Parameter1", OleDbType.Integer).Value = textBox_patient_id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully", "Delete SuccessFully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                veiw_method();
                patient empty1 = new patient();
                empty1.Empty_text_field(textBox_patient_id.Text = "", textBox_patient_name.Text = "", textBox_patient_address.Text = "");
                empty1.Empty_text_field(textBox_patient_phone.Text = "", textBox_patient_age.Text = "", comboBox_patient_gender.Text = "", comboBox_patient_blood_grp.Text = "", textBox_patient_major_disease.Text = "");


            }
        }

        private void btn_patient_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry_update = "UPDATE PatientTable set PatientName = '" + textBox_patient_name.Text + "' , PatientAddress = '" + textBox_patient_address.Text + "' ,PatientPhone = '" + textBox_patient_phone.Text + "' ,PatientGender = '" + comboBox_patient_gender.SelectedItem + "' ,PatientBloodgrp = '" + comboBox_patient_blood_grp.SelectedItem + "' ,PatientDisease = '" + textBox_patient_major_disease.Text + "' ,PatientAge = '"+textBox_patient_age.Text+"' WHERE PatientID = ?";
            cmd = new OleDbCommand(qry_update, con);
            cmd.Parameters.Add("Parameter2", OleDbType.Integer).Value = textBox_patient_id.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            veiw_method();
            patient empty1 = new patient();
            empty1.Empty_text_field(textBox_patient_id.Text = "", textBox_patient_name.Text = "", textBox_patient_address.Text = "");
            empty1.Empty_text_field(textBox_patient_phone.Text = "", textBox_patient_age.Text = "", comboBox_patient_gender.Text = "", comboBox_patient_blood_grp.Text = "", textBox_patient_major_disease.Text = "");
        }
    }
}
