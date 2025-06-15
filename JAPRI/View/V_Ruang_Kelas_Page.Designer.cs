namespace PBO_KelD08.JAPRI.View
{
    partial class V_Ruang_Kelas_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Ruang_Kelas_Page));
            logout = new Button();
            gantijadwal = new Button();
            ruangkelas = new Button();
            jadwal = new Button();
            infokelas = new Button();
            profil = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(88, 368);
            logout.Name = "logout";
            logout.Size = new Size(79, 23);
            logout.TabIndex = 23;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // gantijadwal
            // 
            gantijadwal.BackColor = Color.Transparent;
            gantijadwal.FlatAppearance.BorderSize = 0;
            gantijadwal.FlatStyle = FlatStyle.Flat;
            gantijadwal.Location = new Point(88, 324);
            gantijadwal.Name = "gantijadwal";
            gantijadwal.Size = new Size(128, 23);
            gantijadwal.TabIndex = 22;
            gantijadwal.UseVisualStyleBackColor = false;
            gantijadwal.Click += gantijadwal_Click;
            // 
            // ruangkelas
            // 
            ruangkelas.BackColor = Color.Transparent;
            ruangkelas.FlatAppearance.BorderSize = 0;
            ruangkelas.FlatStyle = FlatStyle.Flat;
            ruangkelas.Location = new Point(88, 281);
            ruangkelas.Name = "ruangkelas";
            ruangkelas.Size = new Size(138, 23);
            ruangkelas.TabIndex = 21;
            ruangkelas.UseVisualStyleBackColor = false;
            ruangkelas.Click += ruangkelas_Click;
            // 
            // jadwal
            // 
            jadwal.BackColor = Color.Transparent;
            jadwal.FlatAppearance.BorderSize = 0;
            jadwal.FlatStyle = FlatStyle.Flat;
            jadwal.Location = new Point(89, 237);
            jadwal.Name = "jadwal";
            jadwal.Size = new Size(78, 23);
            jadwal.TabIndex = 20;
            jadwal.UseVisualStyleBackColor = false;
            jadwal.Click += jadwal_Click;
            // 
            // infokelas
            // 
            infokelas.BackColor = Color.Transparent;
            infokelas.FlatAppearance.BorderSize = 0;
            infokelas.FlatStyle = FlatStyle.Flat;
            infokelas.Location = new Point(88, 196);
            infokelas.Name = "infokelas";
            infokelas.Size = new Size(103, 28);
            infokelas.TabIndex = 19;
            infokelas.UseVisualStyleBackColor = false;
            infokelas.Click += infokelas_Click;
            // 
            // profil
            // 
            profil.BackColor = Color.Transparent;
            profil.FlatAppearance.BorderSize = 0;
            profil.FlatStyle = FlatStyle.Flat;
            profil.Location = new Point(88, 154);
            profil.Name = "profil";
            profil.Size = new Size(59, 26);
            profil.TabIndex = 18;
            profil.UseVisualStyleBackColor = false;
            profil.Click += profil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 354);
            dataGridView1.TabIndex = 24;
            // 
            // V_Ruang_Kelas_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(dataGridView1);
            Controls.Add(logout);
            Controls.Add(gantijadwal);
            Controls.Add(ruangkelas);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(profil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Ruang_Kelas_Page";
            Text = "V_Info_Kelas_Page";
            Load += V_Ruang_Kelas_Page_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logout;
        private Button gantijadwal;
        private Button ruangkelas;
        private Button jadwal;
        private Button infokelas;
        private Button profil;
        private DataGridView dataGridView1;
    }
}