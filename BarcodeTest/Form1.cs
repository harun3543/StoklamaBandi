using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevExpress.XtraPrinting;


namespace BarcodeTest
{
    public partial class Form1 : Form
    {
        BarcodeLib.Barcode barcode;
        DevExpress.XtraPrinting.BarCode.QRCodeGenerator barCodeDev;
        public Form1()
        {
            InitializeComponent();

            this.Load += FormLoad;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            barcode = new BarcodeLib.Barcode();

        }

        private void btnCreateBarcode(object sender, EventArgs e)
        {
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, txtBardoceString.Text, Color
                .Black, Color.White, 320, 240);
            pictureBox1.Image = img;

            barCodeDev = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();

        }
    }
}
