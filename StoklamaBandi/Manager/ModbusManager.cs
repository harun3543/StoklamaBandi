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
        public ModbusManager(string serialPort)
        {
            CreateClient(serialPort);
        }

        private void CreateClient(string serialPort)
        {
            modbusClient = new ModbusClient(serialPort);
            //modbusClient.UnitIdentifier = 1; Not necessary since default slaveID = 1;
            //modbusClient.Baudrate = 9600;	// Not necessary since default baudrate = 9600
            //modbusClient.Parity = System.IO.Ports.Parity.None;
            //modbusClient.StopBits = System.IO.Ports.StopBits.Two;
            //modbusClient.ConnectionTimeout = 500;			

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

    }
}
