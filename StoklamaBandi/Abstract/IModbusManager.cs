using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Abstract
{
    interface IModbusManager
    {
        void CreateClient(string ip, int port);
        void WriteSingleWord(int registerAdd, int value);
        void WriteSingleInt(int registerAddi, int value);
        int[] ReadSingleWord(int registerAdd);
        int[] ReadSingleInt(int registerAdd);
        void Connect();
        void Disconnect();
        void WriteCoilRegister(int registerAdd, bool bitValue);
        bool ModbusIsAvaliable();
    }
}
