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
    delegate void StateEventHandler();
    public partial class Form1 : Form
    {
        ModbusManager modbusManager;
        PortManager portManager;
        FileStream fsSettings;
        StreamReader streader;
        Thread  ThContinuous;
        string _serialPortName;
        
        int[] mw;
        bool startStopBit = false;
        bool readSettingFlag = false;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //portManager = new PortManager();
            modbusManager = new ModbusManager();
            //CreateModbusManager();
            CreateThread();
        }

        private void CreatePort()
        {
            if (!readSettingFlag)
            {
                portManager.CreatePort(_serialPortName, 9600, 1, 8);
                portManager.SerialPortOpen();
            }
        }

        private void CreateModbusManager()
        {
            //ReadSetting();  //COM adresini dosyadan oku
            //if (!readSettingFlag)
            //{
            //}


        }

        #region Read Settings
        private string ReadSetting()
        {
            try
            {
                fsSettings = new FileStream("C:/Users/harun.durmus/Documents/Setiings.txt", FileMode.Open, FileAccess.Read);
                streader = new StreamReader(fsSettings);

                _serialPortName = streader.ReadLine();


            }

            catch (Exception)
            {
                MessageBox.Show("Ayar dosyası yok");
                readSettingFlag = true;
            }

            return _serialPortName;
        }
        #endregion

        #region Thread Islemleri
        private void CreateThread()
        {
            ThContinuous = new Thread(new ThreadStart(ThContinuousStart));
           
        }

        private void ThContinuousStart()
        {
            ModbusClientConnect_State();
            try
            {
                modbusManager.CreateClient("COM1");
                modbusManager.Connect();
                if (modbusManager.ModbusIsAvaliable())
                {
                    ButtonLock();
                    //OnStart();
                }
                modbusManager.WriteCoilRegister(10, startStopBit);
                mw = modbusManager.ReadSingleWord(10);
                lblSayilanAdet.Text = Convert.ToString(mw);
            }
            catch (Exception)
            {
                ThreadStop();
            }
            
            Thread.Sleep(100);
        }

        private void ModbusIsAvaliable()
        {
            if (!modbusManager.ModbusIsAvaliable())
            {
                ThreadStop();
                ButtonUnlock();
                MessageBox.Show("PLC ile bağlantı zaman aşımına uğradı");
            }
        }
        #endregion

        #region Buton Kontrolleri 
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ThContinuous.Start();

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
        }

        private void ThreadStop()
        {
            ThContinuous.Abort();
        }

        private void ModbusClientConnect_State()
        {
            if (ModbusManager.StStateConnection)
            {
                stateConnectComponent.StateIndex = 3;
            }
            else
            {
                stateConnectComponent.StateIndex = 1;
            }
        }
    }
}
