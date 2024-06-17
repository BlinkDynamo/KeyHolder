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
            this.haveAccountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(176, 76);
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
            this.masterPasswordLabel.Location = new System.Drawing.Point(126, 13);
            this.masterPasswordLabel.Name = "masterPasswordLabel";
            this.masterPasswordLabel.Size = new System.Drawing.Size(176, 16);
            this.masterPasswordLabel.TabIndex = 1;
            this.masterPasswordLabel.Text = "Enter your master password:";
            // 
            // MpasswordTB
            // 
            this.MpasswordTB.Location = new System.Drawing.Point(49, 41);
            this.MpasswordTB.Name = "MpasswordTB";
            this.MpasswordTB.Size = new System.Drawing.Size(324, 20);
            this.MpasswordTB.TabIndex = 2;
            this.MpasswordTB.TextChanged += new System.EventHandler(this.MpasswordTB_TextChanged);
            this.MpasswordTB.Enter += new System.EventHandler(this.MpasswordTB_Enter);
            this.MpasswordTB.Leave += new System.EventHandler(this.MpasswordTB_TextChanged);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.Location = new System.Drawing.Point(34, 31);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(218, 16);
            this.createAccountLabel.TabIndex = 3;
            this.createAccountLabel.Text = "Don\'t have an account? Create one:";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(286, 31);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // haveAccountLabel
            // 
            this.haveAccountLabel.AutoSize = true;
            this.haveAccountLabel.Location = new System.Drawing.Point(268, 15);
            this.haveAccountLabel.Name = "haveAccountLabel";
            this.haveAccountLabel.Size = new System.Drawing.Size(108, 13);
            this.haveAccountLabel.TabIndex = 5;
            this.haveAccountLabel.Text = "you have an account";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createAccountLabel);
            this.groupBox1.Controls.Add(this.haveAccountLabel);
            this.groupBox1.Controls.Add(this.createAccountButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MpasswordTB);
            this.Controls.Add(this.masterPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "KeyHolder - Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label masterPasswordLabel;
        private System.Windows.Forms.TextBox MpasswordTB;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label haveAccountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}