using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StoklamaBandi
{
    public partial class CommonKeybord : DevExpress.XtraEditors.XtraForm
    {
        public CommonKeybord()
        {
            InitializeComponent();
            this.Load += FrmLoad;
        }

        public string ReturnString { get; set; }
        public string setString { get; set; }

        private void FrmLoad(object sender, EventArgs e)
        {
            //_form1 = new Form1();
            this.Show();
            txtString.Text = setString;
            this.CloseBox = false;
            this.ControlBox = false;
            this.MaximizeBox = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton b = (SimpleButton)sender;
            txtString.Text = txtString.Text + b.Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtString.Text.Length > 0)
            {
                txtString.Text = txtString.Text.Remove(txtString.Text.Length - 1);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.ReturnString = txtString.Text;
            this.DialogResult = DialogResult.OK;
            FrmClose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReturnString = setString;
            this.DialogResult = DialogResult.OK;
            FrmClose();
        }

        private void FrmClose()
        {
            this.Close();
        }
    }
}