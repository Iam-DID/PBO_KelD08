namespace PBO_KelD08.JAPRI.View
{
    partial class V_Register_Page
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
            peran = new ComboBox();
            username = new TextBox();
            password = new TextBox();
            password_validation = new TextBox();
            register = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // peran
            // 
            peran.FlatStyle = FlatStyle.Flat;
            peran.FormattingEnabled = true;
            peran.Items.AddRange(new object[] { "Asisten Praktikum", "Ketua Kelas" });
            peran.Location = new Point(533, 185);
            peran.Name = "peran";
            peran.Size = new Size(344, 23);
            peran.TabIndex = 0;
            peran.Text = "-- Pilih Peran --";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Location = new Point(533, 257);
            username.Name = "username";
            username.Size = new Size(344, 16);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Location = new Point(536, 325);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(135, 16);
            password.TabIndex = 2;
            // 
            // password_validation
            // 
            password_validation.BorderStyle = BorderStyle.None;
            password_validation.Location = new Point(737, 326);
            password_validation.Name = "password_validation";
            password_validation.Size = new Size(132, 16);
            password_validation.TabIndex = 3;
            // 
            // register
            // 
            register.BackColor = Color.Transparent;
            register.FlatAppearance.BorderSize = 0;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.ForeColor = Color.White;
            register.Location = new Point(536, 383);
            register.Name = "register";
            register.Size = new Size(333, 42);
            register.TabIndex = 4;
            register.Text = "Sign Up";
            register.UseVisualStyleBackColor = false;
            register.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(628, 431);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 6;
            label1.Text = "Sudah punya akun/";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(736, 431);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // V_Register_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register;
            ClientSize = new Size(960, 540);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(register);
            Controls.Add(password_validation);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(peran);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Register_Page";
            Text = "Register_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button register;
        private Label label1;
        private LinkLabel linkLabel1;
        public ComboBox peran;
        public TextBox username;
        public TextBox password;
        public TextBox password_validation;
    }
}