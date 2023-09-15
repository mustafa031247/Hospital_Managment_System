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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();


        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\DB_User.mdb");
        OleDbCommand cmd = new OleDbCommand();      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM UserTable WHERE UserName= '" + txtUserName.Text + "' and Passward= '" + txtPassward.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                MessageBox.Show("Login succesfully!!","Login Succesfully", MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_home frm_Home = new frm_home();
                frm_Home.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid username and Passward "," Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label5_Click(object sender, EventArgs e)
        {
         frm_Register fr = new frm_Register();
            fr.Show();
            this.Hide();
        }

        private void CheckbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassward.PasswordChar = '\0';
            }
            else
            {
                txtPassward.PasswordChar = '*';
            }
        }
    }
}
