using StoklamaBandi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoklamaBandi
{
    public partial class UserKeybord : Form 
    {
        string _textString;
        public string ReturnString {get;set;}
        public string setString { get; set; }

        public UserKeybord()
        {
            InitializeComponent();
            this.Load += FrmLoad; 
            
        }

        private void FrmLoad(object sender, EventArgs e)
        {
            //_form1 = new Form1();
            this.Show();
            txtString.Text = setString;
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

        private void UserKeybord_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

    }
}
