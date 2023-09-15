using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Properties;

namespace Project
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }    
        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();

            frm_panel_dashboard frm_panel_home = new frm_panel_dashboard() { TopLevel = false };
            this.panel_main.Controls.Add(frm_panel_home);
            frm_panel_home.Show();          
        }
        private void frm_home_Load_1(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();

            frm_panel_dashboard frm_panel_home = new frm_panel_dashboard() {TopLevel = false};
            this.panel_main.Controls.Add(frm_panel_home);
            frm_panel_home.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {      
            panel_main.Controls.Clear();

            frm_Doctor frm_panel_doctor = new frm_Doctor() { TopLevel = false };
            this.panel_main.Controls.Add(frm_panel_doctor);
           frm_panel_doctor.Show();       
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            frm_Patient frm_panel_patient = new frm_Patient() { TopLevel = false };
            this.panel_main.Controls.Add(frm_panel_patient);
            frm_panel_patient.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_diagnosis_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            frm_Diagnosis frm_panel_Diagnosis = new frm_Diagnosis() { TopLevel = false };
            this.panel_main.Controls.Add(frm_panel_Diagnosis);
            frm_panel_Diagnosis.Show();
        }
    }
}
