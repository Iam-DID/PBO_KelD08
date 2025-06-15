namespace PBO_KelD08.JAPRI.View
{
    partial class V_Info_Jadwal_Page
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
            ruangkelas = new Button();
            jadwal = new Button();
            infokelas = new Button();
            button1 = new Button();
            semester = new Label();
            kelas = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(87, 367);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 29;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(87, 323);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 28;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ruangkelas
            // 
            ruangkelas.BackColor = Color.Transparent;
            ruangkelas.FlatAppearance.BorderSize = 0;
            ruangkelas.FlatStyle = FlatStyle.Flat;
            ruangkelas.Location = new Point(88, 280);
            ruangkelas.Name = "ruangkelas";
            ruangkelas.Size = new Size(127, 23);
            ruangkelas.TabIndex = 27;
            ruangkelas.UseVisualStyleBackColor = false;
            ruangkelas.Click += ruangkelas_Click;
            // 
            // jadwal
            // 
            jadwal.BackColor = Color.Transparent;
            jadwal.FlatAppearance.BorderSize = 0;
            jadwal.FlatStyle = FlatStyle.Flat;
            jadwal.Location = new Point(88, 236);
            jadwal.Name = "jadwal";
            jadwal.Size = new Size(140, 23);
            jadwal.TabIndex = 26;
            jadwal.UseVisualStyleBackColor = false;
            jadwal.Click += jadwal_Click;
            // 
            // infokelas
            // 
            infokelas.BackColor = Color.Transparent;
            infokelas.FlatAppearance.BorderSize = 0;
            infokelas.FlatStyle = FlatStyle.Flat;
            infokelas.Location = new Point(87, 195);
            infokelas.Name = "infokelas";
            infokelas.Size = new Size(104, 28);
            infokelas.TabIndex = 25;
            infokelas.UseVisualStyleBackColor = false;
            infokelas.Click += infokelas_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(87, 153);
            button1.Name = "button1";
            button1.Size = new Size(59, 26);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // semester
            // 
            semester.AutoSize = true;
            semester.BackColor = Color.Transparent;
            semester.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            semester.ForeColor = Color.Gray;
            semester.Location = new Point(871, 22);
            semester.Name = "semester";
            semester.Size = new Size(24, 32);
            semester.TabIndex = 32;
            semester.Text = "-";
            // 
            // kelas
            // 
            kelas.AutoSize = true;
            kelas.BackColor = Color.Transparent;
            kelas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kelas.ForeColor = Color.Gray;
            kelas.Location = new Point(742, 22);
            kelas.Name = "kelas";
            kelas.Size = new Size(132, 32);
            kelas.TabIndex = 31;
            kelas.Text = "Semester :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(618, 360);
            dataGridView1.TabIndex = 33;
            // 
            // V_Info_Jadwal_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tampilan_info_kelas_rev;
            ClientSize = new Size(960, 540);
            Controls.Add(dataGridView1);
            Controls.Add(semester);
            Controls.Add(kelas);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(ruangkelas);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Info_Jadwal_Page";
            Text = "V_Info_Jadwal_Page";
            Load += V_Info_Jadwal_Page_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button ruangkelas;
        private Button jadwal;
        private Button infokelas;
        private Button button1;
        public Label semester;
        private Label kelas;
        public DataGridView dataGridView1;
    }
}