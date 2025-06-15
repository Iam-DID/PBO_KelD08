namespace PBO_KelD08.JAPRI.View
{
    partial class V_Ganti_Jadwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Ganti_Jadwal));
            dateTimePicker1 = new DateTimePicker();
            batal = new Button();
            ubah = new Button();
            logout = new Button();
            button3 = new Button();
            ruangkelas = new Button();
            jadwal = new Button();
            infokelas = new Button();
            Profil = new Button();
            ruangan = new ComboBox();
            jammulai = new ComboBox();
            button1 = new Button();
            jamselesai = new ComboBox();
            dataGridView1 = new DataGridView();
            topingbag = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonShadow;
            dateTimePicker1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(742, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 39);
            dateTimePicker1.TabIndex = 0;
            // 
            // batal
            // 
            batal.BackColor = Color.Transparent;
            batal.FlatAppearance.BorderSize = 0;
            batal.FlatStyle = FlatStyle.Flat;
            batal.Location = new Point(434, 446);
            batal.Name = "batal";
            batal.Size = new Size(96, 35);
            batal.TabIndex = 1;
            batal.UseVisualStyleBackColor = false;
            // 
            // ubah
            // 
            ubah.BackColor = Color.Transparent;
            ubah.BackgroundImage = (Image)resources.GetObject("ubah.BackgroundImage");
            ubah.FlatAppearance.BorderSize = 0;
            ubah.FlatStyle = FlatStyle.Flat;
            ubah.Location = new Point(744, 455);
            ubah.Name = "ubah";
            ubah.Size = new Size(148, 40);
            ubah.TabIndex = 2;
            ubah.UseVisualStyleBackColor = false;
            ubah.Click += ubah_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(87, 368);
            logout.Name = "logout";
            logout.Size = new Size(79, 23);
            logout.TabIndex = 23;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(87, 324);
            button3.Name = "button3";
            button3.Size = new Size(143, 23);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = false;
            // 
            // ruangkelas
            // 
            ruangkelas.BackColor = Color.Transparent;
            ruangkelas.FlatAppearance.BorderSize = 0;
            ruangkelas.FlatStyle = FlatStyle.Flat;
            ruangkelas.Location = new Point(88, 281);
            ruangkelas.Name = "ruangkelas";
            ruangkelas.Size = new Size(127, 23);
            ruangkelas.TabIndex = 21;
            ruangkelas.UseVisualStyleBackColor = false;
            ruangkelas.Click += ruangkelas_Click;
            // 
            // jadwal
            // 
            jadwal.BackColor = Color.Transparent;
            jadwal.FlatAppearance.BorderSize = 0;
            jadwal.FlatStyle = FlatStyle.Flat;
            jadwal.Location = new Point(88, 237);
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
            infokelas.Location = new Point(87, 196);
            infokelas.Name = "infokelas";
            infokelas.Size = new Size(104, 28);
            infokelas.TabIndex = 19;
            infokelas.UseVisualStyleBackColor = false;
            infokelas.Click += infokelas_Click;
            // 
            // Profil
            // 
            Profil.BackColor = Color.Transparent;
            Profil.FlatAppearance.BorderSize = 0;
            Profil.FlatStyle = FlatStyle.Flat;
            Profil.Location = new Point(87, 154);
            Profil.Name = "Profil";
            Profil.Size = new Size(59, 26);
            Profil.TabIndex = 18;
            Profil.UseVisualStyleBackColor = false;
            Profil.Click += button1_Click;
            // 
            // ruangan
            // 
            ruangan.FormattingEnabled = true;
            ruangan.Location = new Point(272, 94);
            ruangan.Name = "ruangan";
            ruangan.Size = new Size(121, 23);
            ruangan.TabIndex = 24;
            ruangan.Text = "--Pilih Kelas--";
            ruangan.SelectedIndexChanged += ruangan_SelectedIndexChanged;
            // 
            // jammulai
            // 
            jammulai.FormattingEnabled = true;
            jammulai.Location = new Point(619, 94);
            jammulai.Name = "jammulai";
            jammulai.Size = new Size(121, 23);
            jammulai.TabIndex = 25;
            jammulai.Text = "--Pilih Jam Awal--";
            jammulai.SelectedIndexChanged += jammulai_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(399, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // jamselesai
            // 
            jamselesai.FormattingEnabled = true;
            jamselesai.Location = new Point(771, 94);
            jamselesai.Name = "jamselesai";
            jamselesai.Size = new Size(121, 23);
            jamselesai.TabIndex = 27;
            jamselesai.Text = "--Jam Berakhir--";
            jamselesai.SelectedIndexChanged += jamselesai_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(620, 289);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // topingbag
            // 
            topingbag.AutoSize = true;
            topingbag.BackColor = Color.Transparent;
            topingbag.FlatStyle = FlatStyle.Flat;
            topingbag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topingbag.Location = new Point(749, 92);
            topingbag.Name = "topingbag";
            topingbag.Size = new Size(16, 21);
            topingbag.TabIndex = 29;
            topingbag.Text = "-";
            topingbag.Click += label1_Click;
            // 
            // V_Ganti_Jadwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(topingbag);
            Controls.Add(dataGridView1);
            Controls.Add(jamselesai);
            Controls.Add(button1);
            Controls.Add(jammulai);
            Controls.Add(ruangan);
            Controls.Add(logout);
            Controls.Add(button3);
            Controls.Add(ruangkelas);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(Profil);
            Controls.Add(ubah);
            Controls.Add(batal);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Ganti_Jadwal";
            Text = "Ganti_Jadwal";
            Load += V_Ganti_Jadwal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button batal;
        private Button ubah;
        private Button logout;
        private Button button3;
        private Button ruangkelas;
        private Button jadwal;
        private Button infokelas;
        private Button Profil;
        public DateTimePicker dateTimePicker1;
        public ComboBox ruangan;
        public ComboBox jammulai;
        private Button button1;
        public ComboBox jamselesai;
        private DataGridView dataGridView1;
        private Label topingbag;
    }
}