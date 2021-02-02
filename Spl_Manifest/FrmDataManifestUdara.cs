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

namespace Spl_Manifest
{
    public partial class FrmDataManifestUdara : Form
    {
        SqlConnection sqlCon = new SqlConnection(Helper.conString);
        DataTable dt = new DataTable();
      

        public FrmDataManifestUdara()
        {
            InitializeComponent();
            InitializeDatePicker();
            Refresh();
        }
       

        private void FrmDataManifestUdara_Load(object sender, EventArgs e)
        {
            dgvManifestUdara.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            //dgvManifestUdara.DataSource = Helper.FetchManfDetails("FetchData", null);


            //Pencarian data Grid
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try 
            { 
                sqlCmd = new SqlCommand("Select * From ManifestUdara", sqlCon);
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

       
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (dgvManifestUdara.RowCount > 0)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = "NoAwb like '%" + txtCari.Text + "%'";
                    dgvManifestUdara.DataSource = DV;
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Maaf No.AWB Tidak Ditemukan !");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                sqlCmd = new SqlCommand("SELECT * FROM ManifestUdara WHERE TanggalKirim BETWEEN @d1 AND @d2 ORDER BY TanggalKirim DESC", sqlCon);
            //  dt = new DataTable();
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);

                // SqlDataAdapter sqlSda = new SqlDataAdapter("SELECT * FROM ManifestDarat WHERE TanggalKirim BETWEEN @d1 AND @d2 ORDER BY TanggalKirim", sqlCon);
                sqlSda.SelectCommand.Parameters.AddWithValue("@d1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sqlSda.SelectCommand.Parameters.AddWithValue("@d2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                // siapkan datatable untuk menampung data dari database
                DataTable dt = new DataTable();
               // ambil data dari database
               sqlSda.Fill(dt);
               sqlCon.Close();
               bindingSource1.DataSource = dt;
               dgvManifestUdara.DataSource = bindingSource1;
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
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try
            {
                sqlCmd = new SqlCommand("Select * From ManifestUdara Order By IdManfUdara DESC", sqlCon);
                dt = new DataTable();
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dt);
                sqlCon.Close();
                bindingSource1.DataSource = dt;
                dgvManifestUdara.DataSource = bindingSource1;
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

        private void dgvManifestUdara_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvManifestUdara.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
