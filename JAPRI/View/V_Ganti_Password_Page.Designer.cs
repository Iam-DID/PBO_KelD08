namespace PBO_KelD08.JAPRI.View
{
    partial class V_Ganti_Password_Page
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
            password = new TextBox();
            newpassword = new TextBox();
            password_validation = new TextBox();
            batal = new Button();
            ubah = new Button();
            SuspendLayout();
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(79, 159);
            password.Name = "password";
            password.Size = new Size(339, 22);
            password.TabIndex = 0;
            password.TextChanged += textBox1_TextChanged;
            // 
            // newpassword
            // 
            newpassword.BorderStyle = BorderStyle.None;
            newpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpassword.Location = new Point(79, 228);
            newpassword.Name = "newpassword";
            newpassword.Size = new Size(339, 22);
            newpassword.TabIndex = 1;
            // 
            // password_validation
            // 
            password_validation.BorderStyle = BorderStyle.None;
            password_validation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_validation.Location = new Point(79, 296);
            password_validation.Name = "password_validation";
            password_validation.Size = new Size(339, 22);
            password_validation.TabIndex = 2;
            // 
            // batal
            // 
            batal.BackColor = Color.Transparent;
            batal.FlatAppearance.BorderSize = 0;
            batal.FlatStyle = FlatStyle.Flat;
            batal.Location = new Point(72, 369);
            batal.Name = "batal";
            batal.Size = new Size(146, 38);
            batal.TabIndex = 3;
            batal.UseVisualStyleBackColor = false;
            batal.Click += ubah_Click;
            // 
            // ubah
            // 
            ubah.BackColor = Color.Transparent;
            ubah.FlatAppearance.BorderSize = 0;
            ubah.FlatStyle = FlatStyle.Flat;
            ubah.Location = new Point(268, 369);
            ubah.Name = "ubah";
            ubah.Size = new Size(138, 38);
            ubah.TabIndex = 4;
            ubah.UseVisualStyleBackColor = false;
            ubah.Click += ubah_Click_1;
            // 
            // V_Ganti_Password_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ganti_Password;
            ClientSize = new Size(491, 467);
            Controls.Add(ubah);
            Controls.Add(batal);
            Controls.Add(password_validation);
            Controls.Add(newpassword);
            Controls.Add(password);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Ganti_Password_Page";
            Text = "V_Ganti_Password_Page";
            Load += V_Ganti_Password_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordbaru;
        private Button batal;
        private Button ubah;
        public TextBox password;
        public TextBox newpassword;
        public TextBox password_validation;
    }
}