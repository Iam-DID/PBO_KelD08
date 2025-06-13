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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Info_Kelas));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            jadwal = new Button();
            infokelas = new Button();
            button1 = new Button();
            matkul = new Label();
            kelas = new Label();
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
            button1.Click += button1_Click;
            // 
            // matkul
            // 
            matkul.AutoSize = true;
            matkul.BackColor = Color.Transparent;
            matkul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matkul.ForeColor = Color.Gray;
            matkul.Location = new Point(265, 25);
            matkul.Name = "matkul";
            matkul.Size = new Size(359, 32);
            matkul.TabIndex = 18;
            matkul.Text = "Algoritma dan Pemrogaman 2";
            // 
            // kelas
            // 
            kelas.AutoSize = true;
            kelas.BackColor = Color.Transparent;
            kelas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kelas.ForeColor = Color.Gray;
            kelas.Location = new Point(788, 25);
            kelas.Name = "kelas";
            kelas.Size = new Size(74, 32);
            kelas.TabIndex = 19;
            kelas.Text = "Kelas";
            // 
            // V_Info_Kelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(kelas);
            Controls.Add(matkul);
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
        private Label matkul;
        private Label kelas;
    }
}