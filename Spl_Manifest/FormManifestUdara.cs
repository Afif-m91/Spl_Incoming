using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Spl_Manifest
{
    public partial class FormManifestUdara : Form
    {
        //string path = "\\\\192.168.1.79\\source\\repos\\Spl_Manifest\\Template\\Template_Import_SMU_Udara.xls";
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        string extention;
        string fileSlip;
        string dataFile;
        string IdManfUdara = "";
       
        DataTable dt = new DataTable();
        public FormManifestUdara()
        {
            InitializeComponent();
            //this.param = vparam;
        }

        private void FormManifest_Load(object sender, EventArgs e)
        {

            dgvManifestUdara.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            dgvManifestUdara.DataSource = Helper.FetchManfDetails("FetchData",null);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPenerima_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamatPenerima_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoTelpon2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPengirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtAwb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTelpon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamatPengirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAllData();
           //  ResetForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAwb.Text == "")
            {
                MessageBox.Show("No AWB Tidak Boleh Kosong!");
                txtAwb.Focus();
            }
            else if (txtPengirim.Text == "")
            {
                MessageBox.Show("Nama Pengirim Tidak Boleh Kosong!");
                txtPengirim.Focus();
            }
            else if (txtAlamatPengirim.Text == "")
            {
                MessageBox.Show("Alamat Pengirim Tidak Boleh Kosong!");
                txtAlamatPengirim.Focus();
            }
            else if (txtNoTelpon1.Text == "")
            {
                MessageBox.Show("No Telepon Pengirim Tidak Boleh Kosong!");
                txtNoTelpon1.Focus();
            }
            else if (txtKota.Text == "")
            {
                MessageBox.Show("Kota Tujuan Tidak Boleh Kosong!");
                txtKota.Focus();
            }
            else if (txtKoli.Text == "")
            {
                MessageBox.Show("Koli Tidak Boleh Kosong!");
                txtKoli.Focus();
            }
            else if (txtKilo.Text == "")
            {
                MessageBox.Show("Koli Tidak Boleh Kosong!");
                txtKilo.Focus();
            }
            else if (txtIsiBarang.Text == "")
            {
                MessageBox.Show("Isi Barang Tidak Boleh Kosong!");
                txtIsiBarang.Focus();
            }
            else if (txtIsiBarang.Text == "")
            {
                MessageBox.Show("Isi Barang Tidak Boleh Kosong!");
                txtIsiBarang.Focus();
            }
            else if (txtPenerima.Text == "")
            {
                MessageBox.Show("Nama Penerima Tidak Boleh Kosong!");
                txtPenerima.Focus();
            }
            else if (txtAlamatPenerima.Text == "")
            {
                MessageBox.Show("Alamat Penerima Tidak Boleh Kosong!");
                txtAlamatPenerima.Focus();
            }
            else if (txtNoTelpon2.Text == "")
            {
                MessageBox.Show("No Telepon Penerima Tidak Boleh Kosong!");
                txtNoTelpon2.Focus();
            }
            else if (txtNamaDriver.Text == "")
            {
                MessageBox.Show("Nama Driver Tidak Boleh Kosong!");
                txtNamaDriver.Focus();
            }
            else if (txtAsal.Text == "")
            {
                MessageBox.Show("Asal SMU Tidak Boleh Kosong!");
                txtAsal.Focus();
            }
            else if (txtNoSmu.Text == "")
            {
                MessageBox.Show("No.SMU Tidak Boleh Kosong!");
                txtNoSmu.Focus();
            }
            else if (comboBoxMas.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Maskapai !!!");
                comboBoxMas.Focus();
            }
            else if (comboBoxArea.SelectedIndex <= -1)
            {
                MessageBox.Show("Anda Belum Memilih Area !!!");
                comboBoxMas.Focus();
            }
            else if (txtKoliSmu.Text == "")
            {
                MessageBox.Show("Koli SMU Tidak Boleh Kosong!");
                txtKoliSmu.Focus();
            }
            else if (txtKiloSmu.Text == "")
            {
                MessageBox.Show("Kilo SMU Tidak Boleh Kosong!");
                txtKiloSmu.Focus();
            }


            else
            {

                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.conString);
                    SqlCommand sqlCmd = new SqlCommand();
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spManifestUdara", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCmd.Parameters.AddWithValue("@IdManfUdara", IdManfUdara);
                    sqlCmd.Parameters.AddWithValue("@NoAwb", txtAwb.Text);
                    sqlCmd.Parameters.AddWithValue("@NamaPengirim", txtPengirim.Text);
                    sqlCmd.Parameters.AddWithValue("@AlamatPengirim", txtAlamatPengirim.Text);
                    sqlCmd.Parameters.AddWithValue("@NoTelpon1", txtNoTelpon1.Text);
                    sqlCmd.Parameters.AddWithValue("@TanggalKirim", dateTimePicker1.Value);
                    sqlCmd.Parameters.AddWithValue("@NamaPenerima", txtPenerima.Text);
                    sqlCmd.Parameters.AddWithValue("@AlamatPenerima", txtAlamatPenerima.Text);
                    sqlCmd.Parameters.AddWithValue("@NoTelpon2", txtNoTelpon2.Text);
                    sqlCmd.Parameters.AddWithValue("@Kilo", txtKilo.Text);
                    sqlCmd.Parameters.AddWithValue("@Koli", txtKoli.Text);
                    sqlCmd.Parameters.AddWithValue("@IsiBarang", txtIsiBarang.Text);
                    sqlCmd.Parameters.AddWithValue("@NamaDriver", txtNamaDriver.Text);
                    sqlCmd.Parameters.AddWithValue("@KotaTujuan", txtKota.Text);
                    sqlCmd.Parameters.AddWithValue("@Area", comboBoxArea.Text);
                    sqlCmd.Parameters.AddWithValue("@AsalSmu", txtAsal.Text);
                    sqlCmd.Parameters.AddWithValue("@NoSmu", txtNoSmu.Text);
                    sqlCmd.Parameters.AddWithValue("@Maskapai", comboBoxMas.Text);
                    sqlCmd.Parameters.AddWithValue("@KiloSmu", txtKiloSmu.Text);
                    sqlCmd.Parameters.AddWithValue("@KoliSmu", txtKoliSmu.Text);
                    sqlCmd.Parameters.AddWithValue("@CreatedBy", Spl_Manifest.Properties.Settings.Default.Username);
                    sqlCmd.Parameters.AddWithValue("@UpdateBy", Spl_Manifest.Properties.Settings.Default.Username);

                    int numRes = sqlCmd.ExecuteNonQuery();
                    
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        ClearAllData();
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
        
        private void ClearAllData()
        {
            btnSave.Text = "Simpan";
            txtAwb.Text = "";
            txtPengirim.Text = "";
            txtAlamatPengirim.Text = "";
            txtNoTelpon1.Text = "";
            txtPenerima.Text = "";
            dateTimePicker1.Text ="" ;
            txtPenerima.Text = "";
            txtAlamatPenerima.Text = "";
            txtNoTelpon2.Text = "";
            txtKilo.Text = "";
            txtKoli.Text = "";
            txtNoSmu.Text = "";
            comboBoxMas.SelectedIndex = -1;
            txtKoliSmu.Text = "";
            txtKiloSmu.Text = "";
            txtNamaDriver.Text = "";
            txtIsiBarang.Text = "";
            txtKota.Text = "";
            comboBoxArea.Text = "";
            txtAsal.Text = "";
            txtFile.Text = "";
            dgvManifestUdara.AutoGenerateColumns = false;
            dgvManifestUdara.DataSource = Helper.FetchManfDetails("FetchData",null);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string path = appPath+"\\Template\\Template_Import_SMU_Udara.xls";
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
                saveFileDialog1.Title = "Save Files As";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Filter = "Excel Format(*.xls)|*.xls";
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.FileName = "Template_Import_SMU_Udara.xls";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string newDirectory = saveFileDialog1.FileName;
                    System.IO.File.Copy(path, newDirectory);
                    MessageBox.Show("Download Completed...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvManifestUdara_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                btnSave.Text = "Update";
                IdManfUdara = dgvManifestUdara.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtData = Helper.FetchManfRecords(IdManfUdara);
                if (dtData.Rows.Count > 0)
                {
                    IdManfUdara = dtData.Rows[0][0].ToString();
                    txtAwb.Text = dtData.Rows[0]["NoAwb"].ToString();
                    txtPengirim.Text = dtData.Rows[0]["NamaPengirim"].ToString();
                    txtAlamatPengirim.Text = dtData.Rows[0]["AlamatPengirim"].ToString();
                    txtNoTelpon1.Text = dtData.Rows[0]["NoTelpon1"].ToString();
                    dateTimePicker1.Text = dtData.Rows[0]["TanggalKirim"].ToString();
                    txtPenerima.Text = dtData.Rows[0]["NamaPenerima"].ToString();
                    txtAlamatPenerima.Text = dtData.Rows[0]["AlamatPenerima"].ToString();
                    txtNoTelpon2.Text = dtData.Rows[0]["NoTelpon2"].ToString();
                    txtKilo.Text = dtData.Rows[0]["Kilo"].ToString();
                    txtKoli.Text = dtData.Rows[0]["Koli"].ToString();
                    txtIsiBarang.Text = dtData.Rows[0]["IsiBarang"].ToString();
                    txtNamaDriver.Text = dtData.Rows[0]["NamaDriver"].ToString();
                    comboBoxArea.Text = dtData.Rows[0]["Area"].ToString();
                    txtKota.Text = dtData.Rows[0]["KotaTujuan"].ToString();
                    txtAsal.Text = dtData.Rows[0]["AsalSmu"].ToString();
                    txtNoSmu.Text = dtData.Rows[0]["NoSmu"].ToString();
                    comboBoxMas.Text = dtData.Rows[0]["Maskapai"].ToString();
                    txtKoliSmu.Text = dtData.Rows[0]["KoliSmu"].ToString();
                    txtKiloSmu.Text = dtData.Rows[0]["KiloSmu"].ToString();


                    // pictureBoxKar.ImageLocation = dtData.Rows[0][8].ToString();

                }
                else
                {
                    ClearAllData(); // For clear all control and refresh DataGridView data.
                }
            }

        }

        private void dgvManifestUdara_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(IdManfUdara))
            {
                if (Interaction.MsgBox("Yakin Akan Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi") == MsgBoxResult.No)
                    return;
                try
                    {
                        SqlConnection sqlCon = new SqlConnection(Helper.conString);
                        SqlCommand sqlCmd = new SqlCommand();
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spManifestUdara", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@IdManfUdara", IdManfUdara);
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

        public void LoadData()
        {
            try
            {
                if (txtFile.Text != "")
                {
                    if (dataGridImport.RowCount != 0)
                    {
                        for (int i = 0; i < dataGridImport.RowCount;)
                        {
                            dataGridImport.Rows.RemoveAt(i);
                        }
                        dataGridImport.Update();
                        dataGridImport.Refresh();

                    }

                    string conStr, sheetName;
                    conStr = string.Empty;
                    switch (extention)
                    {

                        case ".xls": //Excel 97-03
                            conStr = string.Format(Excel03ConString, dataFile, "YES");
                            break;

                        case ".xlsx": //Excel 07
                            conStr = string.Format(Excel07ConString, dataFile, "YES");
                            break;
                    }
                    //Get the name of the First Sheet.
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = con;
                            con.Open();
                            DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                            con.Close();
                        }
                    }
                    //Read Data from the First Sheet.
                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            using (OleDbDataAdapter oda = new OleDbDataAdapter())
                            {
                                cmd.CommandText = "SELECT * From [" + sheetName + "]";
                                cmd.Connection = con;
                                con.Open();
                                oda.SelectCommand = cmd;
                                oda.Fill(dt);
                                con.Close();

                                //Populate DataGridView.
                                dataGridImport.DataSource = dt;
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Please Select Your File !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel Files 97-2003 Format (*.xls)|*.xls|Excel Files Workbook Format (*.xlsx)|*.xlsx";
                dialog.Title = "Please Select Your Files";
                dialog.DefaultExt = "xls";
                dialog.ShowDialog();
                fileSlip = dialog.FileName;
                dataFile = dialog.FileName;
                extention = System.IO.Path.GetExtension(dataFile);
                txtFile.Text = System.IO.Path.GetFileName(dataFile);
                //load data from excel template
                LoadData();
                MessageBox.Show("Upload Data Berhasil, Silahkan Click Import", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //public void ImportDataFromExcel(string excelFilePath)
        //{
        //    string ssqltable = "ManifestUdara";
        //    // string myexceldataquery = "select IdManfUdara,NoAwb,Pengirim from [Sheet1$]";
            
        //  string myexceldataquery = "select student,rollno,course from [sheet1$]";
        //    try
        //    {
        //        SqlConnection sqlCon = new SqlConnection(Helper.conString);
        //        SqlCommand sqlCmd = new SqlCommand();
        //        sqlCon.Open();
        //         string sexcelconnectionstring = @"provider=microsoft.ACE.OLEDB.12.0;data source=" + excelFilePath +
        //        ";extended properties=" + "\"excel 12.0;hdr=yes;\"";
        //        sqlCon.Open();
        //        OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
        //        OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
        //        oledbconn.Open();
        //        OleDbDataReader dr = oledbcmd.ExecuteReader();
        //        SqlBulkCopy bulkcopy = new SqlBulkCopy(sqlCon);
        //        bulkcopy.DestinationTableName = ssqltable;
        //        while (dr.Read())
        //        {
        //            bulkcopy.WriteToServer(dr);
        //        }
        //        dr.Close();
        //        oledbconn.Close();
        //        MessageBox.Show("File imported into sql server.");
        //        }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(txtFile.Text)) == 0)
            {
                MessageBox.Show("Anda Belum Melakukan Upload Data", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFile.Focus();
                return;
            }
            //ImportDataFromExcel(txtFile.Text);
            if (dataGridImport.RowCount != 0)
            {
                try
                {
                    for (int i = 0; i < dataGridImport.Rows.Count; i++)
                    {
                        //byte[] fileSlip;
                        //  fileSlip = null;
                        if (dataGridImport.Rows[i].Cells["Tanggal Kirim"].Value.ToString() != "")
                        {

                            Helper.insertmanifestudara(dataGridImport.Rows[i].Cells["NoAwb"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Nama Pengirim"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Alamat Pengirim"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Telpon1"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Tanggal Kirim"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Nama Penerima"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Alamat Penerima"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Telpon2"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Koli"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Kilo"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Isi Barang"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Nama Driver"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Area"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Tujuan"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Asal SMU"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["No SMU"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Maskapai"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Koli Smu"].Value.ToString(),
                                    dataGridImport.Rows[i].Cells["Kilo Smu"].Value.ToString(),
                                    "SaveData");

                        }
                    }
                    MessageBox.Show("Import Data Selesai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridImport.DataSource = null;
                    dgvManifestUdara.DataSource = Helper.FetchManfDetails("FetchData", null);
                    ClearAllData();
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            // Pencarian Tanpa Database
            (dgvManifestUdara.DataSource as DataTable).DefaultView.RowFilter = string.Format("NoAwb LIKE  '%{0}%'", txtCari.Text);

        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
