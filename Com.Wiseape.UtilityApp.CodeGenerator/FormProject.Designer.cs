namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    partial class FormProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.rdNewProject = new System.Windows.Forms.RadioButton();
            this.rdOpenProject = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(21, 66);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(294, 21);
            this.txtProjectName.TabIndex = 1;
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.Location = new System.Drawing.Point(21, 114);
            this.txtProjectDesc.Multiline = true;
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.Size = new System.Drawing.Size(294, 103);
            this.txtProjectDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Desc";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(21, 223);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(294, 23);
            this.btnOpenProject.TabIndex = 4;
            this.btnOpenProject.Text = "Open Existing Project";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Visible = false;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(21, 252);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(294, 23);
            this.btnCreateProject.TabIndex = 5;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // rdNewProject
            // 
            this.rdNewProject.AutoSize = true;
            this.rdNewProject.Checked = true;
            this.rdNewProject.Location = new System.Drawing.Point(21, 13);
            this.rdNewProject.Name = "rdNewProject";
            this.rdNewProject.Size = new System.Drawing.Size(83, 17);
            this.rdNewProject.TabIndex = 6;
            this.rdNewProject.TabStop = true;
            this.rdNewProject.Text = "New Project";
            this.rdNewProject.UseVisualStyleBackColor = true;
            this.rdNewProject.CheckedChanged += new System.EventHandler(this.rdNewProject_CheckedChanged);
            // 
            // rdOpenProject
            // 
            this.rdOpenProject.AutoSize = true;
            this.rdOpenProject.Location = new System.Drawing.Point(215, 13);
            this.rdOpenProject.Name = "rdOpenProject";
            this.rdOpenProject.Size = new System.Drawing.Size(88, 17);
            this.rdOpenProject.TabIndex = 7;
            this.rdOpenProject.Text = "Open Project";
            this.rdOpenProject.UseVisualStyleBackColor = true;
            this.rdOpenProject.CheckedChanged += new System.EventHandler(this.rdOpenProject_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(294, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdOpenProject);
            this.Controls.Add(this.rdNewProject);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.txtProjectDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormProject";
            this.Text = "Form Project";
            this.Load += new System.EventHandler(this.FormProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.RadioButton rdNewProject;
        private System.Windows.Forms.RadioButton rdOpenProject;
        private System.Windows.Forms.Button btnCancel;
    }
}