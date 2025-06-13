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
            logout = new Button();
            gantijadwal = new Button();
            ruangkelas = new Button();
            jadwal = new Button();
            infokelas = new Button();
            profil = new Button();
            matkul = new Label();
            kelas = new Label();
            dataGridView1 = new DataGridView();
            kelass = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(89, 367);
            logout.Name = "logout";
            logout.Size = new Size(79, 23);
            logout.TabIndex = 17;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // gantijadwal
            // 
            gantijadwal.BackColor = Color.Transparent;
            gantijadwal.FlatAppearance.BorderSize = 0;
            gantijadwal.FlatStyle = FlatStyle.Flat;
            gantijadwal.Location = new Point(89, 323);
            gantijadwal.Name = "gantijadwal";
            gantijadwal.Size = new Size(128, 23);
            gantijadwal.TabIndex = 16;
            gantijadwal.UseVisualStyleBackColor = false;
            gantijadwal.Click += gantijadwal_Click;
            // 
            // ruangkelas
            // 
            ruangkelas.BackColor = Color.Transparent;
            ruangkelas.FlatAppearance.BorderSize = 0;
            ruangkelas.FlatStyle = FlatStyle.Flat;
            ruangkelas.Location = new Point(90, 280);
            ruangkelas.Name = "ruangkelas";
            ruangkelas.Size = new Size(127, 23);
            ruangkelas.TabIndex = 15;
            ruangkelas.UseVisualStyleBackColor = false;
            ruangkelas.Click += ruangkelas_Click;
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
            jadwal.Click += jadwal_Click;
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
            infokelas.Click += infokelas_Click;
            // 
            // profil
            // 
            profil.BackColor = Color.Transparent;
            profil.FlatAppearance.BorderSize = 0;
            profil.FlatStyle = FlatStyle.Flat;
            profil.Location = new Point(89, 153);
            profil.Name = "profil";
            profil.Size = new Size(59, 26);
            profil.TabIndex = 12;
            profil.UseVisualStyleBackColor = false;
            profil.Click += button1_Click;
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
            kelas.Location = new Point(781, 25);
            kelas.Name = "kelas";
            kelas.Size = new Size(88, 32);
            kelas.TabIndex = 19;
            kelas.Text = "Kelas :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(631, 333);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kelass
            // 
            kelass.AutoSize = true;
            kelass.BackColor = Color.Transparent;
            kelass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kelass.ForeColor = Color.Gray;
            kelass.Location = new Point(864, 25);
            kelass.Name = "kelass";
            kelass.Size = new Size(24, 32);
            kelass.TabIndex = 21;
            kelass.Text = "-";
            kelass.Click += label1_Click;
            // 
            // V_Info_Kelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(kelass);
            Controls.Add(dataGridView1);
            Controls.Add(kelas);
            Controls.Add(matkul);
            Controls.Add(logout);
            Controls.Add(gantijadwal);
            Controls.Add(ruangkelas);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(profil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Info_Kelas";
            Text = "V_Info_Kelas";
            Load += V_Info_Kelas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Button gantijadwal;
        private Button ruangkelas;
        private Button jadwal;
        private Button infokelas;
        private Button profil;
        private Label kelas;
        public DataGridView dataGridView1;
        public Label matkul;
        public Label kelass;
    }
}