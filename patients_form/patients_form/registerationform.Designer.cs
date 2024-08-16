namespace patients_form
{
    partial class registerationform
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dob_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.registration_label = new System.Windows.Forms.Label();
            this.dob_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.firstname_label = new System.Windows.Forms.Label();
            this.gender_combox = new System.Windows.Forms.ComboBox();
            this.lastname_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rusername = new System.Windows.Forms.Label();
            this.repassword_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rpassword_textbox = new System.Windows.Forms.TextBox();
            this.repassword_label = new System.Windows.Forms.Label();
            this.rusername_textbox = new System.Windows.Forms.TextBox();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_label.Location = new System.Drawing.Point(58, 185);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(95, 29);
            this.dob_label.TabIndex = 15;
            this.dob_label.Text = "DateOfBirth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.BackColor = System.Drawing.Color.Gray;
            this.registration_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_label.ForeColor = System.Drawing.Color.Snow;
            this.registration_label.Location = new System.Drawing.Point(121, 28);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(290, 36);
            this.registration_label.TabIndex = 16;
            this.registration_label.Tag = "form";
            this.registration_label.Text = "Patients Registration";
            this.registration_label.Click += new System.EventHandler(this.registration_label_Click);
            // 
            // dob_datetimepicker
            // 
            this.dob_datetimepicker.Location = new System.Drawing.Point(155, 186);
            this.dob_datetimepicker.Name = "dob_datetimepicker";
            this.dob_datetimepicker.Size = new System.Drawing.Size(101, 20);
            this.dob_datetimepicker.TabIndex = 29;
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_label.Location = new System.Drawing.Point(96, 81);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(96, 34);
            this.firstname_label.TabIndex = 17;
            this.firstname_label.Text = "First Name";
            // 
            // gender_combox
            // 
            this.gender_combox.FormattingEnabled = true;
            this.gender_combox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combox.Location = new System.Drawing.Point(322, 185);
            this.gender_combox.Name = "gender_combox";
            this.gender_combox.Size = new System.Drawing.Size(89, 21);
            this.gender_combox.TabIndex = 28;
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_label.Location = new System.Drawing.Point(105, 125);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(87, 34);
            this.lastname_label.TabIndex = 18;
            this.lastname_label.Text = "LastName";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(198, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rusername
            // 
            this.rusername.AutoSize = true;
            this.rusername.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rusername.Location = new System.Drawing.Point(105, 235);
            this.rusername.Name = "rusername";
            this.rusername.Size = new System.Drawing.Size(87, 34);
            this.rusername.TabIndex = 19;
            this.rusername.Text = "Username";
            // 
            // repassword_textbox
            // 
            this.repassword_textbox.Location = new System.Drawing.Point(199, 333);
            this.repassword_textbox.Name = "repassword_textbox";
            this.repassword_textbox.Size = new System.Drawing.Size(212, 20);
            this.repassword_textbox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // rpassword_textbox
            // 
            this.rpassword_textbox.Location = new System.Drawing.Point(199, 286);
            this.rpassword_textbox.Name = "rpassword_textbox";
            this.rpassword_textbox.Size = new System.Drawing.Size(213, 20);
            this.rpassword_textbox.TabIndex = 25;
            // 
            // repassword_label
            // 
            this.repassword_label.AutoSize = true;
            this.repassword_label.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repassword_label.Location = new System.Drawing.Point(54, 328);
            this.repassword_label.Name = "repassword_label";
            this.repassword_label.Size = new System.Drawing.Size(144, 34);
            this.repassword_label.TabIndex = 21;
            this.repassword_label.Text = "confirm password";
            // 
            // rusername_textbox
            // 
            this.rusername_textbox.Location = new System.Drawing.Point(198, 240);
            this.rusername_textbox.Name = "rusername_textbox";
            this.rusername_textbox.Size = new System.Drawing.Size(213, 20);
            this.rusername_textbox.TabIndex = 24;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(200, 86);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(212, 20);
            this.firstname_textbox.TabIndex = 22;
            this.firstname_textbox.TextChanged += new System.EventHandler(this.firstname_textbox_TextChanged);
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(200, 130);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(212, 20);
            this.lastname_textbox.TabIndex = 23;
            // 
            // registerationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(527, 442);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registration_label);
            this.Controls.Add(this.dob_datetimepicker);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.gender_combox);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rusername);
            this.Controls.Add(this.repassword_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rpassword_textbox);
            this.Controls.Add(this.repassword_label);
            this.Controls.Add(this.rusername_textbox);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.dob_label);
            this.Name = "registerationform";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.registerationform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.DateTimePicker dob_datetimepicker;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.ComboBox gender_combox;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rusername;
        private System.Windows.Forms.TextBox repassword_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rpassword_textbox;
        private System.Windows.Forms.Label repassword_label;
        private System.Windows.Forms.TextBox rusername_textbox;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
    }
}