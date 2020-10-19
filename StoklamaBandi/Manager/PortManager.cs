using StoklamaBandi.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Manager
{
    public class PortManager : IPortRepositoryBase
    {
        SerialPort serialPort;
        public PortManager()
        {
            
        }
        public void CreatePort(string port, int baudrate, int stopbits, int databits)
        {
            serialPort = new SerialPort();
            serialPort.PortName = port;
            serialPort.BaudRate = baudrate;
           // serialPort.StopBits = stopbits;
            serialPort.DataBits = databits;
            
        }

        public string[] GetPorts()
        {
            string[] result = SerialPort.GetPortNames();
            return result;
            
        }

        public void SerialPortClose()
        {
            serialPort.Close();
        }

        public bool SerialPortIsOpen()
        {
            return serialPort.IsOpen;
        }

        public void SerialPortOpen()
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
           
        }


    }
}
