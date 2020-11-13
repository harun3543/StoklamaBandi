using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Printer
{
    public class PrinterHelper : IPrinterHelper
    {
        const string layoutPath = @"C:\REPORTBASE\SAYICI_RAPOR_YENI.repx";
        const string printerName = "Argox OS-214 plus series PPLA";
        ReportPrintTool printTool;

        public PrinterHelper()
        {

        }
        public PrintModel GetDatasource(string malzemekodu, string malzemeadi, int miktar, string barcode)
        {
            var result = new PrintModel
            {
                MalzemeKodu = malzemekodu,
                MalzemeAdi = malzemeadi,
                Barkod = barcode,
                Miktar = miktar
            };

            return result;
        }

        public List<PrintModel> GetDatasourceList()
        {
            throw new NotImplementedException();
        }

        public void Print(List<PrintModel> model)
        {
            using (XtraReport report = new XtraReport())
            {
                printTool = new ReportPrintTool(report);
                report.DataSource = model;
                report.LoadLayout(layoutPath);
                report.ShowPrintMarginsWarning = false;
                //report.Print(printerName);
                report.ShowPrintMarginsWarning = false;
                report.ShowPreviewMarginLines = false;
                report.ShowPrintStatusDialog = false;

                printTool.Print(printerName);
            }

        }

        public void ShowDesigner(List<PrintModel> model)
        {
            using (XtraReport report = new XtraReport())
            {
                report.DataSource = model;
                report.LoadLayout(layoutPath);
                report.ShowDesignerDialog();
            }

        }

        public void ShowPreview(List<PrintModel> model)
        {
            using (XtraReport report = new XtraReport())
            {
                report.DataSource = model;
                report.LoadLayout(layoutPath);
                report.ShowPreviewDialog();
            }

        }
    }
}
