namespace PBO_KelD08
{
    partial class FormDashboard
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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 30);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(769, 0);
            button1.Name = "button1";
            button1.Size = new Size(31, 30);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(396, 204);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(115, 422);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 104);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 5;
            label7.Text = "Ganti Jadwal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 127);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 4;
            label6.Text = "Logout";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 81);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 3;
            label5.Text = "Cek Ruangan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 2;
            label4.Text = "Cek Jadwal";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 1;
            label3.Text = "Info Kelas";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}