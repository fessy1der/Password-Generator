using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClass
{
    public partial class FormAddSite : MetroFramework.Forms.MetroForm
    {
        public FormAddSite()
        {
            InitializeComponent();
        }

        private void FormAddSite_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSite.Text == "")
            {
                MessageBox.Show(this, "You did not enter a site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtSite.Text != "")
            {
                MessageBox.Show(this, "You did not save your site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
