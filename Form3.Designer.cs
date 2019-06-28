namespace HospitalManagement
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.comboBox_disease = new System.Windows.Forms.ComboBox();
            this.DrId = new System.Windows.Forms.TextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Doc_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_disease
            // 
            this.comboBox_disease.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox_disease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_disease.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.comboBox_disease.FormattingEnabled = true;
            this.comboBox_disease.Location = new System.Drawing.Point(216, 294);
            this.comboBox_disease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_disease.Name = "comboBox_disease";
            this.comboBox_disease.Size = new System.Drawing.Size(273, 33);
            this.comboBox_disease.TabIndex = 27;
            this.comboBox_disease.SelectedIndexChanged += new System.EventHandler(this.comboBox_disease_SelectedIndexChanged);
            // 
            // DrId
            // 
            this.DrId.BackColor = System.Drawing.Color.Gainsboro;
            this.DrId.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.DrId.Location = new System.Drawing.Point(650, 363);
            this.DrId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrId.Name = "DrId";
            this.DrId.Size = new System.Drawing.Size(96, 34);
            this.DrId.TabIndex = 26;
            this.DrId.TextChanged += new System.EventHandler(this.DrId_TextChanged);
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.Color.Gainsboro;
            this.patientName.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.patientName.Location = new System.Drawing.Point(216, 166);
            this.patientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(273, 34);
            this.patientName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(44, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Disease";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(501, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Doctor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(44, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Patient Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(466, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = " Close";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(315, 440);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 62);
            this.button4.TabIndex = 20;
            this.button4.Text = "  Save";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(245, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 56);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adding Patient";
            // 
            // PatientId
            // 
            this.PatientId.BackColor = System.Drawing.Color.Gainsboro;
            this.PatientId.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.PatientId.Location = new System.Drawing.Point(216, 229);
            this.PatientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(96, 34);
            this.PatientId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(44, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Patient ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CustomFormat = "dd,MMMM,yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 294);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 34);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(596, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Appointment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(44, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Doctor Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Doc_name
            // 
            this.Doc_name.BackColor = System.Drawing.Color.Gainsboro;
            this.Doc_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Doc_name.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.Doc_name.FormattingEnabled = true;
            this.Doc_name.Location = new System.Drawing.Point(216, 364);
            this.Doc_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Doc_name.Name = "Doc_name";
            this.Doc_name.Size = new System.Drawing.Size(273, 33);
            this.Doc_name.TabIndex = 35;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(864, 525);
            this.Controls.Add(this.Doc_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_disease);
            this.Controls.Add(this.DrId);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox comboBox_disease;
        public System.Windows.Forms.TextBox DrId;
        public System.Windows.Forms.TextBox patientName;
        public System.Windows.Forms.TextBox PatientId;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox Doc_name;
    }
}