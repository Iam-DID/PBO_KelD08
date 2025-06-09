namespace PBO_KelD08
{
    partial class V_Register
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
            peran = new ComboBox();
            label2 = new Label();
            username = new TextBox();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            password_validation = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(350, 44);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // peran
            // 
            peran.Font = new Font("Segoe UI", 11F);
            peran.FormattingEnabled = true;
            peran.Items.AddRange(new object[] { "Asisten Praktikum", "Ketua Kelas" });
            peran.Location = new Point(324, 110);
            peran.Name = "peran";
            peran.Size = new Size(156, 28);
            peran.TabIndex = 1;
            peran.Text = "- Pilih Peran -";
            peran.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(324, 87);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Register Sebagai";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 11F);
            username.Location = new Point(324, 164);
            username.Name = "username";
            username.Size = new Size(156, 27);
            username.TabIndex = 1;
            username.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(324, 141);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 3;
            label3.Text = "NIM";
            label3.Click += label3_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(324, 217);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(156, 27);
            password.TabIndex = 4;
            password.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(324, 194);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // password_validation
            // 
            password_validation.Font = new Font("Segoe UI", 11F);
            password_validation.Location = new Point(324, 270);
            password_validation.Name = "password_validation";
            password_validation.PasswordChar = '*';
            password_validation.Size = new Size(156, 27);
            password_validation.TabIndex = 6;
            password_validation.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(324, 247);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 7;
            label5.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(407, 314);
            button1.Name = "button1";
            button1.Size = new Size(72, 29);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(448, 218);
            button2.Name = "button2";
            button2.Size = new Size(31, 25);
            button2.TabIndex = 10;
            button2.Text = "👁️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(448, 271);
            button3.Name = "button3";
            button3.Size = new Size(31, 25);
            button3.TabIndex = 11;
            button3.Text = "👁️";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(322, 314);
            button4.Name = "button4";
            button4.Size = new Size(72, 29);
            button4.TabIndex = 12;
            button4.Text = "Kembali";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(password_validation);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(peran);
            Controls.Add(label1);
            Name = "V_Register";
            Text = "FormRegister";
            Load += V_Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        public TextBox username;
        public ComboBox peran;
        public TextBox password;
        public TextBox password_validation;
    }
}