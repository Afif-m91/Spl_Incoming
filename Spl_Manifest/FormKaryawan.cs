using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Spl_Manifest
{
    public partial class FormKaryawan : Form
    {

        SqlConnection sqlCon = new SqlConnection(Helper.conString);
      
        string IdKaryawan = "";
        DataTable dt = new DataTable();
        public FormKaryawan()
        {
            InitializeComponent();
           
        }

        private DataTable FetchKarDetails()
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
          
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("spKaryawan", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dtData);
                sqlCon.Close();
                dt = new DataTable();
                sqlSda.Fill(dt);
                bindingSource1.DataSource = dt;
                dgvKaryawan.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            return dtData;
          
        
        }

        private DataTable FetchKarRecords(string KarId)
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spKaryawan", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            sqlCmd.Parameters.AddWithValue("@IdKaryawan", KarId);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void FormKaryawan_Load(object sender, EventArgs e)
        {
            dgvKaryawan.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            dgvKaryawan.DataSource = FetchKarDetails();

            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            button1.Enabled = false;

        }
        private void enable_save()
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            button1.Enabled = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //ResetForm(this);
            ClearAllData();
            enable_save();
            
        }
        public void Validate_Nokar()
        {

            try
            {
                if (txtNoKar.Text != "" )
                {
                    if (GetUserExist(txtNoKar.Text) > 0)
                        MessageBox.Show("No. Karyawan " + txtNoKar.Text + " already exist");
                    txtNoKar.Select();
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
        public void Validate_NIK()
        {
            try
            {
                if (txtNik.Text != "")
                {
                    if (GetUserExist(txtNik.Text) > 0)
                        MessageBox.Show("NIK Karyawan " + txtNik.Text + " already exist");
                    txtNoKar.Select();
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
        public static int GetNikExist(string NikKaryawan)
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
                cmd.CommandText = "select count(*) [rowsCount] from Mst_Karyawan  Where NikKaryawan='" + NikKaryawan + "'";
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
        public static int GetUserExist(string NoKaryawan)
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
                cmd.CommandText = "select count(*) [rowsCount] from Mst_Karyawan  Where NoKaryawan='" + NoKaryawan + "'";
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
        Boolean checkemail(string value)
        {
            // Menyiapkan pola
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            // Jika sukses maka akan mengembalikan nilai true, jika tidak akan false
          
            if (Regex.Match(value, pattern).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol enter ditekan 
            if (e.KeyChar == (char)13)
            {
                // Jika fungsi checkemail bernilai true 
                if (checkemail(txtEmail.Text) == true)
                {
                    // memunculkan pesan email valid 
                    MessageBox.Show("Email Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // memunculkan pesan email tidak valid 
                    MessageBox.Show("Email tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ClearAllData()
        {
            btnSave.Text = "Simpan";
            txtNik.Text = "";
            txtNama.Text = "";
            comboBoxDept.SelectedIndex = -1;
            txtTelp.Text = "";
            comboBoxPos.SelectedIndex = -1;
            txtEmail.Text = "";
            txtNoKar.Text = "";
            txtTempat.Text = "";
            dateTimePicker1.Text = "";
            comboBoxGen.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
            txtAlamat.Text = "";
            txtCari.Text="";
            IdKaryawan = "";
            dgvKaryawan.AutoGenerateColumns = false;
            dgvKaryawan.DataSource = FetchKarDetails();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            string NO_KTP = txtNik.Text;

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Masukkan Nama Karyawan !!!");
                txtNama.Select();
                return;
            }
            if (NO_KTP.Trim() == "")
            {
                MessageBox.Show("Harap Isi No. KTP !!");
                txtNik.Select();
                return;
            }
            else if (NO_KTP.Length < 16)
            {
                MessageBox.Show("No. KTP Kurang Dari 16 Digit !!");
                txtNik.Select();
                return;
            }
            else if (NO_KTP.Length > 16)
            {
                MessageBox.Show("No. KTP Lebih Dari 16 Digit !!");
                txtNik.Select();
                return;
            }
            else if (comboBoxDept.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Departement !!!");
                comboBoxDept.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtTelp.Text))
            {
                MessageBox.Show("Masukkan No Telepon !!!");
                txtTelp.Select();
            }
            else if (comboBoxPos.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Posisi !!!");
                comboBoxPos.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Jika fungsi checkemail bernilai true 
                if (checkemail(txtEmail.Text) == false)
                {
                  MessageBox.Show("Masukkan Alamat Email !!!");
                  txtEmail.Select();
                    
                }
                else
                {
                    // memunculkan pesan email tidak valid 
                    MessageBox.Show("Email tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                //MessageBox.Show("Masukkan Alamat Email !!!");
                //txtEmail.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtNoKar.Text))
            {
                MessageBox.Show("Masukkan No.Karyawan !!!");
                txtNoKar.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtTempat.Text))
            {
                MessageBox.Show("Masukkan Tempat Lahir !!!");
                txtTempat.Select();
            }
            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Masukkan Tanggal Lahir !!!");
                dateTimePicker1.Select();
            }
            else if (comboBoxGen.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Posisi !!!");
                comboBoxGen.Select();
            }
            else if (string.IsNullOrWhiteSpace(comboBoxStatus.Text))
            {
                MessageBox.Show("Masukkan Status Pernikahan !!!");
                comboBoxStatus.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Masukkan Alamat !!!");
                txtAlamat.Select();
            }
            else
            {
      
                if (checkemail(txtEmail.Text) == false  || GetUserExist(txtNoKar.Text) > 0 || GetNikExist(txtNik.Text) > 0)
                {
                    if(checkemail(txtEmail.Text) == false)
                    {
                        MessageBox.Show("Email Invalid.!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Select();
                    }
                     else if (GetUserExist(txtNoKar.Text) > 0)
                    {
                        MessageBox.Show("No. Karyawan " + txtNoKar.Text + " Is Available !!");
                        txtNoKar.Select();
                    }
                    else if (GetNikExist(txtNik.Text) > 0)
                    {
                        MessageBox.Show("No. KTP " + txtNik.Text + " Is Available !!");
                        txtNoKar.Select();
                    }
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        sqlCmd = new SqlCommand("spKaryawan", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCmd.Parameters.AddWithValue("@IdKaryawan", IdKaryawan);
                        sqlCmd.Parameters.AddWithValue("@NikKaryawan", txtNik.Text);
                        sqlCmd.Parameters.AddWithValue("@Departmen", comboBoxDept.Text);
                        sqlCmd.Parameters.AddWithValue("@NamaKaryawan", txtNama.Text);
                        sqlCmd.Parameters.AddWithValue("@PhoneKaryawan", txtTelp.Text);
                        sqlCmd.Parameters.AddWithValue("@Posisi", comboBoxPos.Text);
                        sqlCmd.Parameters.AddWithValue("@EmailKaryawan", txtEmail.Text);
                        sqlCmd.Parameters.AddWithValue("@NoKaryawan", txtNoKar.Text);
                        sqlCmd.Parameters.AddWithValue("@TempatLahir", txtTempat.Text);
                        sqlCmd.Parameters.AddWithValue("@TanggalLahir", dateTimePicker1.Value);
                        sqlCmd.Parameters.AddWithValue("@JenisKelamin", comboBoxGen.Text);
                        sqlCmd.Parameters.AddWithValue("@StatusPernikahan", comboBoxStatus.Text);
                        sqlCmd.Parameters.AddWithValue("@AlamatKaryawan", txtAlamat.Text);
                        sqlCmd.Parameters.AddWithValue("@CreatedBy",Spl_Manifest.Properties.Settings.Default.Username);
                        //if (DataXML !="")
                        //sqlCmd.Parameters.AddWithValue("@Gambar", SqlDbType.VarBinary).Value = DataXML;
                        // sqlCmd.Parameters.AddWithValue("@Gambar", images);

                        int numRes = sqlCmd.ExecuteNonQuery();

                        Console.WriteLine(numRes);

                        if (numRes > 0)
                        {
                            // Spl_Manifest.Properties.Settings.Default.Username = txtNama.Text;
                            // Spl_Manifest.Properties.Settings.Default.Password = txtPassword.Text;
                        
                            //FormMenu.Properties.Settings.Default.RoleName = txt.Text;
                          //  Spl_Manifest.Properties.Settings.Default.Save();
                            MessageBox.Show("Record Saved Successfully !!!");
                            ClearAllData();
                            enable_save();
                        }
                        else
                  
                        MessageBox.Show("Please Try Again !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }
                }
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKaryawan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                btnRefresh.Enabled = true;
                btnSave.Enabled = false;
                button1.Enabled = true;

                if (e.RowIndex >= 0)
                {
                    btnSave.Text = "Simpan";
                    IdKaryawan = dgvKaryawan.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable dtData = FetchKarRecords(IdKaryawan);
                    if (dtData.Rows.Count > 0)
                    {
                        IdKaryawan = dtData.Rows[0][0].ToString();
                        //IdKaryawan = dtData.Rows[0]["KarId"].ToString();
                        txtNik.Text = dtData.Rows[0]["NikKaryawan"].ToString();
                        txtNama.Text = dtData.Rows[0]["NamaKaryawan"].ToString();
                        comboBoxDept.Text = dtData.Rows[0]["Departmen"].ToString();
                        txtTelp.Text = dtData.Rows[0]["PhoneKaryawan"].ToString();
                        comboBoxPos.Text = dtData.Rows[0]["Posisi"].ToString();
                        txtEmail.Text = dtData.Rows[0]["EmailKaryawan"].ToString();
                        txtNoKar.Text = dtData.Rows[0]["NoKaryawan"].ToString();
                        txtTempat.Text = dtData.Rows[0]["TempatLahir"].ToString();
                        dateTimePicker1.Text = dtData.Rows[0]["TanggalLahir"].ToString();
                        comboBoxGen.Text = dtData.Rows[0]["JenisKelamin"].ToString();
                        comboBoxStatus.Text = dtData.Rows[0]["StatusPernikahan"].ToString();
                        txtAlamat.Text = dtData.Rows[0]["AlamatKaryawan"].ToString();

                        // pictureBoxKar.ImageLocation = dtData.Rows[0][8].ToString();

                    }
                    else
                    {
                        ClearAllData(); // For clear all control and refresh DataGridView data.
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(IdKaryawan))
            {
                if (Interaction.MsgBox("Yakin Akan Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi") == MsgBoxResult.No)
                    return;
                SqlCommand sqlCmd = new SqlCommand();
                SqlConnection sqlCon = new SqlConnection(Helper.conString);
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spKaryawan", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@IdKaryawan", IdKaryawan);
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
        
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //DataView DV = new DataView(dt);
                //DV.RowFilter = "NamaKaryawan like '%" + txtCari.Text + "%'";
                //dgvKaryawan.DataSource = DV;
                // Pencarian Tanpa Database
                 (dgvKaryawan.DataSource as DataTable).DefaultView.RowFilter = string.Format("NamaKaryawan LIKE '%{0}%'", txtCari.Text);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
           
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNik_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
           
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void dgvKaryawan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvKaryawan.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            string NO_KTP = txtNik.Text;

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Masukkan Nama Karyawan !!!");
                txtNama.Select();
            }
            if (NO_KTP.Trim() == "")
            {
                MessageBox.Show("Harap Isi No. KTP !!");
                txtNik.Select();
                return;
            }
             else if (NO_KTP.Length < 16)
             {
                    MessageBox.Show("No. KTP Kurang Dari 16 Digit !!");
                    txtNik.Select();
                    return;
             }
             else if (NO_KTP.Length >16)
            {
                MessageBox.Show("No. KTP Lebih Dari 16 Digit !!");
                txtNik.Select();
                return;
            }
            
            else if (comboBoxDept.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Departement !!!");
                comboBoxDept.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtTelp.Text))
            {
                MessageBox.Show("Masukkan No Telepon !!!");
                txtTelp.Select();
            }
            else if (comboBoxPos.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Posisi !!!");
                comboBoxPos.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Jika fungsi checkemail bernilai true 
                if (checkemail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Masukkan Alamat Email !!!");
                    txtEmail.Select();
                }
                else
                {
                    // memunculkan pesan email tidak valid 
                    MessageBox.Show("Email tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //MessageBox.Show("Masukkan Alamat Email !!!");
                //txtEmail.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtNoKar.Text))
            {
                MessageBox.Show("Masukkan No.Karyawan !!!");
                txtNoKar.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtTempat.Text))
            {
                MessageBox.Show("Masukkan Tempat Lahir !!!");
                txtTempat.Select();
            }
            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Masukkan Tanggal Lahir !!!");
                dateTimePicker1.Select();
            }
            else if (comboBoxGen.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Posisi !!!");
                comboBoxGen.Select();
            }
            else if (string.IsNullOrWhiteSpace(comboBoxStatus.Text))
            {
                MessageBox.Show("Masukkan Status Pernikahan !!!");
                comboBoxStatus.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Masukkan Alamat !!!");
                txtAlamat.Select();
            }

            else
            {
                if (checkemail(txtEmail.Text) == false)
                {
                    if (checkemail(txtEmail.Text) == false)
                    {
                        MessageBox.Show("Email Invalid.!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                  
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        sqlCmd = new SqlCommand("spKaryawan", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCmd.Parameters.AddWithValue("@IdKaryawan", IdKaryawan);
                        sqlCmd.Parameters.AddWithValue("@NikKaryawan", txtNik.Text);
                        sqlCmd.Parameters.AddWithValue("@Departmen", comboBoxDept.Text);
                        sqlCmd.Parameters.AddWithValue("@NamaKaryawan", txtNama.Text);
                        sqlCmd.Parameters.AddWithValue("@PhoneKaryawan", txtTelp.Text);
                        sqlCmd.Parameters.AddWithValue("@Posisi", comboBoxPos.Text);
                        sqlCmd.Parameters.AddWithValue("@EmailKaryawan", txtEmail.Text);
                        sqlCmd.Parameters.AddWithValue("@NoKaryawan", txtNoKar.Text);
                        sqlCmd.Parameters.AddWithValue("@TempatLahir", txtTempat.Text);
                        sqlCmd.Parameters.AddWithValue("@TanggalLahir", dateTimePicker1.Value);
                        sqlCmd.Parameters.AddWithValue("@JenisKelamin", comboBoxGen.Text);
                        sqlCmd.Parameters.AddWithValue("@StatusPernikahan", comboBoxStatus.Text);
                        sqlCmd.Parameters.AddWithValue("@AlamatKaryawan", txtAlamat.Text);
                        sqlCmd.Parameters.AddWithValue("@CreatedBy", Spl_Manifest.Properties.Settings.Default.Username);
                        //if (DataXML !="")
                        //sqlCmd.Parameters.AddWithValue("@Gambar", SqlDbType.VarBinary).Value = DataXML;
                        // sqlCmd.Parameters.AddWithValue("@Gambar", images);

                        int numRes = sqlCmd.ExecuteNonQuery();
                        Console.WriteLine(numRes);
                        if (numRes > 0)
                        {
                            MessageBox.Show("Record Saved Successfully !!!");
                            ClearAllData();
                            enable_save();
                        }
                        else
                            MessageBox.Show("Please Try Again !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }
                }
            }
        }
    }
}
