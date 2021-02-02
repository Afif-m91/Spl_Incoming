using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Xml;

namespace Spl_Manifest
{

    public partial class FormUser : Form
    {
       string conString = Helper.conString; 
        //@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True";
        
        DataTable dt = new DataTable();
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string IdUser = "";

        public FormUser()
        {
            InitializeComponent();
            InitializeComboBox();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private DataTable FetchUserDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spMst_User", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dtData);
                dt = new DataTable();
                sqlSda.Fill(dt);
                bindingSource1.DataSource = dt;
                dgvUser.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                return dtData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return dtData;
        }

        private DataTable FetchUserRecords(string UsrId)
        {

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spMst_User", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
                sqlCmd.Parameters.AddWithValue("@IdUser", UsrId);
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dtData);
                //return dtData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return dtData;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
     
        private void Form_User_Load(object sender, EventArgs e)
        {
            //sqlCon = new SqlConnection(@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True");

            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = FetchUserDetails();

            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            button1.Enabled = false;

            //Pencarian data Grid
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try
            {
                sqlCmd = new SqlCommand("Select * From Mst_User", sqlCon);
                dt = new DataTable();
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllData();
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            button1.Enabled = false;
        }

        private void ClearAllData()
        {
            btnSave.Text = "Simpan";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtCari.Text = "";
            comboBoxAkses.SelectedIndex = -1;
            comboBoxKar.SelectedIndex = -1;
            IdUser = "";
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = FetchUserDetails();
        }


        public void Validate_Username()
        {

            try
            {
                if (txtUsername.Text != "")
                {
                    if (GetUserExist(txtUsername.Text) > 0)
                        MessageBox.Show("Username " + txtUsername.Text + " already exist");
                    txtUsername.Select();
                    return;
                }
                else
                    MessageBox.Show("Please fill in the data completely");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static int GetUserExist(string Username)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(Helper.conString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();

            }
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) [rowsCount] from Mst_User  Where Username='" + Username + "'";
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return Convert.ToInt32(dt.Rows[0]["rowsCount"].ToString());
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string pass = txtPassword.Text;
            string konfirmasi = txtPassword2.Text;
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
                          
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try
            {
                if (Username.Trim() == "")
                {
                    MessageBox.Show("Harap isi username");
                    txtUsername.Select();
                    return;
                }
                else if (Username.Length < 5 || Username.Length > 20)
                {
                    MessageBox.Show("Username Minimal 5 Karakter");
                    txtUsername.Select();
                    return;
                }
                else if (txtUsername.Text != "")
                {
                    Validate_Username();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Validasi password
            if (pass.Trim() == "")
            {
                MessageBox.Show("Harap Isi Password");
                txtPassword.Select();
                return;
            }
            if (pass.Length < 6)
            {
                MessageBox.Show("Password Minimal 6 karakter");
                txtPassword.Select();
                return;
            }
            if (pass != konfirmasi)
            {
                MessageBox.Show("Konfirmasi Password Tidak Sesuai");
                txtPassword2.Select();
                return;
            }

            else if (string.IsNullOrWhiteSpace(comboBoxAkses.Text))
            {
                MessageBox.Show("Pilih Hak Akses !!!");
                comboBoxAkses.Select();
            }
            else
            {
                if (GetUserExist(txtUsername.Text) > 0)
                {
                    MessageBox.Show("User Is Available !!");
                }
                else
                {
                    try
                    {
                        //Has Enkripsi Password MD%
                        MD5 md5 = MD5.Create();
                        byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPassword2.Text);
                        byte[] hash = md5.ComputeHash(bytes);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        var Password = sb.ToString();


                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        sqlCmd = new SqlCommand("spMst_User", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCmd.Parameters.AddWithValue("@IdUser", IdUser);
                        sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        sqlCmd.Parameters.AddWithValue("@Password", Password);
                        sqlCmd.Parameters.AddWithValue("@AksesLevel", comboBoxAkses.Text);
                        sqlCmd.Parameters.AddWithValue("@IsActive", "1");
                        sqlCmd.Parameters.AddWithValue("@NamaKaryawan", comboBoxKar.Text);
                        sqlCmd.Parameters.AddWithValue("@CreatedBy", Spl_Manifest.Properties.Settings.Default.Username);
                        // sqlCmd.Parameters.AddWithValue("@IdKaryawan", comboBoxKar.ValueMember);
                        int numRes = sqlCmd.ExecuteNonQuery();
                        if (numRes > 0)
                        {
                           
                            MessageBox.Show("Record Saved Successfully !!!");
                            ClearAllData();
                            btnDelete.Enabled = false;
                            btnSave.Enabled = true;
                            btnRefresh.Enabled = true;
                            button1.Enabled = false;
                        }
                        else
                            MessageBox.Show("Please Try Again !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }
                    finally
                    {
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            sqlCon.Close();
                        }
                    }
                }
            }
        }
        private void InitializeComboBox()
        {
            // siapkan koneksi database
            sqlCon = new SqlConnection(Helper.conString);
           
            SqlDataAdapter da = new SqlDataAdapter("select IdKaryawan, NamaKaryawan from Mst_Karyawan", sqlCon);
            DataTable dt = new DataTable();
            try
            {
                // ambil data dari database
                da.Fill(dt);
                // bind data ke combobox
                comboBoxKar.DataSource = dt;
                comboBoxKar.ValueMember = "IdKaryawan";
                comboBoxKar.DisplayMember = "NamaKaryawan";
                // DONE!!!
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
            btnSave.Enabled = false;
            button1.Enabled = true;

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnSave.Text = "Simpan";
                    IdUser = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable dtData = FetchUserRecords(IdUser);
                    if (dtData.Rows.Count > 0)
                    {
                        IdUser = dtData.Rows[0][0].ToString();
                        txtUsername.Text = dtData.Rows[0]["Username"].ToString();
                        comboBoxAkses.Text = dtData.Rows[0]["AksesLevel"].ToString();
                        // dtData.Rows[0]["IsActive"].ToString();
                        comboBoxKar.Text = dtData.Rows[0]["NamaKaryawan"].ToString();

                        //txtPassword.Text = dtData.Rows[0]["Password"].ToString();

                    }
                }
                else
                {
                    ClearAllData(); // For clear all control and refresh DataGridView data.

                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnRefresh.Enabled = true;
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdUser))
            {
                if (Interaction.MsgBox("Yakin Akan Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi") == MsgBoxResult.No)
                    return;

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spMst_User", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@IdUser", IdUser);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Please Try Again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Record !!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // Pencarian Tanpa Database
                (dgvUser.DataSource as DataTable).DefaultView.RowFilter = string.Format("Username LIKE  '%{0}%'", txtCari.Text);
                //DataView DV = new DataView(dt);
                //DV.RowFilter = "Username like '%" + txtCari.Text + "%'";
                //dgvUser.DataSource = DV;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvUser.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string pass = txtPassword.Text;
            string konfirmasi = txtPassword2.Text;
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try
            {

                if (Username.Trim() == "")
                {
                    MessageBox.Show("Harap isi username");
                    txtUsername.Select();
                    return;
                }
                else if (Username.Length < 5 || Username.Length > 20)
                {
                    MessageBox.Show("Username Minimal 5 Karakter");
                    txtUsername.Select();
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Validasi password
            if (pass.Trim() == "")
            {
                MessageBox.Show("Harap Isi Password");
                txtPassword.Select();
                return;
            }
            if (pass.Length < 6)
            {
                MessageBox.Show("Password Minimal 6 karakter");
                txtPassword.Select();
                return;
            }
            if (pass != konfirmasi)
            {
                MessageBox.Show("Konfirmasi Password Tidak Sesuai");
                txtPassword2.Select();
                return;
            }

            else if (string.IsNullOrWhiteSpace(comboBoxAkses.Text))
            {
                MessageBox.Show("Pilih Hak Akses !!!");
                comboBoxAkses.Select();
            }
            else
            {

                try
                {
                    //Has Enkripsi Password MD%
                    MD5 md5 = MD5.Create();
                    byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPassword2.Text);
                    byte[] hash = md5.ComputeHash(bytes);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    var Password = sb.ToString();


                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spMst_User", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCmd.Parameters.AddWithValue("@IdUser", IdUser);
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", Password);
                    sqlCmd.Parameters.AddWithValue("@AksesLevel", comboBoxAkses.Text);
                    sqlCmd.Parameters.AddWithValue("@IsActive", "1");
                    sqlCmd.Parameters.AddWithValue("@NamaKaryawan", comboBoxKar.Text);
                    sqlCmd.Parameters.AddWithValue("@CreatedBy", Spl_Manifest.Properties.Settings.Default.Username);

                    // sqlCmd.Parameters.AddWithValue("@IdKaryawan", comboBoxKar.ValueMember);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        ClearAllData();
                        btnDelete.Enabled = false;
                        btnSave.Enabled = true;
                        btnRefresh.Enabled = true;
                        button1.Enabled = false;
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }

            }
        }
    }

}
