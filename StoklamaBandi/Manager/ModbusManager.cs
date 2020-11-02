using EasyModbus;
using StoklamaBandi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoklamaBandi.Manager
{
    public class ModbusManager : IModbusManager,IDisposable
    {
        ModbusClient modbusClient;
        public static bool StStateConnection;
        const string _ip= "169.254.14.183";  //GMT IP Adres
        const int _port = 502;
        public ModbusManager()
        {
            CreateClient(_ip, _port);
        }

        public void CreateClient(string ip, int port)
        {
            modbusClient = new ModbusClient(ip,port);
            modbusClient.ConnectedChanged += new ModbusClient.ConnectedChangedHandler(StateConnection);
            //Connect();
        }

        public void Connect()
        {
            //PLC ile Ethernet üzerinden bağlantı kurma
             modbusClient.Connect();

        }

        public bool ModbusIsAvaliable()
        {
            return modbusClient.Connected;

        }

        public void Disconnect()
        {
            modbusClient.Disconnect();
        }

        public bool[] ReadSingleCoil(int registerAdd)
        {
            bool[] mb = modbusClient.ReadCoils(0 + registerAdd, 1);
            return mb;
        }

        public int[] ReadSingleWord(int registerAdd)
        {
            int[] mw = modbusClient.ReadHoldingRegisters(0 + registerAdd, 1);
            return mw;
        }
        public int[] ReadSingleInt(int registerAdd)
        {
            int[] mi = modbusClient.ReadHoldingRegisters(1000 + registerAdd, 2);
            return mi;
        }

        //***Word değer yazdırma.
        public void WriteSingleWord(int registerAdd, int value)
        {
            modbusClient.WriteSingleRegister(0 + registerAdd, value);
        }

        //***Int değer yazdırma
        public void WriteSingleInt(int registerAdd, int value)
        {
            modbusClient.WriteSingleRegister(1000 + registerAdd, value);
        }

        //***Memory bit değeri gönderme.
        public void WriteCoilRegister(int registerAdd, bool bitValue)
        {
            modbusClient.WriteSingleCoil(0 + registerAdd, bitValue);
          
        }

        private void StateConnection(object sender)
        {
            StStateConnection = modbusClient.Connected;
        }

        public void Dispose()
        {
            
        }
    }
}
