namespace PBO_KelD08
{
    partial class V_Login
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
            label1 = new Label();
            username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            password = new TextBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 71);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 11F);
            username.Location = new Point(313, 154);
            username.Name = "username";
            username.Size = new Size(156, 27);
            username.TabIndex = 1;
            username.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(313, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(313, 184);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(313, 207);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(156, 27);
            password.TabIndex = 4;
            password.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(313, 262);
            button1.Name = "button1";
            button1.Size = new Size(156, 32);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(313, 248);
            label4.Name = "label4";
            label4.Size = new Size(106, 13);
            label4.TabIndex = 7;
            label4.Text = "Belum Punya akun?";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(416, 247);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(437, 208);
            button2.Name = "button2";
            button2.Size = new Size(31, 25);
            button2.TabIndex = 11;
            button2.Text = "👁️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            HelpButton = true;
            Name = "V_Login";
            Text = "Form1";
            Load += V_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button2;
        public TextBox username;
        public TextBox password;
    }
}