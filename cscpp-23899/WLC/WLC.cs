using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Converters;

namespace WLC
{
    public partial class WLC : Form
    {
        public WLC()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(SrcDirTB.Text, "*.cs", SearchOption.AllDirectories);

            foreach( string file in files)
            {
                string CsDir = Path.GetDirectoryName(file);
                string filename = Path.GetFileName(file);

                try
                {
                    SharpToCppConverter.ConvertFile(filename, CsDir, CsDir, WinRTTB.Text);
                }
                catch( Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("All Files Converted");
        }

        private void SrcDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog srcdir = new FolderBrowserDialog();
            if( srcdir.ShowDialog() == DialogResult.OK)
            {
                SrcDirTB.Text = srcdir.SelectedPath;
                DstDirTB.Text = srcdir.SelectedPath;

            }
        }

        private void WinRTDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog winrtdir = new FolderBrowserDialog();
            if( winrtdir.ShowDialog() == DialogResult.OK)
            {
                WinRTTB.Text = winrtdir.SelectedPath;
            }
        }

        private void DstDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dstdir = new FolderBrowserDialog();
            if( dstdir.ShowDialog() == DialogResult.OK)
            {
                DstDirTB.Text = dstdir.SelectedPath;
            }
        }
    }
}
