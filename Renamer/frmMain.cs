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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHelper_Click(object sender, EventArgs e)
        {
            frmHelper HelperForm = new frmHelper();
            HelperForm.ShowDialog();
        }

    }
}
