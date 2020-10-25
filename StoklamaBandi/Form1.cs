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
using StoklamaBandi.EntityFramework.DataAccess;
using StoklamaBandi.EntityFramework.Entity;

namespace StoklamaBandi
{
    delegate void StateEventHandler();
    public partial class Form1 : Form
    {
        ModbusManager modbusManager;
        PortManager portManager;
        ProductDal productDal;
        FileStream fsSettings;
        StreamReader streader;
        Thread  ThReadContinuous, ThWriteContinuous, ThState;
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
            ThState.Start();
            productDal = new ProductDal();
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
            ThReadContinuous = new Thread(new ThreadStart(ThReadConStart));
            ThWriteContinuous = new Thread(new ThreadStart(ThWriteConStart));
            ThState = new Thread(new ThreadStart(ThStateStart));
        }

        private void ThWriteConStart()
        {
            try
            {
                modbusManager.CreateClient("COM1");
                modbusManager.Connect();
                modbusManager.WriteCoilRegister(10, startStopBit);

            }
            catch (Exception)
            {
                ThreadStop();
                ButtonUnlock();
            }
        }

        private void ThReadConStart()
        {
            try
            {
                modbusManager.CreateClient("COM1");
                modbusManager.Connect();

                if (modbusManager.ModbusIsAvaliable())
                {
                    ButtonLock();
                    //OnStart();
                }
                
                mw = modbusManager.ReadSingleWord(10);
                lblSayilanAdet.Text = Convert.ToString(mw);
            }
            catch (Exception)
            {
                ThreadStop();
                ButtonUnlock();
            }
            
            Thread.Sleep(100);
        }

        private void ThStateStart()
        {
            ModbusClientConnect_State();
        }

        private void ThreadStop()
        {
            ThReadContinuous.Abort();
            ThWriteContinuous.Abort();
        }
        #endregion
        
        #region Buton Kontrolleri 
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ThReadContinuous.Start();
            ThWriteContinuous.Start();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            startStopBit = true;
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            startStopBit = false;
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            productDal.Add(new ProductModel { ProductCode = "ad" });
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
