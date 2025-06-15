namespace PBO_KelD08.JAPRI.View
{
    partial class V_Landing_Page
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
            register = new Button();
            login = new Button();
            SuspendLayout();
            // 
            // register
            // 
            register.BackColor = Color.Transparent;
            register.FlatAppearance.BorderSize = 0;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.ForeColor = Color.White;
            register.Location = new Point(57, 348);
            register.Name = "register";
            register.Size = new Size(79, 32);
            register.TabIndex = 0;
            register.Text = "Sign Up";
            register.UseVisualStyleBackColor = false;
            register.Click += button1_Click;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(188, 346);
            login.Name = "login";
            login.Size = new Size(77, 33);
            login.TabIndex = 1;
            login.Text = "Sign In";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // V_Landing_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.polosan_bg_landing_page;
            ClientSize = new Size(960, 540);
            Controls.Add(login);
            Controls.Add(register);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Landing_Page";
            Text = "Landing_Page";
            Load += V_Landing_Page_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button register;
        private Button login;
    }
}