namespace PBO_KelD08.JAPRI.View
{
    partial class V_Info_Kelas
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            jadwal = new Button();
            infokelas = new Button();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(89, 367);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(89, 323);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(90, 280);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = false;
            // 
            // jadwal
            // 
            jadwal.BackColor = Color.Transparent;
            jadwal.FlatAppearance.BorderSize = 0;
            jadwal.FlatStyle = FlatStyle.Flat;
            jadwal.Location = new Point(90, 236);
            jadwal.Name = "jadwal";
            jadwal.Size = new Size(78, 23);
            jadwal.TabIndex = 14;
            jadwal.UseVisualStyleBackColor = false;
            // 
            // infokelas
            // 
            infokelas.BackColor = Color.Transparent;
            infokelas.FlatAppearance.BorderSize = 0;
            infokelas.FlatStyle = FlatStyle.Flat;
            infokelas.Location = new Point(89, 195);
            infokelas.Name = "infokelas";
            infokelas.Size = new Size(139, 28);
            infokelas.TabIndex = 13;
            infokelas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(89, 153);
            button1.Name = "button1";
            button1.Size = new Size(59, 26);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 62);
            label1.Name = "label1";
            label1.Size = new Size(296, 28);
            label1.TabIndex = 18;
            label1.Text = "Algoritma dan Pemrogaman 2";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = Color.Transparent;
            dateTimePicker1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(602, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 32);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // V_Info_Kelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tampilan_info_kelas;
            ClientSize = new Size(960, 540);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Info_Kelas";
            Text = "V_Info_Kelas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button jadwal;
        private Button infokelas;
        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}