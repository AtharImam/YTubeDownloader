using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTubeDownloader
{
    public partial class Form1 : Form
    {
        public string DownloadedUrl
        {
            get
            {
                return txtUrl.Text;
            }
        }

        public string DownloadPath
        {
            get
            {
                return txtPath.Text;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_ClickAsync(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (this.IsDefaultPath.Checked)
            {
                Shared.VideoPath = this.txtPath.Text;
            }

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.txtPath.Text = @"d:\personal";// Shared.VideoPath;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fldDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fldDialog.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void IsDefaultPath_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
