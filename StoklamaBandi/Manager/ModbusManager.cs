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
    public class ModbusManager : IModbusManager
    {
        ModbusClient modbusClient;
        public static bool StStateConnection;
        const int _port = 502;
        public ModbusManager()
        {
            CreateClient("192.168.12.13",_port);
            //modbusClient.ConnectedChanged += new ModbusClient.ConnectedChangedHandler(StateConnection);
        }

        public void CreateClient(string ip, int port)
        {
            modbusClient = new ModbusClient(ip,port);
            //modbusClient.UnitIdentifier = 1;// Not necessary since default slaveID = 1;
            //modbusClient.Baudrate = 9600;	// Not necessary since default baudrate = 9600
            //modbusClient.Parity = System.IO.Ports.Parity.None;
            //modbusClient.StopBits = System.IO.Ports.StopBits.One;
            //modbusClient.ConnectionTimeout = 1000;
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

        public int[] ReadSingleWord(int registerAdd)
        {
            int[] mw = modbusClient.ReadHoldingRegisters(40001 + registerAdd, 1);
            return mw;
        }
        public int[] ReadSingleInt(int registerAdd)
        {
            int[] mi = modbusClient.ReadHoldingRegisters(41001 + registerAdd, 2);
            return mi;
        }

        //***Word değer yazdırma.
        public void WriteSingleWord(int registerAdd, int value)
        {
            modbusClient.WriteSingleRegister(40001 + registerAdd, value);
        }

        //***Int değer yazdırma
        public void WriteSingleInt(int registerAdd, int value)
        {
            modbusClient.WriteSingleRegister(41001 + registerAdd, value);
        }

        //***Memory bit değeri gönderme.
        public void WriteCoilRegister(int registerAdd, bool bitValue)
        {
            modbusClient.WriteSingleCoil(00001 + registerAdd, bitValue);
          
        }

        //public virtual void StateConnection(object sender)
        //{
        //    StStateConnection = modbusClient.Connected;
        //}
        private void StateConnection(object sender)
        {
            StStateConnection = modbusClient.Connected;
        }
    }
}
