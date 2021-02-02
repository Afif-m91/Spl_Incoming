using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Spl_Manifest
{
    public partial class PrintManifestUdara : Form
    {

        string conString = Helper.conString;//@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True";

        SqlConnection sqlCon;
        //SqlCommand sqlCmd;
        //string IdManfUdara = "";

        public PrintManifestUdara()
        {
            InitializeComponent();
            InitializeDatePicker();
            Refresh();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();


        }

        private void ViewManifestUdara_Load(object sender, EventArgs e)
        {

            dgvPrintManifestUdara.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            txtNamKar.Text = Spl_Manifest.Properties.Settings.Default.NamaKaryawan;


            //   txtNamKar.Text = Spl_Manifest.Properties.Settings.Default.NamaKaryawan;
        }
        DataTable dtConvert = new DataTable();
        private void ConvertToDatatable()
        {
            if (dtConvert.Columns.Count == 0)
            {
                dtConvert.Columns.Add("Tanggal", typeof(string));
                dtConvert.Columns.Add("NoAwb", typeof(string));
                dtConvert.Columns.Add("Pengirim", typeof(string));
                dtConvert.Columns.Add("Penerima", typeof(string));
                dtConvert.Columns.Add("Ket", typeof(string));
                dtConvert.Columns.Add("Koli", typeof(int));
                dtConvert.Columns.Add("Kilo", typeof(int));
                dtConvert.Columns.Add("NoSmu", typeof(string));
                dtConvert.Columns.Add("Maskapai", typeof(string));
                dtConvert.Columns.Add("AsalSmu", typeof(string));
                dtConvert.Columns.Add("KoliSmu", typeof(int));
                dtConvert.Columns.Add("KiloSmu", typeof(int));
                dtConvert.Columns.Add("KotaTujuan", typeof(string));
                dtConvert.Columns.Add("Area", typeof(string));
                dtConvert.Columns.Add("NamaDriver", typeof(string));

            }
            else
            {
                dtConvert.Clear();
            }
            foreach (DataGridViewRow dgr in dgvPrintManifestUdara.Rows)
            {
                dtConvert.Rows.Add(dgr.Cells[0].Value.ToString().Substring(0, 10), dgr.Cells[1].Value, dgr.Cells[2].Value, dgr.Cells[3].Value, dgr.Cells[4].Value,
                    dgr.Cells[5].Value, dgr.Cells[6].Value, dgr.Cells[7].Value, dgr.Cells[8].Value, dgr.Cells[9].Value, dgr.Cells[10].Value, dgr.Cells[11].Value,
                    dgr.Cells[12].Value, dgr.Cells[13].Value);
            }
        }
        private void InitializeDatePicker()
        {
            // set value date time picker ke awal dan akhir tahun
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            dateTimePicker2.Value = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        }
        private void RefreshGrid()
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            try
            {
               // siapkan data adapter untuk data retrieval
                sqlCmd = new SqlCommand("SELECT * FROM ManifestUdara WHERE TanggalKirim BETWEEN @d1 AND @d2 ORDER BY TanggalKirim DESC", sqlCon);
                //  dt = new DataTable();
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.SelectCommand.Parameters.AddWithValue("@d1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sqlSda.SelectCommand.Parameters.AddWithValue("@d2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                // siapkan datatable untuk menampung data dari database
                DataTable dt = new DataTable();
                // ambil data dari database
                sqlSda.Fill(dt);
                sqlCon.Close();
                bindingSource1.DataSource = dt;
                dgvPrintManifestUdara.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
           
            }
            // DONE!!!
            catch (Exception ex)
            {
                // tampilkan pesan error
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrintManifestUdara.Rows.Count > 0)
                {
                    dtConvert.Clear();
                    if (dtConvert.Rows.Count == 0)
                        ConvertToDatatable();
                    FrmPrintPreview frm = new FrmPrintPreview(Spl_Manifest.Properties.Settings.Default.NamaKaryawan, "Udara", dtConvert);
                    Report.ReportPrintManfUdara cr = new Report.ReportPrintManfUdara();
                    frm.crystalReportViewer1.ReportSource = cr;
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("Data Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
       
        private void txtFindAwb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFindAwb_KeyDown(object sender, KeyEventArgs e)
        {
            sqlCon = new SqlConnection(@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True");

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //dgvManifestUdara.DataSource = null;
                    // DataTable dt = new DataTable();
                    //dgvManifestUdara.Rows.Clear();
                    //dgvManifestUdara.Refresh();
                    //dt = Helper.loadAWBscan("FetchAWB", txtFindAwb.Text);
                    //dgvManifestUdara.DataSource = dt;

                    //taro dibawah ini yg baru 
                    if (txtFindAwb.Text != "")
                    {
                        DataTable dt = new DataTable();
                        dt = Helper.loadAWBscan("FetchAWB", Convert.ToString(txtFindAwb.Text));
                        if (dt.Rows.Count > 0)
                        {


                            //bool IsExist = dgvPrintManifestUdara.Rows.Cast<DataGridViewRow>().Count(c => c.Cells[0].EditedFormattedValue.ToString() == dt.Rows[0]["NoAwb"].ToString()) >= 1;
                            // if (!IsExist)
                            //{
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dgvPrintManifestUdara);
                            newRow.Cells[0].Value = dt.Rows[0]["TanggalKirim"];
                            newRow.Cells[1].Value = dt.Rows[0]["NoAwb"];
                            newRow.Cells[2].Value = dt.Rows[0]["NamaPengirim"];
                            newRow.Cells[3].Value = dt.Rows[0]["NamaPenerima"];
                            newRow.Cells[4].Value = dt.Rows[0]["IsiBarang"];
                            newRow.Cells[5].Value = dt.Rows[0]["Koli"];
                            newRow.Cells[6].Value = dt.Rows[0]["Kilo"];
                            newRow.Cells[7].Value = dt.Rows[0]["NoSmu"];
                            newRow.Cells[8].Value = dt.Rows[0]["Maskapai"];
                            newRow.Cells[9].Value = dt.Rows[0]["AsalSmu"];
                            newRow.Cells[10].Value = dt.Rows[0]["KoliSmu"];
                            newRow.Cells[11].Value = dt.Rows[0]["KiloSmu"];
                            newRow.Cells[12].Value = dt.Rows[0]["KotaTujuan"];
                            newRow.Cells[13].Value = dt.Rows[0]["Area"];
                            newRow.Cells[14].Value = dt.Rows[0]["NamaDriver"];
                           

                            //newRow.Cells[3].Value = dt.Rows[0]["NoAwb"];
                            //newRow.Cells[4].Value = dt.Rows[0]["NoAwb"];
                            dgvPrintManifestUdara.Rows.Add(newRow);
                            // }
                        }
                     
                        else
                        {
                            MessageBox.Show("Maaf AWB Tidak Terdaftar !");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void txtFindAwb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clear Textbox 
            if (e.KeyChar == (char)13)
            {
                ((TextBox)sender).Clear();
              
            }
           
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
        }
       
        private void txtNamKar_TextChanged(object sender, EventArgs e)
        {
          
            //  Spl_Manifest.Properties.Settings.Default.ToString();
            
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtFindAwb.Text = "";
                txtFindAwb.Select();
                dgvPrintManifestUdara.DataSource = null;
                dgvPrintManifestUdara.Rows.Clear();
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
