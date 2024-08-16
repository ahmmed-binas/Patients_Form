namespace patients_form
{
    partial class loginform
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
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.login_textlabel = new System.Windows.Forms.Label();
            this.password_textlabel = new System.Windows.Forms.Label();
            this.username_textlabel = new System.Windows.Forms.Label();
            this.register_linklabel = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(213, 191);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(215, 21);
            this.password_textbox.TabIndex = 13;
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(213, 139);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(215, 21);
            this.username_textbox.TabIndex = 12;
            this.username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_textlabel
            // 
            this.login_textlabel.AutoSize = true;
            this.login_textlabel.BackColor = System.Drawing.Color.Gray;
            this.login_textlabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.login_textlabel.Location = new System.Drawing.Point(92, 71);
            this.login_textlabel.Name = "login_textlabel";
            this.login_textlabel.Size = new System.Drawing.Size(455, 36);
            this.login_textlabel.TabIndex = 11;
            this.login_textlabel.Text = "Patients Managment System Login";
            this.login_textlabel.Click += new System.EventHandler(this.login_textlabel_Click_1);
            // 
            // password_textlabel
            // 
            this.password_textlabel.AutoSize = true;
            this.password_textlabel.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textlabel.Location = new System.Drawing.Point(128, 186);
            this.password_textlabel.Name = "password_textlabel";
            this.password_textlabel.Size = new System.Drawing.Size(88, 34);
            this.password_textlabel.TabIndex = 10;
            this.password_textlabel.Text = "Password:";
            // 
            // username_textlabel
            // 
            this.username_textlabel.AutoSize = true;
            this.username_textlabel.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textlabel.Location = new System.Drawing.Point(124, 134);
            this.username_textlabel.Name = "username_textlabel";
            this.username_textlabel.Size = new System.Drawing.Size(92, 34);
            this.username_textlabel.TabIndex = 9;
            this.username_textlabel.Text = "Username:";
            // 
            // register_linklabel
            // 
            this.register_linklabel.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.register_linklabel.AutoSize = true;
            this.register_linklabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_linklabel.LinkColor = System.Drawing.Color.Purple;
            this.register_linklabel.Location = new System.Drawing.Point(445, 284);
            this.register_linklabel.Name = "register_linklabel";
            this.register_linklabel.Size = new System.Drawing.Size(103, 17);
            this.register_linklabel.TabIndex = 8;
            this.register_linklabel.TabStop = true;
            this.register_linklabel.Text = "Register Now!";
            this.register_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_linklabel_LinkClicked_1);
            // 
            // login_btn
            // 
            this.login_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.login_btn.BackColor = System.Drawing.Color.Tan;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(272, 232);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(86, 44);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(639, 373);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.login_textlabel);
            this.Controls.Add(this.password_textlabel);
            this.Controls.Add(this.username_textlabel);
            this.Controls.Add(this.register_linklabel);
            this.Controls.Add(this.login_btn);
            this.Name = "loginform";
            this.Text = "Patients Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label login_textlabel;
        private System.Windows.Forms.Label password_textlabel;
        private System.Windows.Forms.Label username_textlabel;
        private System.Windows.Forms.LinkLabel register_linklabel;
        private System.Windows.Forms.Button login_btn;
    }
}

