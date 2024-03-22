namespace PasswordManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.Button();
            this.masterPasswordLabel = new System.Windows.Forms.Label();
            this.MpasswordTB = new System.Windows.Forms.TextBox();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(176, 81);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // masterPasswordLabel
            // 
            this.masterPasswordLabel.AutoSize = true;
            this.masterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPasswordLabel.Location = new System.Drawing.Point(67, 9);
            this.masterPasswordLabel.Name = "masterPasswordLabel";
            this.masterPasswordLabel.Size = new System.Drawing.Size(292, 16);
            this.masterPasswordLabel.TabIndex = 1;
            this.masterPasswordLabel.Text = "login to your account with your master password:";
            // 
            // MpasswordTB
            // 
            this.MpasswordTB.Location = new System.Drawing.Point(42, 46);
            this.MpasswordTB.Name = "MpasswordTB";
            this.MpasswordTB.Size = new System.Drawing.Size(338, 20);
            this.MpasswordTB.TabIndex = 2;
            this.MpasswordTB.TextChanged += new System.EventHandler(this.MpasswordTB_TextChanged);
            this.MpasswordTB.Enter += new System.EventHandler(this.MpasswordTB_Enter);
            this.MpasswordTB.Leave += new System.EventHandler(this.MpasswordTB_TextChanged);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.Location = new System.Drawing.Point(39, 130);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(248, 16);
            this.createAccountLabel.TabIndex = 3;
            this.createAccountLabel.Text = "Don\'t have an account? Create one here:";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(305, 127);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 163);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.MpasswordTB);
            this.Controls.Add(this.masterPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "KeyHolder - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label masterPasswordLabel;
        private System.Windows.Forms.TextBox MpasswordTB;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Button createAccountButton;
    }
}