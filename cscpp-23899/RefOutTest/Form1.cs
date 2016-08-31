using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefOutTest
{
    public partial class RefOut : Form
    {
        public RefOut()
        {
            InitializeComponent();
        }

        private void RefOutBtn_Click(object sender, EventArgs e)
        {
            RefOutTest rot = new RefOutTest();
            if( rot.RefOutTestExecute() == 0)
            {
                MessageBox.Show("Test Passed");
            }
            else
            {
                MessageBox.Show("Test Failed");
            }
        }
    }
}
