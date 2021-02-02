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
    public partial class FrmDataManifestDarat : Form
    {
        SqlConnection sqlCon = new SqlConnection(Helper.conString);
        DataTable dt = new DataTable();
      

        public FrmDataManifestDarat()
        {
            InitializeComponent();
            InitializeDatePicker();
            Refresh();
           
        }

        private void FrmDataManifestDarat_Load(object sender, EventArgs e)
        {
            dgvManifestDarat.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            //dgvManifestDarat.DataSource = Helper.FetchManf2Details("FetchData", null);

            //Pencarian data Grid
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection(Helper.conString);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            try
            {
                sqlCmd = new SqlCommand("Select * From ManifestDarat", sqlCon);
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

                if (dgvManifestDarat.RowCount > 0)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = "NoAwb like '%" + txtCari.Text + "%'";
                    dgvManifestDarat.DataSource = DV;
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
                sqlCmd = new SqlCommand("Select * From ManifestDarat Order By IdManfDarat DESC", sqlCon);
                dt = new DataTable();
                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                sqlSda.Fill(dt);
                sqlCon.Close();
                bindingSource1.DataSource = dt;
                dgvManifestDarat.DataSource = bindingSource1;
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

       

        private void dgvManifestDarat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvManifestDarat.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
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

            // siapkan datatable untuk menampung data dari database
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            //sqlSda.Fill(ds, "ManifestDarat");
            sqlSda.Fill(dt);
            sqlCon.Close();
            bindingSource1.DataSource = dt;
            dgvManifestDarat.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            //dgvManifestDarat.DataSource = ds;
            //dgvManifestDarat.DataMember = "ManifestDarat";
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
        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshGrid();
         
        }
    }
}
