using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public partial class FileUploadDrawer : BaseDrawer, IElementDesignDrawer
    {
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblPath;
        private Label lblLAbel;

        public FileUploadDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if (properties.ContainsKey("Label"))
                this.lblLAbel.Text = properties["Label"].ToString();
            if (properties.ContainsKey("UploadUrl"))
                this.lblPath.Text = properties["UploadUrl"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextboxDrawer_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.lblLAbel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLAbel
            // 
            this.lblLAbel.AutoSize = true;
            this.lblLAbel.Location = new System.Drawing.Point(16, 6);
            this.lblLAbel.Name = "lblLAbel";
            this.lblLAbel.Size = new System.Drawing.Size(40, 13);
            this.lblLAbel.TabIndex = 1;
            this.lblLAbel.Text = "LABEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Com.Wiseape.UtilityApp.CodeGenerator.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(17, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upload to ";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(129, 62);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 4;
            // 
            // FileUploadDrawer
            // 
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLAbel);
            this.Name = "FileUploadDrawer";
            this.Size = new System.Drawing.Size(599, 114);
            this.Load += new System.EventHandler(this.TextboxDrawer_Load_1);
            this.Resize += new System.EventHandler(this.FileUploadDrawer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxDrawer_Load_1(object sender, EventArgs e)
        {
            
        }

        private void FileUploadDrawer_Resize(object sender, EventArgs e)
        {
            //this.pictureBox1.Width = this.Width - 30;
            this.pictureBox1.Height = this.Height - 5;
        }
    }
}
