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
    public partial class frm_Diagnosis : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\DB_User.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public frm_Diagnosis()
        {
            InitializeComponent();
        }
       public void veiw_method()
        {
            con.Open();
            diagnosis obj = new diagnosis( "SELECT * from DiagnosisTable");
            OleDbDataAdapter da = new OleDbDataAdapter(obj.qry_select, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_diagnosis.DataSource = ds.Tables[0];
            con.Close();
        }
       public void veiw_patient_id_combo()
        {
            patient view = new patient("SELECT * from PatientTable");
            cmd = new OleDbCommand(view.qry_select, con);
            OleDbDataReader rd;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientID", typeof(string));
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                comboBox_patient_diagnosis.ValueMember = "PatientID";
                comboBox_patient_diagnosis.DataSource = dt;
                con.Close();
            }
            catch { 

            }
        }
        string patient_name;
       public void insert_patient_name()
        {
            string qry_insert = "SELECT * from PatientTable WHERE PatientID = ?";
            cmd = new OleDbCommand(qry_insert, con);
            cmd.Parameters.Add("Para", OleDbType.Integer).Value = comboBox_patient_diagnosis.SelectedValue.ToString();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patient_name = dr["PatientName"].ToString();
                textBox_patient_name.Text = patient_name;
            }
            con.Close();
        }

        private void frm_Diagnosis_Load(object sender, EventArgs e)
        {
            veiw_patient_id_combo();
            diagnosis Empty2 = new diagnosis();
            Empty2.Empty_text_field(textBox_diagnosis_id.Text = "");
            Empty2.Empty_text_field(textBox_symptoms.Text = "", textBox_diagnosis.Text+"",textBox_medicine.Text = "",textBox_doctor_fee.Text = "");
        }
        private void btn_diagnosis_add_Click(object sender, EventArgs e)

           
        {
            if (textBox_diagnosis.Text == "" || textBox_diagnosis_id.Text == "" || textBox_patient_name.Text == "" || textBox_symptoms.Text == "" || textBox_diagnosis.Text == "" || textBox_medicine.Text == "" || textBox_doctor_fee.Text == "")
            {
                MessageBox.Show("Error", "Empty Field Are not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string qry_add = "INSERT INTO DiagnosisTable(DiagnosisID, PatientName, PatientDiagnosis, Symptoms, Diagnosis, Medicine, DoctorFee) values("+textBox_diagnosis_id.Text+" , '" +textBox_patient_name.Text+"' , '"+ comboBox_patient_diagnosis.SelectedValue.ToString()+"' , '"+textBox_symptoms.Text+"' , '"+textBox_diagnosis.Text+"' , '"+textBox_medicine.Text +"' , '"+textBox_doctor_fee.Text+"')";
                cmd = new OleDbCommand(qry_add, con);
                cmd.ExecuteNonQuery();
                con.Close();
                veiw_method();
                diagnosis Empty2 = new diagnosis();
                Empty2.Empty_text_field(textBox_diagnosis_id.Text = "");
                Empty2.Empty_text_field(textBox_symptoms.Text = "", textBox_diagnosis.Text + "", textBox_medicine.Text = "", textBox_doctor_fee.Text = "");
            }
        }

        private void btn_diagnosis_delete_Click(object sender, EventArgs e)
        {
            if (textBox_diagnosis_id.Text == "")
            {
                MessageBox.Show("Error", "Enter Diagnosis ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                string qry_delete = "DELETE from DiagnosisTable WHERE DiagnosisID = ?";
                cmd = new OleDbCommand(qry_delete, con);
                cmd.Parameters.Add("Parameter2", OleDbType.Integer).Value = textBox_diagnosis_id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Delete SucessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                veiw_method();
                diagnosis Empty2 = new diagnosis();
                Empty2.Empty_text_field(textBox_diagnosis_id.Text = "");
                Empty2.Empty_text_field(textBox_symptoms.Text = "", textBox_diagnosis.Text + "", textBox_medicine.Text = "", textBox_doctor_fee.Text = "");
            }
        }

        private void dataGridView_diagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_diagnosis_id.Text = dataGridView_diagnosis.SelectedRows[0].Cells[0].Value.ToString();
           textBox_patient_name.Text = dataGridView_diagnosis.SelectedRows[0].Cells[1].Value.ToString(); 
            comboBox_patient_diagnosis.SelectedValue = dataGridView_diagnosis.SelectedRows[0].Cells[2].Value.ToString();
            textBox_symptoms.Text = dataGridView_diagnosis.SelectedRows[0].Cells[3].Value.ToString();
            textBox_diagnosis.Text = dataGridView_diagnosis.SelectedRows[0].Cells[4].Value.ToString();
            textBox_medicine.Text = dataGridView_diagnosis.SelectedRows[0].Cells[5].Value.ToString();
            textBox_doctor_fee.Text = dataGridView_diagnosis.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_diagnosis_home_Click(object sender, EventArgs e)
        {
            frm_home frm_Home = new frm_home();
            frm_Home.Show();
            this.Hide();
           
        }

        private void btn_diagnosis_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry_update = "UPDATE DiagnosisTable set  Symptoms= '" + textBox_symptoms.Text + "' ,Diagnosis= '" + textBox_diagnosis.Text + "' ,Medicine = '" + textBox_medicine.Text + "',DoctorFee = '" + textBox_doctor_fee.Text + "' WHERE DiagnosisID = ?";
            cmd = new OleDbCommand(qry_update, con);
            cmd.Parameters.Add("Parameter2", OleDbType.Integer).Value = textBox_diagnosis_id.Text; 
            cmd.ExecuteNonQuery();
            con.Close();
            veiw_method();
            diagnosis Empty2 = new diagnosis();
            Empty2.Empty_text_field(textBox_diagnosis_id.Text = "");
            Empty2.Empty_text_field(textBox_symptoms.Text = "", textBox_diagnosis.Text + "", textBox_medicine.Text = "", textBox_doctor_fee.Text = "");
        }
        private void ComboBox_patient_diagnosis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            insert_patient_name();
        }
    }
}
