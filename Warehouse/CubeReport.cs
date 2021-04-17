using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CrystalDecisions.CrystalReports.Engine;

namespace Warehouse
{
    public partial class CubeReport : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=warehouse_database.sqlite3");
        ReportDocument rprt = new ReportDocument();
        public CubeReport()
        {
            InitializeComponent();
        }

        private void CubeReport_Load(object sender, EventArgs e)
        {
            string query = "Select * from Cube";
            string path = Application.StartupPath + "\\CrystalReport3.rpt";
            rprt.Load(path);
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Cube");
            rprt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}
