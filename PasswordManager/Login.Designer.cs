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
            this.loginButton = new System.Windows.Forms.Button();
            this.masterPasswordLabel = new System.Windows.Forms.Label();
            this.masterPasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(144, 141);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(121, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // masterPasswordLabel
            // 
            this.masterPasswordLabel.AutoSize = true;
            this.masterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.masterPasswordLabel.Location = new System.Drawing.Point(104, 45);
            this.masterPasswordLabel.Name = "masterPasswordLabel";
            this.masterPasswordLabel.Size = new System.Drawing.Size(208, 20);
            this.masterPasswordLabel.TabIndex = 1;
            this.masterPasswordLabel.Text = "Please enter your password:";
            // 
            // masterPasswordTB
            // 
            this.masterPasswordTB.Location = new System.Drawing.Point(63, 93);
            this.masterPasswordTB.Name = "masterPasswordTB";
            this.masterPasswordTB.Size = new System.Drawing.Size(282, 20);
            this.masterPasswordTB.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 216);
            this.Controls.Add(this.masterPasswordTB);
            this.Controls.Add(this.masterPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.Text = "Password Manager ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label masterPasswordLabel;
        private System.Windows.Forms.TextBox masterPasswordTB;
    }
}