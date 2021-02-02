using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spl_Manifest
{
    class Helper
    {
        //public static string conString = @"Data Source= .\SQLEXPRESS; Initial Catalog=Spl_Manifest; Integrated Security=True";
        public static string conString = @"Data Source=(localdb)\V12.0;AttachDbFilename=|DataDirectory|\SQLdb\Spl_Manifest.mdf;Persist Security Info=True";
        //Manifest Udara
        public static DataTable FetchManfDetails(string Action, string NoAwb)
        {
            SqlConnection sqlCon = new SqlConnection(conString);
            SqlCommand sqlCmd = new SqlCommand();

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spManifestUdara", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", Action);
                sqlCmd.Parameters.AddWithValue("@NoAwb", NoAwb);
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


        //Manifest Udara
        public static DataTable FetchManfRecords(string ManfUdaraId)
        {

            SqlConnection sqlCon = new SqlConnection(conString);
            SqlCommand sqlCmd = new SqlCommand();

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spManifestUdara", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
                sqlCmd.Parameters.AddWithValue("@IdManfUdara", ManfUdaraId);
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

        //Manifest Darat
        public static DataTable FetchManf2Records(string ManfDaratId)
        {

            SqlConnection sqlCon = new SqlConnection(conString);
            SqlCommand sqlCmd = new SqlCommand();

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spManifestDarat", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
                sqlCmd.Parameters.AddWithValue("@IdManfDarat", ManfDaratId);
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
        // Manifest Darat
        public static DataTable FetchManf2Details(string Action, string NoAwb)
        {
            SqlConnection sqlCon = new SqlConnection(conString);
            SqlCommand sqlCmd = new SqlCommand();

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            DataTable dtData = new DataTable();
            try
            {
                sqlCmd = new SqlCommand("spManifestDarat", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", Action);
                sqlCmd.Parameters.AddWithValue("@NoAwb", NoAwb);
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

        //public static void InsertKary(int IdManfUdara,string NoAwb,string NamaPengirim,string AlamatPengirim, )
        //{
        //    try
        //    {
        //        SqlConnection sqlCon = new SqlConnection(conString);
        //        SqlCommand sqlCmd = new SqlCommand();
        //        if (sqlCon.State == ConnectionState.Closed)
        //        {
        //            sqlCon.Open();
        //        }
        //        DataTable dtData = new DataTable();
        //        sqlCmd = new SqlCommand("spManifestUdara", sqlCon);
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
        //        sqlCmd.Parameters.AddWithValue("@IdManfUdara", );
        //        sqlCmd.Parameters.AddWithValue("@NoAwb",);
        //        sqlCmd.Parameters.AddWithValue("@NamaPengirim", txtPengirim.Text);
        //        sqlCmd.Parameters.AddWithValue("@AlamatPengirim", txtAlamatPengirim.Text);
        //        sqlCmd.Parameters.AddWithValue("@NoTelpon1", txtNoTelpon1.Text);
        //        sqlCmd.Parameters.AddWithValue("@TanggalKirim", dateTimePicker1.Value);
        //        sqlCmd.Parameters.AddWithValue("@NamaPenerima", txtPenerima.Text);
        //        sqlCmd.Parameters.AddWithValue("@AlamatPenerima", txtAlamatPenerima.Text);
        //        sqlCmd.Parameters.AddWithValue("@NoTelpon2", txtNoTelpon2.Text);
        //        sqlCmd.Parameters.AddWithValue("@Kilo", txtKilo.Text);
        //        sqlCmd.Parameters.AddWithValue("@Koli", txtKoli.Text);
        //        sqlCmd.Parameters.AddWithValue("@IsiBarang", txtIsiBarang.Text);
        //        sqlCmd.Parameters.AddWithValue("@NamaDriver", txtNamaDriver.Text);
        //        sqlCmd.Parameters.AddWithValue("@KotaTujuan", txtKota.Text);
        //        sqlCmd.Parameters.AddWithValue("@AsalSmu", txtAsal.Text);
        //        sqlCmd.Parameters.AddWithValue("@NoSmu", txtNoSmu.Text);
        //        sqlCmd.Parameters.AddWithValue("@Maskapai", comboBoxMas.Text);
        //        sqlCmd.Parameters.AddWithValue("@KiloSmu", txtKiloSmu.Text);
        //        sqlCmd.Parameters.AddWithValue("@KoliSmu", txtKoliSmu.Text);
        //        sqlCmd.Parameters.AddWithValue("@CreatedBy", Spl_Manifest.Properties.Settings.Default.NamaKaryawan);

        //        int numRes = sqlCmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error:- " + ex.Message);
        //    }
        //}

        //Manifest Udara

        public static DataTable loadAWBscan(string Action, string NoAWB)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(conString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();

            }
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spManifestUdara";
                cmd.Parameters.Add(new SqlParameter("@NoAwb", NoAWB));
                cmd.Parameters.Add(new SqlParameter("@ActionType", Action));
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
            return dt;
        }

        public static DataTable loadAWBscan2(string Action, string NoAWB)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(conString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();

            }
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spManifestDarat";
                cmd.Parameters.Add(new SqlParameter("@NoAwb", NoAWB));
                cmd.Parameters.Add(new SqlParameter("@ActionType", Action));
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
            return dt;
        }
        //insertmanifestudara import manifest udara
        public static void insertmanifestudara(string NoAwb, string NamaPengirim,  string AlamatPengirim, string NoTelpon1, string TanggalKirim, string NamaPenerima, string AlamatPenerima,
                           string NoTelpon2, string Kilo, string Koli, string IsiBarang, string NamaDriver,string Area, string KotaTujuan, string AsalSmu, string NoSmu ,string Maskapai, string KiloSmu, string KoliSmu,
                           string Action)
        {
            SqlConnection cnn = new SqlConnection(conString);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (cnn.State == ConnectionState.Open)
            {
                SqlTransaction tran = cnn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spManifestUdara";
                    cmd.Parameters.Add(new SqlParameter("@NoAwb", NoAwb));
                    cmd.Parameters.Add(new SqlParameter("@NamaPengirim", NamaPengirim));
                    //cmd.Parameters.Add(new SqlParameter("@JoinedDate", Convert.ToDateTime(JoinedDate)));
                    cmd.Parameters.Add(new SqlParameter("@AlamatPengirim", AlamatPengirim));
                    cmd.Parameters.Add(new SqlParameter("@NoTelpon1", NoTelpon1));
                    if (TanggalKirim != "")
                        cmd.Parameters.Add(new SqlParameter("@TanggalKirim", Convert.ToDateTime(TanggalKirim)));
                    cmd.Parameters.Add(new SqlParameter("@NamaPenerima", NamaPenerima));
                    cmd.Parameters.Add(new SqlParameter("@AlamatPenerima", AlamatPenerima));
                    cmd.Parameters.Add(new SqlParameter("@NoTelpon2", NoTelpon2));
                    cmd.Parameters.Add(new SqlParameter("@Kilo", Kilo));
                    cmd.Parameters.Add(new SqlParameter("@Koli", Koli));
                    cmd.Parameters.Add(new SqlParameter("@IsiBarang", IsiBarang));
                    cmd.Parameters.Add(new SqlParameter("@NamaDriver", NamaDriver));
                    cmd.Parameters.Add(new SqlParameter("@Area", Area));
                    cmd.Parameters.Add(new SqlParameter("@KotaTujuan", KotaTujuan));
                    cmd.Parameters.Add(new SqlParameter("@AsalSmu", AsalSmu));
                    cmd.Parameters.Add(new SqlParameter("@NoSmu", NoSmu));
                    cmd.Parameters.Add(new SqlParameter("@Maskapai", Maskapai));
                    cmd.Parameters.Add(new SqlParameter("@ActionType", Action));
                    //if (Year != null || Year != "")
                    //    cmd.Parameters.Add(new SqlParameter("@Year", float.Parse(Year)));
                    cmd.Parameters.Add(new SqlParameter("@KiloSmu", KiloSmu));
                    cmd.Parameters.Add(new SqlParameter("@KoliSmu", KoliSmu));
                    //cmd.Parameters.AddWithValue("@ElectronicFile", SqlDbType.VarBinary).Value = ElectronicFile;
                    //cmd.Parameters.Add(new SqlParameter("@FileLocation", fileLocation));
                    cmd.Parameters.Add(new SqlParameter("@CreatedBy",Spl_Manifest.Properties.Settings.Default.NamaKaryawan));
                    //cmd.Parameters.Add(new SqlParameter("@FileKey", fileKey));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                }
            }
        }

        //insertmanifestdarat import manifest darat
        public static void insertmanifestdarat(string NoAwb, string NamaPengirim, string AlamatPengirim, string NoTelpon1, string TanggalKirim, string NamaPenerima, string AlamatPenerima,
                          string NoTelpon2, string Kilo, string Koli, string IsiBarang, string NamaDriver, string Area, string KotaTujuan, string AsalSmu, string NoSmu, string Vendor, string KiloSmu, string KoliSmu,
                          string Action)
        {
            SqlConnection cnn = new SqlConnection(conString);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (cnn.State == ConnectionState.Open)
            {
                SqlTransaction tran = cnn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spManifestDarat";
                    cmd.Parameters.Add(new SqlParameter("@NoAwb", NoAwb));
                    cmd.Parameters.Add(new SqlParameter("@NamaPengirim", NamaPengirim));
                    //cmd.Parameters.Add(new SqlParameter("@JoinedDate", Convert.ToDateTime(JoinedDate)));
                    cmd.Parameters.Add(new SqlParameter("@AlamatPengirim", AlamatPengirim));
                    cmd.Parameters.Add(new SqlParameter("@NoTelpon1", NoTelpon1));
                    cmd.Parameters.Add(new SqlParameter("@TanggalKirim", Convert.ToDateTime(TanggalKirim)));
                    cmd.Parameters.Add(new SqlParameter("@NamaPenerima", NamaPenerima));
                    cmd.Parameters.Add(new SqlParameter("@AlamatPenerima", AlamatPenerima));
                    cmd.Parameters.Add(new SqlParameter("@NoTelpon2", NoTelpon2));
                    cmd.Parameters.Add(new SqlParameter("@Kilo", Kilo));
                    cmd.Parameters.Add(new SqlParameter("@Koli", Koli));
                    cmd.Parameters.Add(new SqlParameter("@IsiBarang", IsiBarang));
                    cmd.Parameters.Add(new SqlParameter("@NamaDriver", NamaDriver));
                    cmd.Parameters.Add(new SqlParameter("@Area", Area));
                    cmd.Parameters.Add(new SqlParameter("@KotaTujuan", KotaTujuan));
                    cmd.Parameters.Add(new SqlParameter("@AsalSmu", AsalSmu));
                    cmd.Parameters.Add(new SqlParameter("@NoSmu", NoSmu));
                    cmd.Parameters.Add(new SqlParameter("@Vendor", Vendor));
                    cmd.Parameters.Add(new SqlParameter("@ActionType", Action));
                    //if (Year != null || Year != "")
                    //    cmd.Parameters.Add(new SqlParameter("@Year", float.Parse(Year)));
                    cmd.Parameters.Add(new SqlParameter("@KiloSmu", KiloSmu));
                    cmd.Parameters.Add(new SqlParameter("@KoliSmu", KoliSmu));
                    //cmd.Parameters.AddWithValue("@ElectronicFile", SqlDbType.VarBinary).Value = ElectronicFile;
                    //cmd.Parameters.Add(new SqlParameter("@FileLocation", fileLocation));
                    cmd.Parameters.Add(new SqlParameter("@CreatedBy", Spl_Manifest.Properties.Settings.Default.NamaKaryawan));
                    //cmd.Parameters.Add(new SqlParameter("@FileKey", fileKey));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                }
            }
        }
    }
}
