﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTest
{
    public partial class FrmPrint : Form
    {
        public FrmPrint()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            report.DataSource = GetDatasourceList();
            report.LoadLayout(textEdit1.Text);
            report.ShowDesignerDialog();
        }

        List<PrintModel> GetDatasourceList()
        {
            List<PrintModel> oPrintData = new List<PrintModel>();
            oPrintData.Add(new PrintModel()
            {
                MalzemeAdi = "SUMIRIKO MALZMEMESİ 1",
                MalzemeKodu = "02-KS-DY0016",
                Miktar = 10,
                Barkod = "123123123123"
            });

            oPrintData.Add(new PrintModel()
            {
                MalzemeAdi = "SUMIRIKO MALZMEMESİ 2",
                MalzemeKodu = "02-KS-DY0017",
                Miktar = 10,
                Barkod = "ASDASDASDASDAS"
            });

            return oPrintData;
        }

        PrintModel GetDatasource()
        {
            PrintModel oPrintData = new PrintModel();
            oPrintData = new PrintModel()
            {
                MalzemeAdi = "SUMIRIKO MALZMEMESİ 1",
                MalzemeKodu = "02-KS-DY0016",
                Miktar = 10,
                Barkod = "123123123123"
            };

            return oPrintData;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            report.DataSource = GetDatasourceList();
            report.LoadLayout(textEdit1.Text);
            report.ShowPreviewDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            report.DataSource = GetDatasource();
            report.LoadLayout(textEdit1.Text);
            ReportPrintTool printTool = new ReportPrintTool(report);
            //printTool.PrintDialog();
            printTool.Print("Argox OS-214 plus series PPLA");

            //report.Print("Argox OS-214 plus series PPLA");
        }
    }
    public class PrintModel
    {
        public string MalzemeAdi { get; set; }
        public string MalzemeKodu { get; set; }
        public float Miktar { get; set; }
        public string Barkod { get; set; }
    }
}
