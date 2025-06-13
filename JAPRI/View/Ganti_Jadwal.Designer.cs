namespace PBO_KelD08.JAPRI.View
{
    partial class Ganti_Jadwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ganti_Jadwal));
            dateTimePicker1 = new DateTimePicker();
            batal = new Button();
            ubah = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            jadwal = new Button();
            infokelas = new Button();
            button1 = new Button();
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
            ubah.FlatAppearance.BorderSize = 0;
            ubah.FlatStyle = FlatStyle.Flat;
            ubah.Location = new Point(638, 446);
            ubah.Name = "ubah";
            ubah.Size = new Size(96, 35);
            ubah.TabIndex = 2;
            ubah.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(87, 368);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 23;
            button4.UseVisualStyleBackColor = false;
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
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(88, 281);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(87, 154);
            button1.Name = "button1";
            button1.Size = new Size(59, 26);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // Ganti_Jadwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(button1);
            Controls.Add(ubah);
            Controls.Add(batal);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ganti_Jadwal";
            Text = "Ganti_Jadwal";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button batal;
        private Button ubah;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button jadwal;
        private Button infokelas;
        private Button button1;
    }
}