﻿namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class TableCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TableCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "TableCell";
            this.Size = new System.Drawing.Size(148, 87);
            this.Load += new System.EventHandler(this.TableCell_Load);
            this.Click += new System.EventHandler(this.TableCell_Click);
            this.DoubleClick += new System.EventHandler(this.TableCell_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}