namespace Project
{
    partial class frm_Diagnosis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_patient_diagnosis = new System.Windows.Forms.ComboBox();
            this.textBox_medicine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_diagnosis = new System.Windows.Forms.TextBox();
            this.textBox_symptoms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_diagnosis_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_patient_name = new System.Windows.Forms.TextBox();
            this.dataGridView_diagnosis = new System.Windows.Forms.DataGridView();
            this.textBox_doctor_fee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_diagnosis_home = new System.Windows.Forms.Button();
            this.btn_diagnosis_update = new System.Windows.Forms.Button();
            this.btn_diagnosis_delete = new System.Windows.Forms.Button();
            this.btn_diagnosis_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 36);
            this.label7.TabIndex = 52;
            this.label7.Text = "Paitent ID:";
            // 
            // comboBox_patient_diagnosis
            // 
            this.comboBox_patient_diagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_patient_diagnosis.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_patient_diagnosis.FormattingEnabled = true;
            this.comboBox_patient_diagnosis.Location = new System.Drawing.Point(315, 257);
            this.comboBox_patient_diagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_patient_diagnosis.Name = "comboBox_patient_diagnosis";
            this.comboBox_patient_diagnosis.Size = new System.Drawing.Size(121, 30);
            this.comboBox_patient_diagnosis.TabIndex = 1;
            this.comboBox_patient_diagnosis.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_patient_diagnosis_SelectionChangeCommitted);
            // 
            // textBox_medicine
            // 
            this.textBox_medicine.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_medicine.Location = new System.Drawing.Point(315, 430);
            this.textBox_medicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_medicine.Name = "textBox_medicine";
            this.textBox_medicine.Size = new System.Drawing.Size(239, 29);
            this.textBox_medicine.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 50;
            this.label2.Text = "Medicine:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 89);
            this.panel1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, -10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 96);
            this.label6.TabIndex = 2;
            this.label6.Text = "DIAGNOSIS";
            // 
            // textBox_diagnosis
            // 
            this.textBox_diagnosis.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diagnosis.Location = new System.Drawing.Point(315, 366);
            this.textBox_diagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_diagnosis.Name = "textBox_diagnosis";
            this.textBox_diagnosis.Size = new System.Drawing.Size(239, 29);
            this.textBox_diagnosis.TabIndex = 4;
            // 
            // textBox_symptoms
            // 
            this.textBox_symptoms.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_symptoms.Location = new System.Drawing.Point(315, 306);
            this.textBox_symptoms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_symptoms.Name = "textBox_symptoms";
            this.textBox_symptoms.Size = new System.Drawing.Size(239, 29);
            this.textBox_symptoms.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 41;
            this.label4.Text = "Symptoms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 36);
            this.label3.TabIndex = 39;
            this.label3.Text = "Diagnosis ID :";
            // 
            // textBox_diagnosis_id
            // 
            this.textBox_diagnosis_id.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diagnosis_id.Location = new System.Drawing.Point(315, 133);
            this.textBox_diagnosis_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_diagnosis_id.Name = "textBox_diagnosis_id";
            this.textBox_diagnosis_id.Size = new System.Drawing.Size(239, 29);
            this.textBox_diagnosis_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Patient Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 36);
            this.label5.TabIndex = 43;
            this.label5.Text = "Diagnosis:";
            // 
            // textBox_patient_name
            // 
            this.textBox_patient_name.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_name.Location = new System.Drawing.Point(315, 188);
            this.textBox_patient_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_patient_name.Name = "textBox_patient_name";
            this.textBox_patient_name.ReadOnly = true;
            this.textBox_patient_name.Size = new System.Drawing.Size(239, 29);
            this.textBox_patient_name.TabIndex = 0;
            this.textBox_patient_name.TabStop = false;
            // 
            // dataGridView_diagnosis
            // 
            this.dataGridView_diagnosis.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_diagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_diagnosis.CausesValidation = false;
            this.dataGridView_diagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_diagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_diagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_diagnosis.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_diagnosis.EnableHeadersVisualStyles = false;
            this.dataGridView_diagnosis.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_diagnosis.Location = new System.Drawing.Point(145, 535);
            this.dataGridView_diagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_diagnosis.Name = "dataGridView_diagnosis";
            this.dataGridView_diagnosis.ReadOnly = true;
            this.dataGridView_diagnosis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_diagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_diagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_diagnosis.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_diagnosis.RowTemplate.Height = 24;
            this.dataGridView_diagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_diagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_diagnosis.Size = new System.Drawing.Size(979, 206);
            this.dataGridView_diagnosis.TabIndex = 10;
            this.dataGridView_diagnosis.TabStop = false;
            this.dataGridView_diagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_diagnosis_CellContentClick);
            // 
            // textBox_doctor_fee
            // 
            this.textBox_doctor_fee.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_doctor_fee.Location = new System.Drawing.Point(315, 482);
            this.textBox_doctor_fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_doctor_fee.Name = "textBox_doctor_fee";
            this.textBox_doctor_fee.Size = new System.Drawing.Size(239, 29);
            this.textBox_doctor_fee.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 36);
            this.label8.TabIndex = 54;
            this.label8.Text = "Doctor Fee:";
            // 
            // btn_diagnosis_home
            // 
            this.btn_diagnosis_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_diagnosis_home.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_diagnosis_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis_home.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosis_home.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis_home.Image = global::Project.Properties.Resources.home_page_36px;
            this.btn_diagnosis_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_diagnosis_home.Location = new System.Drawing.Point(873, 298);
            this.btn_diagnosis_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_diagnosis_home.Name = "btn_diagnosis_home";
            this.btn_diagnosis_home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_diagnosis_home.Size = new System.Drawing.Size(157, 54);
            this.btn_diagnosis_home.TabIndex = 11;
            this.btn_diagnosis_home.Text = "      Home";
            this.btn_diagnosis_home.UseVisualStyleBackColor = false;
            this.btn_diagnosis_home.Click += new System.EventHandler(this.btn_diagnosis_home_Click);
            // 
            // btn_diagnosis_update
            // 
            this.btn_diagnosis_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_diagnosis_update.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_diagnosis_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis_update.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosis_update.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis_update.Image = global::Project.Properties.Resources.update_36px;
            this.btn_diagnosis_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_diagnosis_update.Location = new System.Drawing.Point(1053, 226);
            this.btn_diagnosis_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_diagnosis_update.Name = "btn_diagnosis_update";
            this.btn_diagnosis_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_diagnosis_update.Size = new System.Drawing.Size(157, 54);
            this.btn_diagnosis_update.TabIndex = 9;
            this.btn_diagnosis_update.Text = "      Update";
            this.btn_diagnosis_update.UseVisualStyleBackColor = false;
            this.btn_diagnosis_update.Click += new System.EventHandler(this.btn_diagnosis_update_Click);
            // 
            // btn_diagnosis_delete
            // 
            this.btn_diagnosis_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_diagnosis_delete.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_diagnosis_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis_delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosis_delete.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis_delete.Image = global::Project.Properties.Resources.delete_36px;
            this.btn_diagnosis_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_diagnosis_delete.Location = new System.Drawing.Point(873, 226);
            this.btn_diagnosis_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_diagnosis_delete.Name = "btn_diagnosis_delete";
            this.btn_diagnosis_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_diagnosis_delete.Size = new System.Drawing.Size(157, 54);
            this.btn_diagnosis_delete.TabIndex = 8;
            this.btn_diagnosis_delete.Text = "      Delete";
            this.btn_diagnosis_delete.UseVisualStyleBackColor = false;
            this.btn_diagnosis_delete.Click += new System.EventHandler(this.btn_diagnosis_delete_Click);
            // 
            // btn_diagnosis_add
            // 
            this.btn_diagnosis_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_diagnosis_add.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_diagnosis_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis_add.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosis_add.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis_add.Image = global::Project.Properties.Resources.add_36px;
            this.btn_diagnosis_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_diagnosis_add.Location = new System.Drawing.Point(693, 226);
            this.btn_diagnosis_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_diagnosis_add.Name = "btn_diagnosis_add";
            this.btn_diagnosis_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_diagnosis_add.Size = new System.Drawing.Size(157, 54);
            this.btn_diagnosis_add.TabIndex = 7;
            this.btn_diagnosis_add.Text = "   Add";
            this.btn_diagnosis_add.UseVisualStyleBackColor = false;
            this.btn_diagnosis_add.Click += new System.EventHandler(this.btn_diagnosis_add_Click);
            // 
            // frm_Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 752);
            this.Controls.Add(this.textBox_doctor_fee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_diagnosis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_patient_diagnosis);
            this.Controls.Add(this.textBox_medicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_diagnosis_home);
            this.Controls.Add(this.btn_diagnosis_update);
            this.Controls.Add(this.btn_diagnosis_delete);
            this.Controls.Add(this.btn_diagnosis_add);
            this.Controls.Add(this.textBox_diagnosis);
            this.Controls.Add(this.textBox_symptoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_diagnosis_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_patient_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Diagnosis";
            this.Text = "frm_Diagnosis";
            this.Load += new System.EventHandler(this.frm_Diagnosis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_patient_diagnosis;
        private System.Windows.Forms.TextBox textBox_medicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_diagnosis_home;
        private System.Windows.Forms.Button btn_diagnosis_update;
        private System.Windows.Forms.Button btn_diagnosis_delete;
        private System.Windows.Forms.Button btn_diagnosis_add;
        private System.Windows.Forms.TextBox textBox_diagnosis;
        private System.Windows.Forms.TextBox textBox_symptoms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_diagnosis_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_patient_name;
        private System.Windows.Forms.DataGridView dataGridView_diagnosis;
        private System.Windows.Forms.TextBox textBox_doctor_fee;
        private System.Windows.Forms.Label label8;
    }
}