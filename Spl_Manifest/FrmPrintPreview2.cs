using System;
using CrystalDecisions.CrystalReports.Engine; 
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
    public partial class FrmPrintPreview2 : Form
    {
        ReportClass ClassRepot;
        string printBy, manifest; DataTable DTreport;
        public FrmPrintPreview2(string vprintBy, string vmanifest, DataTable vDTreport)
        {
            InitializeComponent();
            this.printBy = vprintBy;
            this.manifest = vmanifest;
            this.DTreport = vDTreport;
        }

        private void FrmPrintPreview2_Load(object sender, EventArgs e)
        {
            if (manifest == "Darat")
            {
                ManifestDarat();
            }
            else if (manifest == "Udara")
            {

            }
        }

        private void FrmPrintPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            ds.Dispose();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
            GC.Collect();
        }
        private void ManifestDarat()
        {
            try
            {
                DataSet ds = new DataSet();
                if (ds.Tables.Count == 0)
                    ds.Tables.Add(DTreport.Copy());
                ds.WriteXmlSchema("RptDarat.xml");
                ClassRepot = new Report.ReportPrintManfDarat();
                ClassRepot.SetDataSource(ds);
                crystalReportViewer1.ReportSource = ClassRepot;
                ClassRepot.SetParameterValue("Printed", printBy);
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
