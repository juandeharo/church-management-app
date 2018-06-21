using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchManagementApplication
{
    public partial class AboutForm : Form
    {
        frmDashboard callingForm; 

        public AboutForm(frmDashboard f)
        {
            InitializeComponent();
            callingForm = f;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
