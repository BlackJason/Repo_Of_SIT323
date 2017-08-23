namespace SIT_323_Assignment_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bowserFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingCrozzleTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingErrorsTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Crozzle = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ErrorView = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bowserFileToolStripMenuItem,
            this.testingCrozzleTabToolStripMenuItem,
            this.testingErrorsTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bowserFileToolStripMenuItem
            // 
            this.bowserFileToolStripMenuItem.Name = "bowserFileToolStripMenuItem";
            this.bowserFileToolStripMenuItem.Size = new System.Drawing.Size(321, 38);
            this.bowserFileToolStripMenuItem.Text = "Bowser File";
            this.bowserFileToolStripMenuItem.Click += new System.EventHandler(this.bowserFileToolStripMenuItem_Click);
            // 
            // testingCrozzleTabToolStripMenuItem
            // 
            this.testingCrozzleTabToolStripMenuItem.Name = "testingCrozzleTabToolStripMenuItem";
            this.testingCrozzleTabToolStripMenuItem.Size = new System.Drawing.Size(321, 38);
            this.testingCrozzleTabToolStripMenuItem.Text = "Testing-Crozzle Tab";
            this.testingCrozzleTabToolStripMenuItem.Click += new System.EventHandler(this.testingCrozzleTabToolStripMenuItem_Click);
            // 
            // testingErrorsTabToolStripMenuItem
            // 
            this.testingErrorsTabToolStripMenuItem.Name = "testingErrorsTabToolStripMenuItem";
            this.testingErrorsTabToolStripMenuItem.Size = new System.Drawing.Size(321, 38);
            this.testingErrorsTabToolStripMenuItem.Text = "Testing-Errors Tab";
            this.testingErrorsTabToolStripMenuItem.Click += new System.EventHandler(this.testingErrorsTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(321, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 749);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Crozzle);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crozzle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Crozzle
            // 
            this.Crozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crozzle.Location = new System.Drawing.Point(3, 3);
            this.Crozzle.MinimumSize = new System.Drawing.Size(20, 20);
            this.Crozzle.Name = "Crozzle";
            this.Crozzle.Size = new System.Drawing.Size(1191, 696);
            this.Crozzle.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ErrorView);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ErrorView
            // 
            this.ErrorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorView.Location = new System.Drawing.Point(3, 3);
            this.ErrorView.MinimumSize = new System.Drawing.Size(20, 20);
            this.ErrorView.Name = "ErrorView";
            this.ErrorView.Size = new System.Drawing.Size(1191, 696);
            this.ErrorView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 792);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SIT 323 Assigment1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bowserFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingCrozzleTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingErrorsTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser Crozzle;
        private System.Windows.Forms.WebBrowser ErrorView;
    }
}

