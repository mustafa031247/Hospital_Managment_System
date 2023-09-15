namespace Project
{
    partial class frm_Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_patient = new System.Windows.Forms.DataGridView();
            this.btn_patient_home = new System.Windows.Forms.Button();
            this.btn_patient_update = new System.Windows.Forms.Button();
            this.btn_patient_delete = new System.Windows.Forms.Button();
            this.btn_patient_add = new System.Windows.Forms.Button();
            this.textBox_patient_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_patient_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_patient_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_patient_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_patient_age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_patient_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_patient_blood_grp = new System.Windows.Forms.ComboBox();
            this.textBox_patient_major_disease = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 103);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 96);
            this.label6.TabIndex = 2;
            this.label6.Text = "PATIENT";
            // 
            // dataGridView_patient
            // 
            this.dataGridView_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_patient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_patient.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_patient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_patient.EnableHeadersVisualStyles = false;
            this.dataGridView_patient.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_patient.Location = new System.Drawing.Point(56, 628);
            this.dataGridView_patient.MultiSelect = false;
            this.dataGridView_patient.Name = "dataGridView_patient";
            this.dataGridView_patient.ReadOnly = true;
            this.dataGridView_patient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_patient.RowHeadersWidth = 51;
            this.dataGridView_patient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_patient.RowTemplate.Height = 24;
            this.dataGridView_patient.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_patient.Size = new System.Drawing.Size(1201, 159);
            this.dataGridView_patient.TabIndex = 0;
            this.dataGridView_patient.TabStop = false;
            this.dataGridView_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patient_CellContentClick);
            // 
            // btn_patient_home
            // 
            this.btn_patient_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_patient_home.FlatAppearance.BorderSize = 0;
            this.btn_patient_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_patient_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_home.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_home.ForeColor = System.Drawing.Color.White;
            this.btn_patient_home.Image = global::Project.Properties.Resources.home_page_36px;
            this.btn_patient_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient_home.Location = new System.Drawing.Point(886, 322);
            this.btn_patient_home.Name = "btn_patient_home";
            this.btn_patient_home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_patient_home.Size = new System.Drawing.Size(157, 54);
            this.btn_patient_home.TabIndex = 12;
            this.btn_patient_home.Text = "      Home";
            this.btn_patient_home.UseVisualStyleBackColor = false;
            this.btn_patient_home.Click += new System.EventHandler(this.btn_dctr_home_Click);
            // 
            // btn_patient_update
            // 
            this.btn_patient_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_patient_update.FlatAppearance.BorderSize = 0;
            this.btn_patient_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_patient_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_update.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_update.ForeColor = System.Drawing.Color.White;
            this.btn_patient_update.Image = global::Project.Properties.Resources.update_36px;
            this.btn_patient_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient_update.Location = new System.Drawing.Point(1088, 240);
            this.btn_patient_update.Name = "btn_patient_update";
            this.btn_patient_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_patient_update.Size = new System.Drawing.Size(157, 54);
            this.btn_patient_update.TabIndex = 11;
            this.btn_patient_update.Text = "      Update";
            this.btn_patient_update.UseVisualStyleBackColor = false;
            this.btn_patient_update.Click += new System.EventHandler(this.btn_patient_update_Click);
            // 
            // btn_patient_delete
            // 
            this.btn_patient_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_patient_delete.FlatAppearance.BorderSize = 0;
            this.btn_patient_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_patient_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_delete.ForeColor = System.Drawing.Color.White;
            this.btn_patient_delete.Image = global::Project.Properties.Resources.delete_36px;
            this.btn_patient_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient_delete.Location = new System.Drawing.Point(886, 240);
            this.btn_patient_delete.Name = "btn_patient_delete";
            this.btn_patient_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_patient_delete.Size = new System.Drawing.Size(157, 54);
            this.btn_patient_delete.TabIndex = 10;
            this.btn_patient_delete.Text = "      Delete";
            this.btn_patient_delete.UseVisualStyleBackColor = false;
            this.btn_patient_delete.Click += new System.EventHandler(this.btn_patient_delete_Click);
            // 
            // btn_patient_add
            // 
            this.btn_patient_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_patient_add.FlatAppearance.BorderSize = 0;
            this.btn_patient_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_patient_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_add.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_add.ForeColor = System.Drawing.Color.White;
            this.btn_patient_add.Image = global::Project.Properties.Resources.add_36px;
            this.btn_patient_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient_add.Location = new System.Drawing.Point(691, 240);
            this.btn_patient_add.Name = "btn_patient_add";
            this.btn_patient_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_patient_add.Size = new System.Drawing.Size(157, 54);
            this.btn_patient_add.TabIndex = 9;
            this.btn_patient_add.Text = "   Add";
            this.btn_patient_add.UseVisualStyleBackColor = false;
            this.btn_patient_add.Click += new System.EventHandler(this.btn_patient_add_Click);
            // 
            // textBox_patient_phone
            // 
            this.textBox_patient_phone.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_phone.Location = new System.Drawing.Point(325, 322);
            this.textBox_patient_phone.Name = "textBox_patient_phone";
            this.textBox_patient_phone.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_phone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(73, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Patient Phone :";
            // 
            // textBox_patient_address
            // 
            this.textBox_patient_address.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_address.Location = new System.Drawing.Point(325, 262);
            this.textBox_patient_address.Name = "textBox_patient_address";
            this.textBox_patient_address.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_address.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(56, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Patient Address : \r\n";
            // 
            // textBox_patient_name
            // 
            this.textBox_patient_name.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_name.Location = new System.Drawing.Point(325, 195);
            this.textBox_patient_name.Name = "textBox_patient_name";
            this.textBox_patient_name.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(98, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Patient  ID :";
            // 
            // textBox_patient_id
            // 
            this.textBox_patient_id.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_id.Location = new System.Drawing.Point(325, 140);
            this.textBox_patient_id.Name = "textBox_patient_id";
            this.textBox_patient_id.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(76, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient Name :";
            // 
            // textBox_patient_age
            // 
            this.textBox_patient_age.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_age.Location = new System.Drawing.Point(325, 386);
            this.textBox_patient_age.Name = "textBox_patient_age";
            this.textBox_patient_age.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_age.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(86, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Patient Age : ";
            // 
            // comboBox_patient_gender
            // 
            this.comboBox_patient_gender.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_patient_gender.FormattingEnabled = true;
            this.comboBox_patient_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_patient_gender.Location = new System.Drawing.Point(384, 455);
            this.comboBox_patient_gender.Name = "comboBox_patient_gender";
            this.comboBox_patient_gender.Size = new System.Drawing.Size(121, 30);
            this.comboBox_patient_gender.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(119, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 36);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender :\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(85, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 36);
            this.label8.TabIndex = 32;
            this.label8.Text = "Blood Group :";
            // 
            // comboBox_patient_blood_grp
            // 
            this.comboBox_patient_blood_grp.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_patient_blood_grp.FormattingEnabled = true;
            this.comboBox_patient_blood_grp.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBox_patient_blood_grp.Location = new System.Drawing.Point(384, 512);
            this.comboBox_patient_blood_grp.Name = "comboBox_patient_blood_grp";
            this.comboBox_patient_blood_grp.Size = new System.Drawing.Size(121, 30);
            this.comboBox_patient_blood_grp.TabIndex = 7;
            // 
            // textBox_patient_major_disease
            // 
            this.textBox_patient_major_disease.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_major_disease.Location = new System.Drawing.Point(325, 577);
            this.textBox_patient_major_disease.Name = "textBox_patient_major_disease";
            this.textBox_patient_major_disease.Size = new System.Drawing.Size(238, 29);
            this.textBox_patient_major_disease.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(67, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 36);
            this.label9.TabIndex = 34;
            this.label9.Text = "Major Disease : ";
            // 
            // frm_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 799);
            this.Controls.Add(this.textBox_patient_major_disease);
            this.Controls.Add(this.btn_patient_home);
            this.Controls.Add(this.btn_patient_update);
            this.Controls.Add(this.btn_patient_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_patient_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_patient_blood_grp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_patient_gender);
            this.Controls.Add(this.textBox_patient_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_patient);
            this.Controls.Add(this.textBox_patient_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_patient_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_patient_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_patient_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Patient";
            this.Load += new System.EventHandler(this.frm_Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_patient;
        private System.Windows.Forms.Button btn_patient_home;
        private System.Windows.Forms.Button btn_patient_update;
        private System.Windows.Forms.Button btn_patient_delete;
        private System.Windows.Forms.Button btn_patient_add;
        private System.Windows.Forms.TextBox textBox_patient_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_patient_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_patient_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_patient_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_patient_age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_patient_gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_patient_blood_grp;
        private System.Windows.Forms.TextBox textBox_patient_major_disease;
        private System.Windows.Forms.Label label9;

        
        }
}