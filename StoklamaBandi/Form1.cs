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
using StoklamaBandi.Printer;

namespace StoklamaBandi
{
    delegate void StateEventHandler();
    public partial class Form1 : Form
    {
        ModbusManager modbusManager;
        PrinterHelper printer;
        ProductDal productDal;
        List<PrintModel> modelList;
        Thread thCycle;
        //FileStream fsSettings;
        //StreamReader streader;
        //string _serialPortName;
        string returnId;
        const int _istDegerMem = 100;
        const int _istToplamDegerMem = 110;
        const int _okuDegerMem = 10;
        const int _sayilanToplamMiktarMem = 20;
        const int _sayilanKasaMiktarıMem = 26;
        const int _startMem = 5;
        const int _resetMem = 6;
        const int _resetPiston = 7;
        const int _memResetToplamMik = 13;
        const int _memResetKasaMik = 14;


        int[] mwSayilan, mwSayilanToplamMiktar, mwSayilanKasaMiktarı;
        bool[] mb;
        string sIstenilenAdet;
        int _kalanToplamMiktar = 0;
        bool startStopBit = false, resetFlag, flagResetToplamMik, flagResetKasaMik;
        bool printFlag = false, flag = false, pistonFlag = false;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thCycle = new Thread(new ThreadStart(ThCycleStart));
            productDal = new ProductDal();
            printer = new PrinterHelper();
            modelList = new List<PrintModel>();
            LoadProduct();
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnResetPiston.Enabled = false;
            btnKasaİciMReset.Enabled = false;
            _kalanToplamMiktar = 0;
        }

        private void ThCycleStart()
        {
            while (true)
            {
                try
                {
                    //Modbus TCP bağlanma durumunu izleme
                    ThStateStart();

                    //if (!flag)
                    //{
                    //    bool[] _mb = modbusManager.ReadSingleCoil(_startMem);
                    //    startStopBit = _mb[0];
                    //    flag = true;
                    //}

                    //********************PLC den okuma işlmeleri*****************
                    mwSayilan = modbusManager.ReadSingleWord(_okuDegerMem);
                    lblSayilanAdet.Text = Convert.ToString(mwSayilan[0]);
                    mwSayilanToplamMiktar = modbusManager.ReadSingleWord(_sayilanToplamMiktarMem);
                    lblToplamMiktar.Text = Convert.ToString(mwSayilanToplamMiktar[0]);
                    mwSayilanKasaMiktarı = modbusManager.ReadSingleWord(_sayilanKasaMiktarıMem);
                    lblKasaNumarasi.Text = Convert.ToString(mwSayilanKasaMiktarı[0]);

                    labelControl8.Text = Convert.ToString(_kalanToplamMiktar);
                    mb = modbusManager.ReadSingleCoil(_startMem);

                    if (txtIstenilenAdet.Text != "")
                    {
                        modbusManager.WriteSingleWord(_istDegerMem, Convert.ToInt32(txtIstenilenAdet.Text));
                    }

                    //******************PLC ye yazma işlemleri************************
                    modbusManager.WriteCoilRegister(_startMem, startStopBit);
                    modbusManager.WriteCoilRegister(_resetMem, resetFlag);
                    modbusManager.WriteCoilRegister(_resetPiston, pistonFlag);
                    modbusManager.WriteCoilRegister(_memResetToplamMik, flagResetToplamMik);
                    modbusManager.WriteCoilRegister(_memResetKasaMik, flagResetKasaMik);

                    StateSystemRun();

                    //Yazdırma işlemi
                    if (txtIstenilenAdet.Text != "")
                    {
                        if (Convert.ToInt32(txtIstenilenAdet.Text) == mwSayilan[0] && printFlag == false && startStopBit)
                        {
                            printFlag = true;
                            _kalanToplamMiktar = _kalanToplamMiktar - Convert.ToInt32(txtIstenilenAdet.Text);

                            RunPrint();

                            if (_kalanToplamMiktar < Convert.ToInt32(txtIstenilenAdet.Text))
                            {
                                txtIstenilenAdet.Text = Convert.ToString(_kalanToplamMiktar);
                            }

                        }
                        //if (Convert.ToInt32(txtIstenilenAdet.Text) < mwSayilan[0] || mwSayilan[0] == 0 || mwSayilan[0] == 1)
                        if (Convert.ToInt32(txtIstenilenAdet.Text) < mwSayilan[0] || Convert.ToInt32(txtIstenilenAdet.Text) > mwSayilan[0])
                        {
                            printFlag = false;
                        }

                    }


                    if (resetFlag)
                    {
                        resetFlag = false;
                    }

                }

                //*******************Hata*********************
                catch (Exception)
                {
                    //TimerStop();
                    ButtonUnlock();
                    lblSistemDurumu.Text = "Sistem ile bağlantı kesildi.";
                }
                Thread.Sleep(100);
            }
            
        }

