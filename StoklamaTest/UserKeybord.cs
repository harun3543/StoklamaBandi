using StoklamaTest.Keybord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoklamaTest
{
    public partial class UserKeybord : Form 
    {
        string _textString;
        FrmTest frmTest;

        public string ReturnString {get;set;}

        public UserKeybord()
        {
            InitializeComponent();
            this.Load += FrmLoad; 
        }

        private void FrmLoad(object sender, EventArgs e)
        {
            frmTest = new FrmTest();
            this.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtString.Text = txtString.Text + b.Text;
        }

        private void BackSpace(object sender, EventArgs e)
        {
            txtString.Text = txtString.Text.Remove(txtString.Text.Length -1);
        }

        private void btnKaydet(object sender, EventArgs e)
        {
            returnString();
            this.ReturnString = _textString;
            this.DialogResult = DialogResult.OK;
            FrmClose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmClose();
        }

        public void returnString()
        {
            _textString = txtString.Text;
        }

        private void FrmClose()
        {
            this.Close();
        }

        private void UserKeybord_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


    }
}
