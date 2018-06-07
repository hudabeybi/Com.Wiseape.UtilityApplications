namespace Com.Wiseape.UtilityApp.FactoryConfigurator
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gridList = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClassDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Location = new System.Drawing.Point(12, 74);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(788, 21);
            this.txtFile.TabIndex = 0;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuration File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(806, 71);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(139, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gridList
            // 
            this.gridList.AllowUserToAddRows = false;
            this.gridList.AllowUserToDeleteRows = false;
            this.gridList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKey,
            this.ColDll,
            this.ColClassName,
            this.ColClassDesc});
            this.gridList.Location = new System.Drawing.Point(12, 155);
            this.gridList.Name = "gridList";
            this.gridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridList.Size = new System.Drawing.Size(933, 417);
            this.gridList.TabIndex = 3;
            // 
            // ColKey
            // 
            this.ColKey.DataPropertyName = "Key";
            this.ColKey.HeaderText = "Key";
            this.ColKey.Name = "ColKey";
            this.ColKey.Width = 200;
            // 
            // ColDll
            // 
            this.ColDll.DataPropertyName = "DllName";
            this.ColDll.HeaderText = "Dll File";
            this.ColDll.Name = "ColDll";
            this.ColDll.Width = 400;
            // 
            // ColClassName
            // 
            this.ColClassName.DataPropertyName = "ClassName";
            this.ColClassName.HeaderText = "Class Name";
            this.ColClassName.Name = "ColClassName";
            this.ColClassName.Width = 400;
            // 
            // ColClassDesc
            // 
            this.ColClassDesc.DataPropertyName = "ClassInfo";
            this.ColClassDesc.HeaderText = "Info";
            this.ColClassDesc.Name = "ColClassDesc";
            this.ColClassDesc.Width = 400;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Key";
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Location = new System.Drawing.Point(15, 125);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(238, 21);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saved Session";
            // 
            // cmbSession
            // 
            this.cmbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(13, 30);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(642, 21);
            this.cmbSession.TabIndex = 7;
            this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.cmbSession_SelectedIndexChanged);
            this.cmbSession.DataSourceChanged += new System.EventHandler(this.cmbSession_DataSourceChanged);
            this.cmbSession.SelectedValueChanged += new System.EventHandler(this.cmbSession_SelectedValueChanged);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Location = new System.Drawing.Point(661, 28);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(139, 23);
            this.btnSaveSession.TabIndex = 8;
            this.btnSaveSession.Text = "Save Session As";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Location = new System.Drawing.Point(806, 28);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteSession.TabIndex = 9;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(705, 125);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(240, 23);
            this.btnSaveXml.TabIndex = 10;
            this.btnSaveXml.Text = "Save Configuration List";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Location = new System.Drawing.Point(259, 125);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(222, 23);
            this.btnAddConfig.TabIndex = 11;
            this.btnAddConfig.Text = "Add Configuration";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete Configuration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.cmbSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Wiseape Factory Configurator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView gridList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClassDesc;
    }
}

