namespace PBO_KelD08.JAPRI.View
{
    partial class V_Setting_Profile_page
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
            nama = new Label();
            prodi = new Label();
            nim = new Label();
            kelaspraktikum = new ComboBox();
            ubah = new Button();
            batal = new Button();
            SuspendLayout();
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.BackColor = Color.Transparent;
            nama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nama.Location = new Point(81, 128);
            nama.Name = "nama";
            nama.Size = new Size(201, 21);
            nama.TabIndex = 0;
            nama.Text = "Muhamad Rohmad Hidayat";
            nama.Click += label1_Click;
            // 
            // prodi
            // 
            prodi.AutoSize = true;
            prodi.BackColor = Color.Transparent;
            prodi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodi.Location = new Point(81, 197);
            prodi.Name = "prodi";
            prodi.Size = new Size(90, 21);
            prodi.TabIndex = 1;
            prodi.Text = "informatika";
            // 
            // nim
            // 
            nim.AutoSize = true;
            nim.BackColor = Color.Transparent;
            nim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nim.Location = new Point(81, 265);
            nim.Name = "nim";
            nim.Size = new Size(118, 21);
            nim.TabIndex = 2;
            nim.Text = "242410103016";
            // 
            // kelaspraktikum
            // 
            kelaspraktikum.FlatStyle = FlatStyle.Flat;
            kelaspraktikum.FormattingEnabled = true;
            kelaspraktikum.Location = new Point(79, 334);
            kelaspraktikum.Name = "kelaspraktikum";
            kelaspraktikum.Size = new Size(331, 23);
            kelaspraktikum.TabIndex = 3;
            kelaspraktikum.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ubah
            // 
            ubah.BackColor = Color.Transparent;
            ubah.FlatAppearance.BorderSize = 0;
            ubah.FlatStyle = FlatStyle.Flat;
            ubah.Location = new Point(271, 390);
            ubah.Name = "ubah";
            ubah.Size = new Size(142, 41);
            ubah.TabIndex = 6;
            ubah.UseVisualStyleBackColor = false;
            // 
            // batal
            // 
            batal.BackColor = Color.Transparent;
            batal.FlatAppearance.BorderSize = 0;
            batal.FlatStyle = FlatStyle.Flat;
            batal.Location = new Point(79, 390);
            batal.Name = "batal";
            batal.Size = new Size(146, 41);
            batal.TabIndex = 5;
            batal.UseVisualStyleBackColor = false;
            // 
            // V_Setting_Profile_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Setting_Profile;
            ClientSize = new Size(491, 467);
            Controls.Add(ubah);
            Controls.Add(batal);
            Controls.Add(kelaspraktikum);
            Controls.Add(nim);
            Controls.Add(prodi);
            Controls.Add(nama);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Setting_Profile_page";
            Text = "V_Setting_Profile_page";
            Load += V_Setting_Profile_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nama;
        private Label prodi;
        private Label nim;
        private ComboBox kelaspraktikum;
        private Button ubah;
        private Button batal;
    }
}