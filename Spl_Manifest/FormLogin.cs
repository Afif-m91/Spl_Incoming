using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Spl_Manifest
{
    public partial class FormLogin : Form
    {
        string conString = Helper.conString; //@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            string TidakDiijinkan = "~`@%^&+={[}]()!:,;'><?/|\\-.#+";
            //karakter yang dijinkan adalah angka, huruf dan _ $ *)
            if (e.KeyChar != ControlChars.Back == true)
            {
                if (TidakDiijinkan.IndexOf(e.KeyChar) == -1 == false)
                {
                    e.Handled = true;
                }
            }
          
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string TidakDiijinkan = "~`@%^&+={[}]()!:,;'><?/|\\-.#+";
            //karakter yang dijinkan adalah angka, huruf dan _ $ *)
            if (e.KeyChar != ControlChars.Back == true)
            {
                if (TidakDiijinkan.IndexOf(e.KeyChar) == -1 == false)
                {
                    e.Handled = true;
                }
            }
           
        }

        private void txtPasswors_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Login()
        {
            try
            {
                //Hash Enkripsi Password MD5
                MD5 md5 = MD5.Create();
                byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
                byte[] hash = md5.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                var Password = sb.ToString();

                if (Strings.Len(Strings.Trim(txtUsername.Text)) == 0)
                {
                    MessageBox.Show("Silahkan input username", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                    return;
                }
                if (Strings.Len(Strings.Trim(txtPassword.Text)) == 0)
                {
                    MessageBox.Show("Silahkan input Password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                    return;
                }
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                DataSet ds = new DataSet();
                string Username = txtUsername.Text.Trim();
               // string Password = txtPassword.Text.Trim();

                SqlDataAdapter da = new SqlDataAdapter("select * from Mst_User where Username ='" + Username + "' and Password ='" + Password + "'", con);
                da.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Password salah", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    txtPassword.Focus();
                    return;
                    //MessageBox.Show("Invalid UserID/Password");
                }
               
                else
                {
                    Spl_Manifest.Properties.Settings.Default.Username = txtUsername.Text;
                    Spl_Manifest.Properties.Settings.Default.Password = txtPassword.Text;
                    Spl_Manifest.Properties.Settings.Default.NamaKaryawan = ds.Tables[0].Rows[0]["NamaKaryawan"].ToString();
                    Spl_Manifest.Properties.Settings.Default.AksesLevel = ds.Tables[0].Rows[0]["AksesLevel"].ToString();
                    //  Spl_Manifest.Properties.Settings.Default.NamaKaryawan = ["NamaKaryawan"];
                    //FormMenu.Properties.Settings.Default.RoleName = txt.Text;
                    Spl_Manifest.Properties.Settings.Default.Save();

                  //  MessageBox.Show("Anda Telah Berhasil Login " + txtUsername.Text);
                    FormMenu addform = new FormMenu();
                    addform.Show();
                    this.Visible = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             Login();
           //AksesLevel();
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //Clear Textbox 
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}