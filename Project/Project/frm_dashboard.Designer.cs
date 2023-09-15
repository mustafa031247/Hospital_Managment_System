namespace Project
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_side_main_menu = new System.Windows.Forms.Panel();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btn_diagnosis = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_top_home = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_side_main_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_side_main_menu
            // 
            this.pnl_side_main_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_side_main_menu.Controls.Add(this.pnl_main);
            this.pnl_side_main_menu.Controls.Add(this.panel1);
            this.pnl_side_main_menu.Controls.Add(this.pictureBox1);
            this.pnl_side_main_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side_main_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_side_main_menu.Name = "pnl_side_main_menu";
            this.pnl_side_main_menu.Size = new System.Drawing.Size(250, 809);
            this.pnl_side_main_menu.TabIndex = 0;
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(256, 11);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1415, 795);
            this.pnl_main.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Controls.Add(this.btn_diagnosis);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 527);
            this.panel1.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Image = global::Project.Properties.Resources.export_36px;
            this.exitbtn.Location = new System.Drawing.Point(178, 441);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(72, 68);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Image = global::Project.Properties.Resources.medical_doctor_36px1;
            this.btnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.Location = new System.Drawing.Point(0, 291);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(257, 54);
            this.btnDoctor.TabIndex = 5;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btn_diagnosis
            // 
            this.btn_diagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_diagnosis.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosis.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis.Image = global::Project.Properties.Resources.health_checkup_36px;
            this.btn_diagnosis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_diagnosis.Location = new System.Drawing.Point(-3, 190);
            this.btn_diagnosis.Name = "btn_diagnosis";
            this.btn_diagnosis.Size = new System.Drawing.Size(257, 54);
            this.btn_diagnosis.TabIndex = 4;
            this.btn_diagnosis.Text = "Diagnosis";
            this.btn_diagnosis.UseVisualStyleBackColor = false;
            this.btn_diagnosis.Click += new System.EventHandler(this.btn_diagnosis_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = global::Project.Properties.Resources.therapy_36px;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPatient.Location = new System.Drawing.Point(3, 90);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPatient.Size = new System.Drawing.Size(257, 54);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::Project.Properties.Resources.home_page_36px;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(257, 54);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = global::Project.Properties.Resources.LOGO1;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_main.Location = new System.Drawing.Point(250, 11);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1306, 804);
            this.panel_main.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.panel_top_home);
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1558, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel_top_home
            // 
            this.panel_top_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top_home.Location = new System.Drawing.Point(0, 0);
            this.panel_top_home.Name = "panel_top_home";
            this.panel_top_home.Size = new System.Drawing.Size(1558, 10);
            this.panel_top_home.TabIndex = 0;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 809);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_side_main_menu);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_home";
            this.Load += new System.EventHandler(this.frm_home_Load_1);
            this.pnl_side_main_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_side_main_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btn_diagnosis;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panel_top_home;
    }
}