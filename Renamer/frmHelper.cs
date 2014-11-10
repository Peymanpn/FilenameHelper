using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
    public partial class frmHelper : Form
    {
        public frmHelper()
        {
            InitializeComponent();
        }

        private void btnReverseList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                if (ofd.FileName != string.Empty)
                {
                    List<string> fileContents = new List<string>();

                    StreamReader sr = File.OpenText(ofd.FileName);

                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        if (str.StartsWith("Episode"))
                        {
                            
                            
                            str = str.Substring(8);//Episode string removing
                            str = str.Insert(2, "_");//adding _ after episode no
                            str = str.Insert(0, "E");
                            //season adding
                            str = str.Insert(0, "S" + txtSeason.Text);

                            //removing extra space after epidose no
                            str = str.Remove(7,1);
                            //adding to list
                            fileContents.Add(str);
                        }
                    }
                    
                    for (int i = fileContents.Count-1; i >=0;i-- )
                    {
                        txtFileContents.Text += fileContents[i];
                        if (i > 0) txtFileContents.Text += "\r\n";
                    }
                }
        }
    }
}
