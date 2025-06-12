namespace PBO_KelD08.JAPRI.View
{
    partial class V_Login_Page
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
            login = new Button();
            username = new TextBox();
            password = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            login.Location = new Point(94, 346);
            login.Name = "login";
            login.Size = new Size(324, 45);
            login.TabIndex = 0;
            login.Text = "Sign In";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(81, 212);
            username.Name = "username";
            username.Size = new Size(337, 18);
            username.TabIndex = 1;
            username.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(85, 281);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(299, 18);
            password.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(286, 397);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 397);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 4;
            label1.Text = "Belum punya akun/";
            // 
            // V_Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_Page_fix;
            ClientSize = new Size(960, 540);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Login_Page";
            Text = "Login_Page";
            Load += V_Login_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private LinkLabel linkLabel1;
        private Label label1;
        public TextBox username;
        public TextBox password;
    }
}