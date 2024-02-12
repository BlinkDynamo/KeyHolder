namespace PasswordManager
{
    partial class Dashboard
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
            this.displayEntriesB = new System.Windows.Forms.Button();
            this.enterPasswordB = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.usernameEntryL = new System.Windows.Forms.Label();
            this.passwordEntryL = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.entriesLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayEntriesB
            // 
            this.displayEntriesB.Location = new System.Drawing.Point(411, 263);
            this.displayEntriesB.Name = "displayEntriesB";
            this.displayEntriesB.Size = new System.Drawing.Size(90, 23);
            this.displayEntriesB.TabIndex = 0;
            this.displayEntriesB.Text = "Display";
            this.displayEntriesB.UseVisualStyleBackColor = true;
            this.displayEntriesB.Click += new System.EventHandler(this.displayEntriesB_Click);
            // 
            // enterPasswordB
            // 
            this.enterPasswordB.Location = new System.Drawing.Point(411, 78);
            this.enterPasswordB.Name = "enterPasswordB";
            this.enterPasswordB.Size = new System.Drawing.Size(90, 23);
            this.enterPasswordB.TabIndex = 1;
            this.enterPasswordB.Text = "Add Entry";
            this.enterPasswordB.UseVisualStyleBackColor = true;
            this.enterPasswordB.Click += new System.EventHandler(this.enterPasswordB_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(28, 80);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(148, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // usernameEntryL
            // 
            this.usernameEntryL.AutoSize = true;
            this.usernameEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameEntryL.Location = new System.Drawing.Point(61, 49);
            this.usernameEntryL.Name = "usernameEntryL";
            this.usernameEntryL.Size = new System.Drawing.Size(77, 17);
            this.usernameEntryL.TabIndex = 4;
            this.usernameEntryL.Text = "Username:";
            // 
            // passwordEntryL
            // 
            this.passwordEntryL.AutoSize = true;
            this.passwordEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordEntryL.Location = new System.Drawing.Point(261, 49);
            this.passwordEntryL.Name = "passwordEntryL";
            this.passwordEntryL.Size = new System.Drawing.Size(73, 17);
            this.passwordEntryL.TabIndex = 6;
            this.passwordEntryL.Text = "Password:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(221, 80);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(148, 20);
            this.passwordTB.TabIndex = 7;
            // 
            // entriesLB
            // 
            this.entriesLB.FormattingEnabled = true;
            this.entriesLB.Location = new System.Drawing.Point(28, 152);
            this.entriesLB.Name = "entriesLB";
            this.entriesLB.Size = new System.Drawing.Size(341, 134);
            this.entriesLB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(396, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Display all entries:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entriesLB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordEntryL);
            this.Controls.Add(this.usernameEntryL);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.enterPasswordB);
            this.Controls.Add(this.displayEntriesB);
            this.Name = "Dashboard";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayEntriesB;
        private System.Windows.Forms.Button enterPasswordB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label usernameEntryL;
        private System.Windows.Forms.Label passwordEntryL;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ListBox entriesLB;
        private System.Windows.Forms.Label label1;
    }
}