        private void LoadProduct()
        {
            var productList = productDal.GetAll();
            dgwRecipe.DataSource = productList;
            dgwRecipe.Columns[0].Visible = false;
            dgwRecipe.Columns[1].HeaderText = "Malzeme Kodu";
            dgwRecipe.Columns[2].HeaderText = "Malzeme Adı";
            dgwRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbxSelectRecipe.DataSource = productList;
            cbxSelectRecipe.DisplayMember = "ProductCode";
            cbxSelectRecipe.ValueMember = "ProductID";
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Modbus TCP bağlanma durumunu izleme
                ThStateStart();

                //if (!flag)
                //{
                //    bool[] _mb = modbusManager.ReadSingleCoil(_startMem);
                //    startStopBit = _mb[0];
                //    flag = true;
                //}

                //********************PLC den okuma işlmeleri*****************
                mwSayilan = modbusManager.ReadSingleWord(_okuDegerMem);
                lblSayilanAdet.Text = Convert.ToString(mwSayilan[0]);
                mwSayilanToplamMiktar = modbusManager.ReadSingleWord(_sayilanToplamMiktarMem);
                lblToplamMiktar.Text = Convert.ToString(mwSayilanToplamMiktar[0]);
                mwSayilanKasaMiktarı = modbusManager.ReadSingleWord(_sayilanKasaMiktarıMem);
                lblKasaNumarasi.Text = Convert.ToString(mwSayilanKasaMiktarı[0]);

                labelControl8.Text = Convert.ToString(_kalanToplamMiktar);
                mb = modbusManager.ReadSingleCoil(_startMem);

                if (txtIstenilenAdet.Text != "")
                {
                    modbusManager.WriteSingleWord(_istDegerMem, Convert.ToInt32(txtIstenilenAdet.Text));
                }

                if (txtToplamMiktar.Text != "")
                {
                    modbusManager.WriteSingleWord(_istToplamDegerMem, Convert.ToInt32(txtToplamMiktar.Text));
                }

                //******************PLC ye yazma işlemleri************************
                modbusManager.WriteCoilRegister(_startMem, startStopBit);
                modbusManager.WriteCoilRegister(_resetMem, resetFlag);
                modbusManager.WriteCoilRegister(_resetPiston, pistonFlag);
                modbusManager.WriteCoilRegister(_memResetToplamMik, flagResetToplamMik);
                modbusManager.WriteCoilRegister(_memResetKasaMik, flagResetKasaMik);

                StateSystemRun();

                //Yazdırma işlemi
                if (txtIstenilenAdet.Text != "")
                {
                    if (Convert.ToInt32(txtIstenilenAdet.Text) == mwSayilan[0] && printFlag == false && startStopBit)
                    {
                        printFlag = true;
                        _kalanToplamMiktar = _kalanToplamMiktar - Convert.ToInt32(txtIstenilenAdet.Text);
                        
                        RunPrint();

                        if (_kalanToplamMiktar < Convert.ToInt32(txtIstenilenAdet.Text) && _kalanToplamMiktar > 0)
                        {
                            txtIstenilenAdet.Text = Convert.ToString(_kalanToplamMiktar);
                        }

                    }
                    //if (Convert.ToInt32(txtIstenilenAdet.Text) < mwSayilan[0] || mwSayilan[0] == 0 || mwSayilan[0] == 1)
                    if (Convert.ToInt32(txtIstenilenAdet.Text) < mwSayilan[0] || Convert.ToInt32(txtIstenilenAdet.Text) > mwSayilan[0])
                    {
                        printFlag = false;
                    }

                }


                //Resetleme buton kontrolleri
                if (resetFlag)
                {
                    resetFlag = false;
                }

                if (flagResetKasaMik)
                {
                    flagResetKasaMik = false;
                }

                if (flagResetToplamMik)
                {
                    flagResetToplamMik = false;
                }

            }

