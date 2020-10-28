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
using DevExpress;

namespace StoklamaBandi
{
    delegate void StateEventHandler();
    public partial class Form1 : Form
    {
        ModbusManager modbusManager;
        ProductModel _product;
        ProductDal productDal;
        FileStream fsSettings;
        StreamReader streader;
        Thread ThReadContinuous, ThWriteContinuous, ThState;
        string _serialPortName, returnId;

        int[] mw;
        string sIstenilenAdet;
        bool startStopBit = false;
        bool readSettingFlag = false;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modbusManager = new ModbusManager();
            productDal = new ProductDal();
            CreateThread();
            LoadProduct();
            ThState.Start();

        }
        private void LoadProduct()
        {
            var productList = productDal.GetAll();
            dgwRecipe.DataSource = productList;
            cbxSelectRecipe.DataSource = productList;
            cbxSelectRecipe.DisplayMember = "ProductCode";
            cbxSelectRecipe.ValueMember = "ProductID";
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

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ThWriteConStart()
        {
            try
            {
                //modbusManager.CreateClient("COM1");
                modbusManager.Connect();
                modbusManager.WriteCoilRegister(10, startStopBit);

            }
            catch (Exception e)
            {
                ThreadStop();
                ButtonUnlock();
                lblSistemDurumu.Text = e.Message;
            }
        }

        private void ThReadConStart()
        {
            try
            {
                //modbusManager.CreateClient("COM1");
                modbusManager.Connect();

                if (modbusManager.ModbusIsAvaliable())
                {
                    ButtonLock();
                    //OnStart();
                }

                mw = modbusManager.ReadSingleWord(10);
                lblSayilanAdet.Text = Convert.ToString(mw);
            }
            catch (Exception e)
            {
                ThreadStop();
                ButtonUnlock();
                lblSistemDurumu.Text = e.Message;
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
            MessageBox.Show("PLC ile bağlantı koptu.");
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
            productDal.Add(new ProductModel
            {
                ProductCode = txtProductCode.Text,
                ProductName = txtProductName.Text
            });
            LoadProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Update(new ProductModel
            {
                ProductID = Convert.ToInt32(returnId),
                ProductCode = txtProductCode.Text,
                ProductName = txtProductName.Text
            });
            LoadProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productDal.Delete(new ProductModel
            {
                ProductID = Convert.ToInt32(returnId)
            });
            LoadProduct();
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

        #region Event işlemleri
        private void dgwRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            returnId = dgwRecipe.CurrentRow.Cells[0].Value.ToString();
            txtProductCode.Text = dgwRecipe.CurrentRow.Cells[1].Value.ToString();
            txtProductName.Text = dgwRecipe.CurrentRow.Cells[2].Value.ToString();
        }

        private void cbxSelectRecipe_IndexChanged(object sender, EventArgs e)
        {
            var result = (ProductModel)cbxSelectRecipe.SelectedItem;
            var product = productDal.GetDetails(result.ProductID);
            lblShowProductCode.Text = product.ProductCode;
            lblShowProductName.Text = product.ProductName;

        }
        private void TxtIstenilenAdet_EditValueChanged(object sender, EventArgs e)
        {
            sIstenilenAdet = txtIstenilenAdet.Text;
            lblShowAdet.Text = txtIstenilenAdet.Text;
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit otextBox = (DevExpress.XtraEditors.TextEdit)sender;
            otextBox.Text = ShowKeybord(otextBox.Text);
        }
        #endregion

        private string ShowKeybord(string str)
        {
            string result1 = "";
            using (var userKeybord = new UserKeybord())
            {
                userKeybord.setString = str;
                var result = userKeybord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    result1 = userKeybord.ReturnString;
                }
            }
            return result1;
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
