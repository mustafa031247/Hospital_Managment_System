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
    public partial class frm_Register : Form
   {
       public frm_Register()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassward.PasswordChar = '\0';
                txtConfirmPassward.PasswordChar = '\0';
            }
            else
            {
                txtPassward.PasswordChar = '*';
                txtConfirmPassward.PasswordChar = '*';
            }
        }
        private void Btnmain_Click(object sender, EventArgs e)
        {
            {
                frmlogin f1 = new frmlogin();
                f1.Show();
                this.Hide();
            }
        }

        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
        if (txtUserName.Text == "" && txtPassward.Text == "" && txtConfirmPassward.Text == "")
        {
            MessageBox.Show("UserName and Password Are Empty", "Registeration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (txtPassward.Text == txtConfirmPassward.Text)
        {
            string connection_string = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\DB_User.mdb";
            OleDbConnection con = new OleDbConnection(connection_string);
            con.Open();
            string query_register = " INSERT INTO UserTable(UserName, Passward) values('" + txtUserName.Text + "','" + txtPassward.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query_register, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtUserName.Text = " ";
            txtPassward.Text = " ";
            txtConfirmPassward.Text = " ";
            MessageBox.Show("Your Account Has Been Register SuccessFully", "Registration Sccuess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Password Doesn't Match Re-Enter your Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtPassward.Text = "";
            txtConfirmPassward.Text = "";
            txtPassward.Focus();
        }
    }
    }
}
