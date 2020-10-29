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
using EasyModbus;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

using SharpModbus;

namespace StoklamaTest
{
    public partial class FrmTest : DevExpress.XtraEditors.XtraForm
    {
        ModbusClient modbusClient;
        string _ip = "192.168.12.12";
        const int _port = 502;
        SerialPort serialport1;
        Thread t;

        public FrmTest()
        {
            InitializeComponent();

            this.Load += FrmLoad;
        }

        private void FrmLoad(object sender, EventArgs e){
            
            //serialport1 = new SerialPort();
            //serialport1.BaudRate = 9600;
            //serialport1.StopBits = StopBits.One;
            //serialport1.DataBits = 8;
            //serialport1.PortName = "COM8";
            //serialport1.Open();
            //t = new Thread(new ThreadStart(ConnectToModbus));
            string[] portlar = SerialPort.GetPortNames();
            foreach (string ports in portlar)
            {
                comboBox1.Items.Add(ports);
            }
        }

        void ConnectToModbus() {

            try
            {
                modbusClient = new ModbusClient(_ip, _port);
                //modbusClient.Baudrate = 9600;
                //modbusClient.StopBits = StopBits.One;
                //modbusClient.Parity = Parity.None;
                modbusClient.Connect();
                //MessageBox.Show("Bağlantı kuruldu");

            }

            catch (Exception)
            {
                //MessageBox.Show("Bağlantı sağlanamadı");
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                modbusClient = new ModbusClient(_ip,_port);
                //modbusClient.Baudrate = 9600;
                //modbusClient.StopBits = StopBits.One;
                //modbusClient.Parity = Parity.None;
                //modbusClient.UnitIdentifier = 1;
                //modbusClient.ConnectionTimeout = 1000;
                modbusClient.ReceiveDataChanged += new ModbusClient.ReceiveDataChangedHandler(ReceviedHandler);
                modbusClient.Connect();
                MessageBox.Show("Başarılı bir şekilde bağlandı");
            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı Sağlanamadı");
            }
            
        }

        private void ReceviedHandler(object sender)
        {
            
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            //t.Abort();
            
        }

        private void BtnSetCoil_Click(object sender, EventArgs e)
        {
            //modbusClient = new ModbusClient(selectedPort);
            //modbusClient.Baudrate = 9600;
            //modbusClient.StopBits = StopBits.One;
            //modbusClient.Parity = Parity.None;
            try
            {
                //modbusClient.Connect();
                int register = Convert.ToInt32(txtCoilRegister.Text);
                modbusClient.WriteSingleCoil(00001 + register, true);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Bit set etme başarısız.");
            }


        }

        private void BtnResetCoil_Click(object sender, EventArgs e)
        {
            //modbusClient = new ModbusClient(selectedPort);
            //modbusClient.Baudrate = 9600;
            //modbusClient.StopBits = StopBits.One;
            //modbusClient.Parity = Parity.None;
            try
            {
                //modbusClient.Connect();
                int register = Convert.ToInt32(txtCoilRegister.Text);
                modbusClient.WriteSingleCoil(00001 + register, false);
            }
            catch (Exception)
            {

                MessageBox.Show("Bit reset etme başarısız.");
            }

        }

        private void BtnSetWord_Click(object sender, EventArgs e)
        {
            try
            {
                int register = Convert.ToInt32(txtWordRegister.Text);
                int value = Convert.ToInt32(txtWordValue.Text);
                int result = 40001 + register;
                modbusClient.WriteSingleRegister(40001 + register, value);
            }

            catch (Exception)
            {

                MessageBox.Show("Word gönderme başarısız.");
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedPort = comboBox1.Text;
        }

        //private void TestClick(object sender, EventArgs e)
        //{
        //    ShowKeybord();
        //}

        private void txtCoilRegister_Click(object sender, EventArgs e)
        {
            txtCoilRegister.Text = ShowKeybord();
        }

        private void txtWordRegister_Click(object sender, EventArgs e)
        {
            txtWordRegister.Text = ShowKeybord();
        }
        private void txtWordValue_Click(object sender, EventArgs e)
        {
            txtWordValue.Text = ShowKeybord();
        }
        private string ShowKeybord()
        {
            string result1 ="";
            using (var userKeybord = new UserKeybord())
            {
                var result = userKeybord.ShowDialog();
                if (result==DialogResult.OK)
                {
                     result1 = userKeybord.ReturnString;
                }
            }
            return result1;
        }

        private void btnShowDesigner_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }
    }
}