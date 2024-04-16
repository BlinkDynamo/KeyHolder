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
            System.Windows.Forms.GroupBox listingEntriesGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.removeEntryB = new System.Windows.Forms.Button();
            this.entriesLB = new System.Windows.Forms.ListBox();
            this.refreshB = new System.Windows.Forms.Button();
            this.addEntryB = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.usernameEntryL = new System.Windows.Forms.Label();
            this.passwordEntryL = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.clearEntryB = new System.Windows.Forms.Button();
            listingEntriesGroupBox = new System.Windows.Forms.GroupBox();
            listingEntriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listingEntriesGroupBox
            // 
            listingEntriesGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            listingEntriesGroupBox.BackgroundImage = global::PasswordManager.Properties.Resources.royalitems;
            listingEntriesGroupBox.Controls.Add(this.removeEntryB);
            listingEntriesGroupBox.Controls.Add(this.entriesLB);
            listingEntriesGroupBox.Controls.Add(this.refreshB);
            listingEntriesGroupBox.Location = new System.Drawing.Point(0, 77);
            listingEntriesGroupBox.Name = "listingEntriesGroupBox";
            listingEntriesGroupBox.Size = new System.Drawing.Size(655, 316);
            listingEntriesGroupBox.TabIndex = 14;
            listingEntriesGroupBox.TabStop = false;
            listingEntriesGroupBox.Text = "Entries";
            // 
            // removeEntryB
            // 
            this.removeEntryB.Location = new System.Drawing.Point(574, 53);
            this.removeEntryB.Name = "removeEntryB";
            this.removeEntryB.Size = new System.Drawing.Size(70, 28);
            this.removeEntryB.TabIndex = 14;
            this.removeEntryB.Text = "Remove";
            this.removeEntryB.UseVisualStyleBackColor = true;
            this.removeEntryB.Click += new System.EventHandler(this.removeEntryB_Click);
            // 
            // entriesLB
            // 
            this.entriesLB.BackColor = System.Drawing.SystemColors.Window;
            this.entriesLB.FormattingEnabled = true;
            this.entriesLB.Location = new System.Drawing.Point(12, 19);
            this.entriesLB.Name = "entriesLB";
            this.entriesLB.Size = new System.Drawing.Size(546, 277);
            this.entriesLB.TabIndex = 8;
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(575, 19);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(69, 28);
            this.refreshB.TabIndex = 13;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // addEntryB
            // 
            this.addEntryB.Location = new System.Drawing.Point(575, 12);
            this.addEntryB.Name = "addEntryB";
            this.addEntryB.Size = new System.Drawing.Size(69, 27);
            this.addEntryB.TabIndex = 1;
            this.addEntryB.Text = "Add Entry";
            this.addEntryB.UseVisualStyleBackColor = true;
            this.addEntryB.Click += new System.EventHandler(this.addEntryB_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(203, 32);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(166, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // usernameEntryL
            // 
            this.usernameEntryL.AutoSize = true;
            this.usernameEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameEntryL.Location = new System.Drawing.Point(249, 11);
            this.usernameEntryL.Name = "usernameEntryL";
            this.usernameEntryL.Size = new System.Drawing.Size(77, 17);
            this.usernameEntryL.TabIndex = 4;
            this.usernameEntryL.Text = "Username:";
            // 
            // passwordEntryL
            // 
            this.passwordEntryL.AutoSize = true;
            this.passwordEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordEntryL.Location = new System.Drawing.Point(443, 11);
            this.passwordEntryL.Name = "passwordEntryL";
            this.passwordEntryL.Size = new System.Drawing.Size(73, 17);
            this.passwordEntryL.TabIndex = 6;
            this.passwordEntryL.Text = "Password:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(392, 32);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(166, 20);
            this.passwordTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(56, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID (Name):";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(12, 32);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(166, 20);
            this.idTB.TabIndex = 10;
            // 
            // clearEntryB
            // 
            this.clearEntryB.Location = new System.Drawing.Point(575, 45);
            this.clearEntryB.Name = "clearEntryB";
            this.clearEntryB.Size = new System.Drawing.Size(69, 26);
            this.clearEntryB.TabIndex = 12;
            this.clearEntryB.Text = "Clear";
            this.clearEntryB.UseVisualStyleBackColor = true;
            this.clearEntryB.Click += new System.EventHandler(this.clearEntryB_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(656, 393);
            this.Controls.Add(listingEntriesGroupBox);
            this.Controls.Add(this.clearEntryB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordEntryL);
            this.Controls.Add(this.usernameEntryL);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.addEntryB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "KeyHolder - Dashboard";
            listingEntriesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addEntryB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label usernameEntryL;
        private System.Windows.Forms.Label passwordEntryL;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ListBox entriesLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button clearEntryB;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Button removeEntryB;
    }
}