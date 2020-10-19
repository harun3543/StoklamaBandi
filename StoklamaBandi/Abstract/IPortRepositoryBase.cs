using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Abstract
{
    interface IPortRepositoryBase
    {
        void CreatePort(string port, int baudrate, int stopbit, int databits);
        string[] GetPorts();
        void SerialPortOpen();
        void SerialPortClose();

        bool SerialPortIsOpen();

    }
}
