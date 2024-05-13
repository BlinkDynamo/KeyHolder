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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordEntryL = new System.Windows.Forms.Label();
            this.addEntryB = new System.Windows.Forms.Button();
            this.usernameEntryL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshB = new System.Windows.Forms.Button();
            this.entriesLB = new System.Windows.Forms.ListBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.removeEntryB = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.clearEntryB = new System.Windows.Forms.Button();
            this.mainMenuTP = new System.Windows.Forms.TabControl();
            this.settingsTP = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage.SuspendLayout();
            this.mainMenuTP.SuspendLayout();
            this.settingsTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Settings";
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.Color.Silver;
            this.tabPage.Controls.Add(this.clearEntryB);
            this.tabPage.Controls.Add(this.idTB);
            this.tabPage.Controls.Add(this.usernameTB);
            this.tabPage.Controls.Add(this.passwordTB);
            this.tabPage.Controls.Add(this.removeEntryB);
            this.tabPage.Controls.Add(this.entriesLB);
            this.tabPage.Controls.Add(this.refreshB);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.usernameEntryL);
            this.tabPage.Controls.Add(this.addEntryB);
            this.tabPage.Controls.Add(this.passwordEntryL);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(659, 397);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Passwords";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(393, 34);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(166, 20);
            this.passwordTB.TabIndex = 7;
            // 
            // passwordEntryL
            // 
            this.passwordEntryL.AutoSize = true;
            this.passwordEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordEntryL.Location = new System.Drawing.Point(447, 13);
            this.passwordEntryL.Name = "passwordEntryL";
            this.passwordEntryL.Size = new System.Drawing.Size(73, 17);
            this.passwordEntryL.TabIndex = 6;
            this.passwordEntryL.Text = "Password:";
            // 
            // addEntryB
            // 
            this.addEntryB.Location = new System.Drawing.Point(576, 30);
            this.addEntryB.Name = "addEntryB";
            this.addEntryB.Size = new System.Drawing.Size(68, 27);
            this.addEntryB.TabIndex = 1;
            this.addEntryB.Text = "Add Entry";
            this.addEntryB.UseVisualStyleBackColor = true;
            this.addEntryB.Click += new System.EventHandler(this.addEntryB_Click);
            // 
            // usernameEntryL
            // 
            this.usernameEntryL.AutoSize = true;
            this.usernameEntryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameEntryL.Location = new System.Drawing.Point(241, 13);
            this.usernameEntryL.Name = "usernameEntryL";
            this.usernameEntryL.Size = new System.Drawing.Size(77, 17);
            this.usernameEntryL.TabIndex = 4;
            this.usernameEntryL.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID (Name):";
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(576, 163);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(68, 28);
            this.refreshB.TabIndex = 13;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // entriesLB
            // 
            this.entriesLB.BackColor = System.Drawing.SystemColors.Window;
            this.entriesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesLB.FormattingEnabled = true;
            this.entriesLB.ItemHeight = 15;
            this.entriesLB.Location = new System.Drawing.Point(13, 65);
            this.entriesLB.Name = "entriesLB";
            this.entriesLB.Size = new System.Drawing.Size(546, 319);
            this.entriesLB.TabIndex = 8;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(201, 34);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(166, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // removeEntryB
            // 
            this.removeEntryB.Location = new System.Drawing.Point(576, 249);
            this.removeEntryB.Name = "removeEntryB";
            this.removeEntryB.Size = new System.Drawing.Size(68, 28);
            this.removeEntryB.TabIndex = 14;
            this.removeEntryB.Text = "Remove";
            this.removeEntryB.UseVisualStyleBackColor = true;
            this.removeEntryB.Click += new System.EventHandler(this.removeEntryB_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(13, 34);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(166, 20);
            this.idTB.TabIndex = 10;
            // 
            // clearEntryB
            // 
            this.clearEntryB.Location = new System.Drawing.Point(576, 208);
            this.clearEntryB.Name = "clearEntryB";
            this.clearEntryB.Size = new System.Drawing.Size(69, 26);
            this.clearEntryB.TabIndex = 12;
            this.clearEntryB.Text = "Clear";
            this.clearEntryB.UseVisualStyleBackColor = true;
            this.clearEntryB.Click += new System.EventHandler(this.clearEntryB_Click);
            // 
            // mainMenuTP
            // 
            this.mainMenuTP.Controls.Add(this.tabPage);
            this.mainMenuTP.Controls.Add(this.settingsTP);
            this.mainMenuTP.Controls.Add(this.tabPage1);
            this.mainMenuTP.Location = new System.Drawing.Point(8, 9);
            this.mainMenuTP.Name = "mainMenuTP";
            this.mainMenuTP.SelectedIndex = 0;
            this.mainMenuTP.Size = new System.Drawing.Size(667, 423);
            this.mainMenuTP.TabIndex = 16;
            // 
            // settingsTP
            // 
            this.settingsTP.BackColor = System.Drawing.Color.Silver;
            this.settingsTP.Controls.Add(this.richTextBox1);
            this.settingsTP.Location = new System.Drawing.Point(4, 22);
            this.settingsTP.Name = "settingsTP";
            this.settingsTP.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTP.Size = new System.Drawing.Size(659, 397);
            this.settingsTP.TabIndex = 1;
            this.settingsTP.Text = "Notes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(647, 385);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(683, 440);
            this.Controls.Add(this.mainMenuTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "KeyHolder - Dashboard";
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.mainMenuTP.ResumeLayout(false);
            this.settingsTP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Button clearEntryB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button removeEntryB;
        private System.Windows.Forms.ListBox entriesLB;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameEntryL;
        private System.Windows.Forms.Button addEntryB;
        private System.Windows.Forms.Label passwordEntryL;
        private System.Windows.Forms.TabControl mainMenuTP;
        private System.Windows.Forms.TabPage settingsTP;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}