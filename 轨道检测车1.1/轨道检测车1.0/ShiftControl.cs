using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace 轨道检测车1._0
{
    class ShiftControl
    {
        private byte[] shiftSendOrder = new byte[] { 0x01, 0x03, 0x00, 0x10, 0x00, 0x08, 0x45, 0xC9 };
        public SerialPort shiftPort = new SerialPort();
        public byte[] receivedShiftMsg;
        public List<byte[]> receivedShiftMsgs;
        public ShiftControl()
        {
            shiftPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            receivedShiftMsgs = new List<byte[]>();
            shiftPort.DataReceived += new SerialDataReceivedEventHandler(shiftPort_DataReceived);
        }
        private void shiftPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedShiftMsg = new byte[shiftPort.BytesToRead];
            shiftPort.Read(receivedShiftMsg, 0, receivedShiftMsg.Length);
            receivedShiftMsgs.Add(receivedShiftMsg);
        }
        public void Shiftend(object obj)
        {
            shiftPort.Write(shiftSendOrder, 0, shiftSendOrder.Length);
        }
    }
}
