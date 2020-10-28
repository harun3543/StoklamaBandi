using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Printer
{
    public interface IPrinterHelper
    {
        List<PrintModel> GetDatasourceList();
        PrintModel GetDatasource(string malzemekodu, string malzemeadi, int miktar, string barcode);
        void Print(List<PrintModel> model);
        void ShowDesigner(List<PrintModel> model);
        void ShowPreview(List<PrintModel> model);
        
    }
}
