using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spl_Manifest
{
    public partial class ViewManifestDarat : Form
    {
        string conString = Helper.conString;//@"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True";

        SqlConnection sqlCon;
        //SqlCommand sqlCmd;
        //string IdManfDarat = "";
        public ViewManifestDarat()
        {
            InitializeComponent();
            InitializeDatePicker();
            Refresh();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();

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
                        dt = Helper.loadAWBscan2("FetchAWB", Convert.ToString(txtFindAwb.Text));
                        if (dt.Rows.Count > 0)
                        {


                            //bool IsExist = dgvPrintManifestUdara.Rows.Cast<DataGridViewRow>().Count(c => c.Cells[0].EditedFormattedValue.ToString() == dt.Rows[0]["NoAwb"].ToString()) >= 1;
                            // if (!IsExist)
                            //{
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dgvPrintManifestDarat);
                            newRow.Cells[0].Value = dt.Rows[0]["TanggalKirim"];
                            newRow.Cells[1].Value = dt.Rows[0]["NoAwb"];
                            newRow.Cells[2].Value = dt.Rows[0]["NamaPengirim"];
                            newRow.Cells[3].Value = dt.Rows[0]["NamaPenerima"];
                            newRow.Cells[4].Value = dt.Rows[0]["IsiBarang"];
                            newRow.Cells[5].Value = dt.Rows[0]["Koli"];
                            newRow.Cells[6].Value = dt.Rows[0]["Kilo"];
                            newRow.Cells[7].Value = dt.Rows[0]["NoSmu"];
                            newRow.Cells[8].Value = dt.Rows[0]["Vendor"];
                            newRow.Cells[8].Value = dt.Rows[0]["Vendor"];
                            newRow.Cells[9].Value = dt.Rows[0]["AsalSmu"];
                            newRow.Cells[10].Value = dt.Rows[0]["KotaTujuan"];
                            newRow.Cells[11].Value = dt.Rows[0]["Area"];
                            newRow.Cells[12].Value = dt.Rows[0]["NamaDriver"];


                            //newRow.Cells[3].Value = dt.Rows[0]["NoAwb"];
                            //newRow.Cells[4].Value = dt.Rows[0]["NoAwb"];
                            dgvPrintManifestDarat.Rows.Add(newRow);
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

        private void txtFindAwb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clear Textbox 
            if (e.KeyChar == (char)13)
            {
                ((TextBox)sender).Clear();

            }

        }

        private void ViewManifestDarat_Load(object sender, EventArgs e)
        {

            dgvPrintManifestDarat.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            txtNamKar.Text = Spl_Manifest.Properties.Settings.Default.NamaKaryawan;
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
                dtConvert.Columns.Add("Vendor", typeof(string));
                dtConvert.Columns.Add("AsalSmu", typeof(string));
                dtConvert.Columns.Add("KotaTujuan", typeof(string));
                dtConvert.Columns.Add("Area", typeof(string));
                dtConvert.Columns.Add("NamaDriver", typeof(string));

            }
            else
            {
                dtConvert.Clear();
            }
            foreach (DataGridViewRow dgr in dgvPrintManifestDarat.Rows)
            {
                dtConvert.Rows.Add(dgr.Cells[0].Value.ToString().Substring(0, 10), dgr.Cells[1].Value, dgr.Cells[2].Value, dgr.Cells[3].Value, dgr.Cells[4].Value,
                    dgr.Cells[5].Value, dgr.Cells[6].Value, dgr.Cells[7].Value, dgr.Cells[8].Value, dgr.Cells[9].Value, dgr.Cells[10].Value, dgr.Cells[11].Value, dgr.Cells[12].Value);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrintManifestDarat.Rows.Count > 0)
                {
                    dtConvert.Clear();
                    if (dtConvert.Rows.Count == 0)
                        ConvertToDatatable();
                    FrmPrintPreview2 frm = new FrmPrintPreview2(Spl_Manifest.Properties.Settings.Default.NamaKaryawan, "Darat", dtConvert);
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
                // siapkan koneksi database
                //var cn = new SqlConnection(Helper.conString);

                // siapkan data adapter untuk data retrieval
                sqlCmd = new SqlCommand("SELECT * FROM ManifestDarat WHERE TanggalKirim BETWEEN @d1 AND @d2 ORDER BY TanggalKirim DESC", sqlCon);
                //  dt = new DataTable();
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                
                // SqlDataAdapter sqlSda = new SqlDataAdapter("SELECT * FROM ManifestDarat WHERE TanggalKirim BETWEEN @d1 AND @d2 ORDER BY TanggalKirim", sqlCon);
                sqlSda.SelectCommand.Parameters.AddWithValue("@d1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sqlSda.SelectCommand.Parameters.AddWithValue("@d2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                DataTable dt = new DataTable();
                sqlSda.Fill(dt);
                sqlCon.Close();
                bindingSource1.DataSource = dt;
                dgvPrintManifestDarat.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtFindAwb.Text = "";
                txtFindAwb.Select();
                dgvPrintManifestDarat.DataSource = null;
                dgvPrintManifestDarat.Rows.Clear();
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
