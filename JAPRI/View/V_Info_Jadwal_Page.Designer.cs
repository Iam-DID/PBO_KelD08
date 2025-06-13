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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Info_Jadwal_Page));
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            ruangkelas = new Button();
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
            dateTimePicker1.TabIndex = 1;
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
            // V_Info_Jadwal_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(ruangkelas);
            Controls.Add(jadwal);
            Controls.Add(infokelas);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Info_Jadwal_Page";
            Text = "V_Info_Jadwal_Page";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private Button ruangkelas;
        private Button jadwal;
        private Button infokelas;
        private Button button1;
    }
}