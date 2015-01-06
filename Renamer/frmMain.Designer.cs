namespace Renamer
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelper = new System.Windows.Forms.Button();
            this.btnRenameList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenameList);
            this.groupBox1.Controls.Add(this.btnHelper);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helpers";
            // 
            // btnHelper
            // 
            this.btnHelper.Location = new System.Drawing.Point(12, 19);
            this.btnHelper.Name = "btnHelper";
            this.btnHelper.Size = new System.Drawing.Size(122, 23);
            this.btnHelper.TabIndex = 1;
            this.btnHelper.Text = "Rename Helper";
            this.btnHelper.UseVisualStyleBackColor = true;
            this.btnHelper.Click += new System.EventHandler(this.btnHelper_Click);
            // 
            // btnRenameList
            // 
            this.btnRenameList.Location = new System.Drawing.Point(13, 51);
            this.btnRenameList.Name = "btnRenameList";
            this.btnRenameList.Size = new System.Drawing.Size(121, 23);
            this.btnRenameList.TabIndex = 2;
            this.btnRenameList.Text = "Rename Through List";
            this.btnRenameList.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Filename Helper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelper;
        private System.Windows.Forms.Button btnRenameList;
    }
}

