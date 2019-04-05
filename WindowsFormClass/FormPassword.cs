using System;
using System.Windows.Forms;

namespace WindowsFormClass
{
    public partial class FormPassword : MetroFramework.Forms.MetroForm
    {
        public FormPassword()
        {
            InitializeComponent();

            //hide password 
            txtPassword.PasswordChar = '*';
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            //else if (dialog == DialogResult.No)
            //{
            //}

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text != " " && txtPassword.Text != "")
            {
                this.Close();
                FormSites formSites = new FormSites();
                formSites.Show();
                
            }
            
        }
    }
}
