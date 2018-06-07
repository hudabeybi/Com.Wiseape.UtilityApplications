namespace Com.Wiseape.UtilityApp.MainApplication
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoryConfiguratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.applicationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.applicationToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factoryConfiguratorToolStripMenuItem,
            this.codeGeneratorToolStripMenuItem,
            this.uIDesignerToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // factoryConfiguratorToolStripMenuItem
            // 
            this.factoryConfiguratorToolStripMenuItem.Name = "factoryConfiguratorToolStripMenuItem";
            this.factoryConfiguratorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.factoryConfiguratorToolStripMenuItem.Text = "Factory Configurator";
            this.factoryConfiguratorToolStripMenuItem.Click += new System.EventHandler(this.factoryConfiguratorToolStripMenuItem_Click);
            // 
            // codeGeneratorToolStripMenuItem
            // 
            this.codeGeneratorToolStripMenuItem.Name = "codeGeneratorToolStripMenuItem";
            this.codeGeneratorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.codeGeneratorToolStripMenuItem.Text = "Code Generator";
            this.codeGeneratorToolStripMenuItem.Click += new System.EventHandler(this.codeGeneratorToolStripMenuItem_Click);
            // 
            // uIDesignerToolStripMenuItem
            // 
            this.uIDesignerToolStripMenuItem.Name = "uIDesignerToolStripMenuItem";
            this.uIDesignerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.uIDesignerToolStripMenuItem.Text = "UI Designer";
            this.uIDesignerToolStripMenuItem.Click += new System.EventHandler(this.uIDesignerToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 492);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Wiseape Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoryConfiguratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIDesignerToolStripMenuItem;
    }
}

