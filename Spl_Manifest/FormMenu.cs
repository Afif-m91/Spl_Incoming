using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spl_Manifest
{
    public partial class FormMenu : Form
    {
         DialogResult result;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void karyawanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FormKaryawan f1 = new FormKaryawan();
                //f1.Dock = DockStyle.Fill;
                f1.TopLevel= false;
                this.MainContainer.Panel2.Controls.Add(f1);
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FormUser f2 = new FormUser();
                f2.TopLevel = false;
                this.MainContainer.Panel2.Controls.Add(f2);
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToString("F");
            Nama_User.Text =Spl_Manifest.Properties.Settings.Default.NamaKaryawan;
            //label2.Text = DateTime.Now.ToLongDateString();
            MainContainer.Panel1Collapsed = true;
            // masterDataToolStripMenuItem.Text = Spl_Manifest.Properties.Settings.Default.AksesLevel;
         
            // Membuat User Control
            if (Spl_Manifest.Properties.Settings.Default.AksesLevel == "User")
            {
                masterDataToolStripMenuItem.Visible = false;
                manifestToolStripMenuItem.Visible = true;
               
            }
            else if (Spl_Manifest.Properties.Settings.Default.AksesLevel == "Admin")
            {
                masterDataToolStripMenuItem.Visible = true;
                manifestToolStripMenuItem.Visible = true;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToLongTimeString();
            //label2.Text = DateTime.Now.ToLongDateString();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                result = MessageBox.Show("Apakah Anda Ingin Keluar", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
              
        }

        private void manifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manifestUdaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manifestUdaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FormManifestUdara f4 = new FormManifestUdara();
                f4.TopLevel = false;
                f4.Dock = DockStyle.Fill;
                this.MainContainer.Panel2.Controls.Add(f4);
                f4.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void manifestDaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FormManifestDarat f5 = new FormManifestDarat();
                f5.TopLevel = false;
                f5.Dock = DockStyle.Fill;
                this.MainContainer.Panel2.Controls.Add(f5);
                f5.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    
        private void printManifestUdaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                PrintManifestUdara f5 = new PrintManifestUdara();
                f5.TopLevel = false;
                this.MainContainer.Panel2.Controls.Add(f5);
                f5.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lihatManifestUdaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FrmDataManifestUdara f6 = new FrmDataManifestUdara();
                //f6.Dock = DockStyle.Fill;
                f6.TopLevel = false;
                this.MainContainer.Panel2.Controls.Add(f6);
                f6.Show();
                //f6.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                ViewManifestDarat f7 = new ViewManifestDarat();
                f7.TopLevel = false;
                this.MainContainer.Panel2.Controls.Add(f7);
                f7.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lihatDataManifestUdaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainContainer.Panel2.Controls.Clear();
                FrmDataManifestDarat f9 = new FrmDataManifestDarat();
                //f9.Dock = DockStyle.Fill;
                f9.TopLevel = false;
                this.MainContainer.Panel2.Controls.Add(f9);
                f9.Show();
                //f9.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void statusDate_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Keluar dari aplikasi ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