            //*******************Hata*********************
            catch (Exception)
            {
                TimerStop();
                ButtonUnlock();

            }
        }

        private void RunPrint()
        {
            //int resultIstenilen = Convert.ToInt32(txtIstenilenAdet.Text);

            try
            {
                modelList.Clear();
                var code = lblShowProductCode.Text;
                var name = lblShowProductName.Text;
                var adet = Convert.ToInt32(txtIstenilenAdet.Text);
                var barcode = lblShowProductCode.Text + lblShowProductName.Text + txtIstenilenAdet.Text;
                modelList.Add(new PrintModel
                {
                    MalzemeKodu = code,
                    MalzemeAdi = name,
                    Miktar = adet,
                    Barkod = barcode
                });

                printer.Print(modelList);

            }
            catch (Exception)
            {

                MessageBox.Show("Yazıcıdan çıktı alınamadı.");
            }

        }

        private void StateSystemRun()
        {
            if (mb[0] == true)
            {
                stateStartStop.StateIndex = 3;
            }

            else
            {
                stateStartStop.StateIndex = 1;
            }
        }

        private void ThStateStart()
        {
            // while (true)
            //{
            ModbusClientConnect_State();
            //}
        }

        private void TimerStop()
        {
            timer1.Stop();
            modbusManager.Disconnect();
            stateConnectComponent.StateIndex = 1;
            stateStartStop.StateIndex = 1;
            lblSistemDurumu.Text = "Sistem ile bağlantı kesildi.";
            MessageBox.Show("PLC ile bağlantı kesildi.");

        }

        #region Buton Kontrolleri 
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusManager = new ModbusManager();
                modbusManager.Connect();
                lblSistemDurumu.Text = "Bağlantı Sağlandı.";
                
                if (modbusManager.ModbusIsAvaliable())
                {
                    timer1.Start();
                   // thCycle.Start();
                    ButtonLock();
                    btnResetPiston.Enabled = true;
                    btnKasaİciMReset.Enabled = true;

                }

            }
            catch (Exception)
            {

                lblSistemDurumu.Text = "Bağlantı Sağlanamadı.";
            }

        }

        private void btnDisconnect(object sender, EventArgs e)
        {
            // modbusManager.Disconnect();
            //lblSistemDurumu.Text = "Sistem ile bağlantı kesildi.";
            TimerStop();
            ButtonUnlock();
            btnResetPiston.Enabled = false;
            //stateConnectComponent.StateIndex = 1;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (txtIstenilenAdet.Text != "" && txtToplamMiktar.Text != "")
            {
                startStopBit = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnKasaİciMReset.Enabled = false;
                btnResetPiston.Enabled = false;
                _kalanToplamMiktar = Convert.ToInt32(txtToplamMiktar.Text) - (mwSayilanKasaMiktarı[0] * Convert.ToInt32(txtIstenilenAdet.Text));
            }

            else
            {
                MessageBox.Show("Lütfen Adet miktarlarını boş bırakmayınız.");
            }

        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            startStopBit = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnKasaİciMReset.Enabled = true;
            btnResetPiston.Enabled = true;
            printFlag = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            resetFlag = true;


        }

        private void BtnResetPiston_Click(object sender, EventArgs e)
        {
            pistonFlag = true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text != "" && txtProductName.Text != "")
            {
                productDal.Add(new ProductModel
                {
                    ProductCode = txtProductCode.Text,
                    ProductName = txtProductName.Text
                });
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Lütfen malzeme alanlarını boş bırakmayınız.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                productDal.Update(new ProductModel
                {
                    ProductID = Convert.ToInt32(returnId),
                    ProductCode = txtProductCode.Text,
                    ProductName = txtProductName.Text
                });
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen listeden bir ürün seçiniz.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productDal.Delete(new ProductModel
                {
                    ProductID = Convert.ToInt32(returnId)
                });
                returnId = "";
                txtProductCode.Text = "";
                txtProductName.Text = "";
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silinecek malzemeyi listeden seçiniz.");
            }

        }
        private void ButtonLock()
        {
            btnConnect.Enabled = false;

            //btnMiktarReset.Enabled = false;
        }

        private void ButtonUnlock()
        {
            btnConnect.Enabled = true;

            //btnMiktarReset.Enabled = true;
        }

        private void btnShowDesigner_Click(object sender, EventArgs e)
        {
            modelList.Clear();
            var code = lblShowProductCode.Text;
            var name = lblShowProductName.Text;
            var barcode = lblShowProductName.Text + lblShowProductCode.Text + txtIstenilenAdet.Text;
            var adet = Convert.ToInt32(txtIstenilenAdet.Text);
            modelList.Add(new PrintModel
            {
                MalzemeKodu = code,
                MalzemeAdi = name,
                Miktar = adet,
                Barkod = barcode
            });
            //var model1 = printer.GetDatasource(code, name, adet, barcode);
            printer.ShowDesigner(modelList);

        }

        private void btnShowPreview_Click(object sender, EventArgs e)
        {
            modelList.Clear();
            var code = lblShowProductCode.Text;
            var name = lblShowProductName.Text;
            var barcode = lblShowProductName.Text + lblShowProductCode.Text + txtIstenilenAdet.Text;
            if (txtIstenilenAdet.Text != "")
            {
                var adet = Convert.ToInt32(txtIstenilenAdet.Text);
                modelList.Add(new PrintModel
                {
                    MalzemeKodu = code,
                    MalzemeAdi = name,
                    Miktar = adet,
                    Barkod = barcode
                });

                printer.ShowPreview(modelList);
            }
            else
            {
                MessageBox.Show("Lütfen adet miktrını giriniz.");
            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                modelList.Clear();
                var code = lblShowProductCode.Text;
                var name = lblShowProductName.Text;
                var barcode = lblShowProductName.Text + lblShowProductCode.Text + txtIstenilenAdet.Text;
                var adet = Convert.ToInt32(txtIstenilenAdet.Text);
                modelList.Add(new PrintModel
                {
                    MalzemeKodu = code,
                    MalzemeAdi = name,
                    Miktar = adet,
                    Barkod = barcode
                });

                printer.Print(modelList);
            }
            catch (Exception)
            {

                MessageBox.Show("Yazıcıdan çıktı alınamadı.");
            }

        }

        private void btnFrmClose(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Close();
        }

        private void btnToplamMReset_Click(object sender, EventArgs e)
        {
            flagResetToplamMik = true;
        }

        private void btnKasaMReset_Click(object sender, EventArgs e)
        {
            flagResetKasaMik = true;
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
            otextBox.Text = ShowCommonKeybord(otextBox.Text);
        }

        private void TxtNumber_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit otextBox = (DevExpress.XtraEditors.TextEdit)sender;
            otextBox.Text = ShowNumberKeybord(otextBox.Text);
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

        private string ShowCommonKeybord(string str)
        {
            string result1 = "";
            using (var commonKeybord = new CommonKeybord())
            {
                commonKeybord.setString = str;
                var result = commonKeybord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    result1 = commonKeybord.ReturnString;
                }
            }
            return result1;
        }

        private string ShowNumberKeybord(string str)
        {
            string result1 = "";
            using (var NumberKeybord = new NumberKeybord())
            {
                NumberKeybord.setString = str;
                var result = NumberKeybord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    result1 = NumberKeybord.ReturnString;
                }
            }
            return result1;
        }

        private void ModbusClientConnect_State()
        {
            try
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
            catch (Exception)
            {


            }

        }
    }
}
