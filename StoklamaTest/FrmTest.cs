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

namespace StoklamaTest
{
    public partial class FrmTest : DevExpress.XtraEditors.XtraForm
    {
        ModbusClient modbusClient;
        string selectedPort = "COM1";
        SerialPort serialport1;
        public FrmTest()
        {
            InitializeComponent();

            this.Load += CreateModbusRTU;
        }

        private void CreateModbusRTU(object sender, EventArgs e)
        {
            serialport1 = new SerialPort();
            serialport1.BaudRate = 9600;
           // serialport1.StopBits = 0;
            serialport1.DataBits = 8;
            

            string[] portlar = SerialPort.GetPortNames();
            foreach (string ports in portlar)
            {
                comboBox1.Items.Add(ports);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            serialport1.PortName = selectedPort;
            try
            {
                if (!serialport1.IsOpen)
                {
                    serialport1.Open();
                    MessageBox.Show("Bağlantı sağlandı");
                }
                modbusClient = new ModbusClient(comboBox1.Text);
                modbusClient.Connect();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı sağlanamadı");
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            serialport1.Close();
        }

        private void BtnSetCoil_Click(object sender, EventArgs e)
        {
            int register = Convert.ToInt32(txtCoilRegister.Text);
            modbusClient.WriteSingleCoil(register, true);
        }

        private void BtnResetCoil_Click(object sender, EventArgs e)
        {
            int register = Convert.ToInt32(txtCoilRegister.Text);
            modbusClient.WriteSingleCoil(register, false);
        }

        private void BtnSetWord_Click(object sender, EventArgs e)
        {
            int register = Convert.ToInt32(txtWordRegister.Text);
            int value = Convert.ToInt32(txtWordValue.Text);
            modbusClient.WriteSingleRegister(40001 + register, value);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = comboBox1.Text;
        }
    }
}