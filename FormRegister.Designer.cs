namespace PBO_KelD08
{
    partial class FormRegister
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Asisten Praktikum", "Ketua Kelas" });
            comboBox1.Location = new Point(324, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "- Pilih Peran -";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(324, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(324, 217);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(324, 270);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
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
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}