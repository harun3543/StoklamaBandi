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
        public FrmTest()
        {
            InitializeComponent();

            this.Load += CreateModbusRTU;
        }

        private void CreateModbusRTU(object sender, EventArgs e)
        {
            string[] portlar = SerialPort.GetPortNames();
            foreach (string ports in portlar)
            {
                comboBox1.Items.Add(ports);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
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
            serialPort1.Close();
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
    }
}