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
            using (ModelContext db = new ModelContext())
            {
                siteBindingSource.DataSource = db.SiteList.ToList();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Site obj = siteBindingSource.Current as Site;
                if (obj != null)
                {
                    if (db.Entry<Site>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Site>().Attach(obj);
                    if (obj.ObjectState == 1)
                        db.Entry<Site>(obj).State = System.Data.Entity.EntityState.Added;
                    if (obj.ObjectState == 2)
                        db.Entry<Site>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    obj.ObjectState = 0;
                    //txtSite.Text = "";
                }
            }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            siteBindingSource.Add(new Site() { ObjectState = 1 });
            siteBindingSource.MoveLast();
            txtSite.Focus();

        }
    }
}
