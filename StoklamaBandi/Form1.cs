using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using StoklamaBandi.Manager;

namespace StoklamaBandi
{
    public partial class Form1 : Form
    {
        ModbusManager modbusManager;
        FileStream fsSettings;
        StreamReader streader;
        Thread ThRead,ThWrite;
        string _serialPort;
        int[] mw;
        bool startStopBit = false;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateClient();
            CreateThread();
        }

        private void CreateClient()
        {
            ReadSetting();  //COM adresini dosyadan oku

            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }

            if (modbusManager == null)
            {
                modbusManager = new ModbusManager(_serialPort);
            }

            TryConnect();

            if (modbusManager.ModbusIsAvaliable())
            {
                ButtonLock();
            }
        }

        private void TryConnect()
        {
            try
            {
                modbusManager.Connect();
            }

            catch (Exception)
            {
                MessageBox.Show("PLC ile bağlantı sağlanamadı.");

            }
        }

        #region Read Settings
        private string ReadSetting()
        {
            try
            {
                fsSettings = new FileStream("C:/Settings.txt", FileMode.Open, FileAccess.Read);
                streader = new StreamReader(fsSettings);

                _serialPort = streader.ReadLine();


            }
            catch (Exception)
            {
                MessageBox.Show("Ayar dosyası yok");
            }

            return _serialPort;
        }
        #endregion

        #region Thread Islemleri
        private void CreateThread()
        {
            ThRead = new Thread(ThReadStart);
            ThWrite = new Thread(ThWriteStart);
        }

        private void ThWriteStart()
        {
            ModbusIsAvaliable();
            modbusManager.WriteCoilRegister(10, startStopBit);
            Thread.Sleep(200);
        }

        private void ThReadStart()
        {
            ModbusIsAvaliable();
            mw = modbusManager.ReadSingleWord(10);
            lblSayilanAdet.Text = Convert.ToString(mw);
            Thread.Sleep(200);
        }

        private void ModbusIsAvaliable()
        {
            if (!modbusManager.ModbusIsAvaliable())
            {
                OnStop();
                ButtonUnlock();
                MessageBox.Show("PLC ile bağlantı zaman aşımına uğradı");
            }
        }
        #endregion

        #region Buton Kontrolleri 
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            CreateClient();
            if (modbusManager.ModbusIsAvaliable())
            {
                OnStart();
            }
            
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //if (!ThRead.IsAlive | !ThWrite.IsAlive)
            //{
            //    OnStart();
            //}
            startStopBit = true;
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            startStopBit = false;
            //OnStop();
        }
        private void ButtonLock()
        {
            btnConnect.Enabled = false;
        }

        private void ButtonUnlock()
        {
            btnConnect.Enabled = true;
        }
        #endregion

        private void OnStart()
        {
            ThRead.Start();
            ThWrite.Start();
        }

        private void OnStop()
        {
            ThRead.Abort();
            ThWrite.Abort();
        }
    }
}
