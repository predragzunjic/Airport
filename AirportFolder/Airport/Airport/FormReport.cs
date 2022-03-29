using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class FormReport : Form
    {
        public FormReport(ReportType reportType)
        {
            InitializeComponent();

            switch(reportType)
            {
                case ReportType.PilotList:
                    CrystalReport1 report = new CrystalReport1();
                    this.crystalReportViewer1.ReportSource = report;
                    break;
                case ReportType.AirplaneList:
                    CrystalReport3 report3 = new CrystalReport3();
                    this.crystalReportViewer1.ReportSource = report3;
                    break;
                case ReportType.FlightList:
                    CrystalReport2 report2 = new CrystalReport2();
                    this.crystalReportViewer1.ReportSource = report2;
                    break;
            }
        }
    }
}
