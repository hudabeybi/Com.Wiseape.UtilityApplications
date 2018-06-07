namespace Com.Wiseape.UtilityApp.CodeGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSavedConnection = new System.Windows.Forms.ComboBox();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.btnDeleteConnection = new System.Windows.Forms.Button();
            this.cmbModelType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDatasource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.tvProjectItems = new System.Windows.Forms.TreeView();
            this.ctxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.editModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.generateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSessionModule = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ctxMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupSessionModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // cmbSavedConnection
            // 
            this.cmbSavedConnection.FormattingEnabled = true;
            this.cmbSavedConnection.Location = new System.Drawing.Point(6, 31);
            this.cmbSavedConnection.Name = "cmbSavedConnection";
            this.cmbSavedConnection.Size = new System.Drawing.Size(716, 21);
            this.cmbSavedConnection.TabIndex = 1;
            this.cmbSavedConnection.SelectedIndexChanged += new System.EventHandler(this.cmbSavedConnection_SelectedIndexChanged);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(729, 31);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(108, 23);
            this.btnAddConnection.TabIndex = 2;
            this.btnAddConnection.Text = "Add Connection";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // btnDeleteConnection
            // 
            this.btnDeleteConnection.Location = new System.Drawing.Point(833, 31);
            this.btnDeleteConnection.Name = "btnDeleteConnection";
            this.btnDeleteConnection.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteConnection.TabIndex = 3;
            this.btnDeleteConnection.Text = "Delete Connection";
            this.btnDeleteConnection.UseVisualStyleBackColor = true;
            this.btnDeleteConnection.Click += new System.EventHandler(this.btnDeleteConnection_Click);
            // 
            // cmbModelType
            // 
            this.cmbModelType.FormattingEnabled = true;
            this.cmbModelType.Location = new System.Drawing.Point(6, 128);
            this.cmbModelType.Name = "cmbModelType";
            this.cmbModelType.Size = new System.Drawing.Size(452, 21);
            this.cmbModelType.TabIndex = 4;
            this.cmbModelType.SelectedIndexChanged += new System.EventHandler(this.cmbModelType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model Type";
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Location = new System.Drawing.Point(6, 235);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(930, 396);
            this.formPanel.TabIndex = 7;
            this.formPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.formPanel_ControlAdded);
            this.formPanel.Resize += new System.EventHandler(this.formPanel_Resize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datasource";
            // 
            // cmbDatasource
            // 
            this.cmbDatasource.FormattingEnabled = true;
            this.cmbDatasource.Location = new System.Drawing.Point(481, 128);
            this.cmbDatasource.Name = "cmbDatasource";
            this.cmbDatasource.Size = new System.Drawing.Size(430, 21);
            this.cmbDatasource.TabIndex = 9;
            this.cmbDatasource.SelectedIndexChanged += new System.EventHandler(this.cmbDatasource_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Namespace";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(9, 178);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(449, 21);
            this.txtNamespace.TabIndex = 11;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(482, 177);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(429, 21);
            this.txtClassName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Class Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProjectName.Location = new System.Drawing.Point(6, 87);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(452, 21);
            this.txtProjectName.TabIndex = 17;
            this.txtProjectName.Text = "ERP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Module Name";
            // 
            // txtModuleName
            // 
            this.txtModuleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModuleName.Location = new System.Drawing.Point(481, 87);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(429, 21);
            this.txtModuleName.TabIndex = 19;
            this.txtModuleName.Text = "HR";
            // 
            // tvProjectItems
            // 
            this.tvProjectItems.ContextMenuStrip = this.ctxMenuStrip;
            this.tvProjectItems.Location = new System.Drawing.Point(8, 27);
            this.tvProjectItems.Name = "tvProjectItems";
            this.tvProjectItems.Size = new System.Drawing.Size(284, 625);
            this.tvProjectItems.TabIndex = 20;
            this.tvProjectItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProjectItems_AfterSelect);
            // 
            // ctxMenuStrip
            // 
            this.ctxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewModuleToolStripMenuItem,
            this.toolStripMenuItem5,
            this.editProjectToolStripMenuItem,
            this.toolStripMenuItem6,
            this.editModuleToolStripMenuItem,
            this.deleteModuleToolStripMenuItem});
            this.ctxMenuStrip.Name = "ctxMenuStrip";
            this.ctxMenuStrip.Size = new System.Drawing.Size(180, 104);
            // 
            // createNewModuleToolStripMenuItem
            // 
            this.createNewModuleToolStripMenuItem.Name = "createNewModuleToolStripMenuItem";
            this.createNewModuleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.createNewModuleToolStripMenuItem.Text = "Create New Module";
            this.createNewModuleToolStripMenuItem.Click += new System.EventHandler(this.createNewModuleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(176, 6);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.editProjectToolStripMenuItem.Text = "Edit Project";
            this.editProjectToolStripMenuItem.Click += new System.EventHandler(this.editProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(176, 6);
            // 
            // editModuleToolStripMenuItem
            // 
            this.editModuleToolStripMenuItem.Name = "editModuleToolStripMenuItem";
            this.editModuleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.editModuleToolStripMenuItem.Text = "Edit Module";
            this.editModuleToolStripMenuItem.Click += new System.EventHandler(this.editModuleToolStripMenuItem_Click);
            // 
            // deleteModuleToolStripMenuItem
            // 
            this.deleteModuleToolStripMenuItem.Name = "deleteModuleToolStripMenuItem";
            this.deleteModuleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteModuleToolStripMenuItem.Text = "Delete Module";
            this.deleteModuleToolStripMenuItem.Click += new System.EventHandler(this.deleteModuleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.moduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem3.Text = "Save As...";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.generateCodeToolStripMenuItem});
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // createNewToolStripMenuItem1
            // 
            this.createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            this.createNewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createNewToolStripMenuItem1.Text = "Create New";
            this.createNewToolStripMenuItem1.Click += new System.EventHandler(this.createNewToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generateCodeToolStripMenuItem.Text = "Generate Code";
            this.generateCodeToolStripMenuItem.Click += new System.EventHandler(this.generateCodeToolStripMenuItem_Click);
            // 
            // groupSessionModule
            // 
            this.groupSessionModule.Controls.Add(this.btnRefresh);
            this.groupSessionModule.Controls.Add(this.label1);
            this.groupSessionModule.Controls.Add(this.cmbSavedConnection);
            this.groupSessionModule.Controls.Add(this.txtModuleName);
            this.groupSessionModule.Controls.Add(this.btnAddConnection);
            this.groupSessionModule.Controls.Add(this.label8);
            this.groupSessionModule.Controls.Add(this.btnDeleteConnection);
            this.groupSessionModule.Controls.Add(this.txtProjectName);
            this.groupSessionModule.Controls.Add(this.cmbModelType);
            this.groupSessionModule.Controls.Add(this.label7);
            this.groupSessionModule.Controls.Add(this.label2);
            this.groupSessionModule.Controls.Add(this.txtClassName);
            this.groupSessionModule.Controls.Add(this.formPanel);
            this.groupSessionModule.Controls.Add(this.label5);
            this.groupSessionModule.Controls.Add(this.label3);
            this.groupSessionModule.Controls.Add(this.txtNamespace);
            this.groupSessionModule.Controls.Add(this.cmbDatasource);
            this.groupSessionModule.Controls.Add(this.label4);
            this.groupSessionModule.Location = new System.Drawing.Point(298, 27);
            this.groupSessionModule.Name = "groupSessionModule";
            this.groupSessionModule.Size = new System.Drawing.Size(945, 647);
            this.groupSessionModule.TabIndex = 22;
            this.groupSessionModule.TabStop = false;
            this.groupSessionModule.Text = "Session Module";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(856, 208);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 596);
            this.Controls.Add(this.groupSessionModule);
            this.Controls.Add(this.tvProjectItems);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.ctxMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupSessionModule.ResumeLayout(false);
            this.groupSessionModule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSavedConnection;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.Button btnDeleteConnection;
        private System.Windows.Forms.ComboBox cmbModelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDatasource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TreeView tvProjectItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupSessionModule;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem generateCodeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createNewModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem editModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteModuleToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}

