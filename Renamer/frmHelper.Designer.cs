namespace Renamer
{
    partial class frmHelper
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
            this.btnReverseList = new System.Windows.Forms.Button();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.chkAddSeason = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverseList
            // 
            this.btnReverseList.Location = new System.Drawing.Point(16, 12);
            this.btnReverseList.Name = "btnReverseList";
            this.btnReverseList.Size = new System.Drawing.Size(129, 23);
            this.btnReverseList.TabIndex = 1;
            this.btnReverseList.Text = "Reverse List(From File)";
            this.btnReverseList.UseVisualStyleBackColor = true;
            this.btnReverseList.Click += new System.EventHandler(this.btnReverseList_Click);
            // 
            // txtFileContents
            // 
            this.txtFileContents.Location = new System.Drawing.Point(12, 98);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.Size = new System.Drawing.Size(408, 224);
            this.txtFileContents.TabIndex = 2;
            // 
            // chkAddSeason
            // 
            this.chkAddSeason.AutoSize = true;
            this.chkAddSeason.Location = new System.Drawing.Point(115, 53);
            this.chkAddSeason.Name = "chkAddSeason";
            this.chkAddSeason.Size = new System.Drawing.Size(124, 17);
            this.chkAddSeason.TabIndex = 9;
            this.chkAddSeason.Text = "Add Season Number";
            this.chkAddSeason.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Season";
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(62, 51);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(38, 20);
            this.txtSeason.TabIndex = 7;
            this.txtSeason.Text = "02";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Batch Rename Folders";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkAddSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.btnReverseList);
            this.Name = "frmHelper";
            this.Text = "frmHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverseList;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.CheckBox chkAddSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Button button1;
    }
}