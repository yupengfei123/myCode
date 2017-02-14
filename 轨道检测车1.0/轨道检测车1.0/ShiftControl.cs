using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace 轨道检测车1._0
{
    class ShiftControl
    {
        private byte[] shiftSendOrder = new byte[] { 0x01, 0x04, 0x00, 0x10, 0x00, 0x01,0x30,0x0F };
        public SerialPort shiftPort = new SerialPort();

        public byte[] receivedShiftMsg;
        public List<byte[]> receivedShiftMsgs;                       //接收到的原始字节数据
        public List<string> receivedHexShiftMsgs;                    //转换后的十六进制字符串数据
        public List<string> integrateHexShiftMsgs;                  //整合后的十六进制字符串数据
        public List<double> ShiftMsgs;                             //位移值
        public double offsetValue = 0.0;

        public Thread thd_ShiftProcess;
        public ShiftControl()
        {
            shiftPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            receivedShiftMsgs = new List<byte[]>();
            receivedHexShiftMsgs = new List<string>();
            integrateHexShiftMsgs = new List<string>();
            ShiftMsgs = new List<double>();
            shiftPort.DataReceived += new SerialDataReceivedEventHandler(shiftPort_DataReceived);
            thd_ShiftProcess = new Thread(new ThreadStart(ShiftCaculate));
        }
        private void shiftPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedShiftMsg = new byte[shiftPort.BytesToRead];
            shiftPort.Read(receivedShiftMsg, 0, receivedShiftMsg.Length);
            receivedShiftMsgs.Add(receivedShiftMsg);
            if(receivedShiftMsgs.Count==100)
            {
                thd_ShiftProcess.Start();
            }
        }
        public void Shiftend(object obj)
        {
            shiftPort.Write(shiftSendOrder, 0, shiftSendOrder.Length);
        }
        public void ShiftCaculate()
        {
            for(int n=0;n<receivedShiftMsgs.Count;n++)
            {
                string receivedHexShiftMsg = ByteToHexStr(receivedShiftMsgs[n]);
                receivedHexShiftMsgs.Add(receivedHexShiftMsg);
            }
            IntegrateData();
            ConvertToShift();
            WriteIntoFile();
            thd_ShiftProcess.Abort();
        }
        
        public string ByteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int n = 0; n < bytes.Length; n++)
                {
                    returnStr += bytes[n].ToString("X2");
                }
            }
            return returnStr;
        }
        public void WriteIntoFile()
        {
            FileStream fs = new FileStream("C:\\Users\\ZXC\\Desktop\\项目\\位移数据文件\\1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("标准轨距：1435mm"+" "+"安置偏移量"+offsetValue);
            for (int n = 0; n < ShiftMsgs.Count; n++)
            {
                sw.WriteLine(ShiftMsgs[n].ToString());
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("存储完毕");
        }
        public void ConvertToShift()
        {
            string shiftMsgStr = string.Empty;
            double analogShift = 0.0;
            double shiftMsg = 0.0;

            for (int n=0;n<integrateHexShiftMsgs.Count;n++)
            {
                shiftMsgStr = integrateHexShiftMsgs[n].Substring(6, 4);
                analogShift = (double)Convert.ToInt64(shiftMsgStr, 16) / 100.0;
                shiftMsg = CaculateShift(analogShift, offsetValue);
                ShiftMsgs.Add(shiftMsg);
            }
        }
        public double CaculateShift(double analShift,double offset)
        {
            double shift = (15.625 * analShift - 11.5) + offset;
            return shift;
        }
        public void IntegrateData()
        {
            int n = 0;
            string currentHexShiftMsg = receivedHexShiftMsgs[n];
            while (n < receivedHexShiftMsgs.Count)
            {
                string integrateHexShiftMsg = string.Empty;
                if (currentHexShiftMsg.Length < 14)
                {
                    integrateHexShiftMsg = receivedHexShiftMsgs[n];
                    if (n < receivedHexShiftMsgs.Count - 1)
                    {
                        currentHexShiftMsg = receivedHexShiftMsgs[++n];
                    }
                    else
                    {
                        break;
                    }
                    if (currentHexShiftMsg != null)
                    {
                        while (integrateHexShiftMsg.Length < 14)
                        {
                            integrateHexShiftMsg += currentHexShiftMsg;
                            if (n < receivedHexShiftMsgs.Count - 1)
                            {
                                currentHexShiftMsg = receivedHexShiftMsgs[++n];
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (integrateHexShiftMsg.Length == 14)
                        {
                            integrateHexShiftMsgs.Add(integrateHexShiftMsg);
                            continue;
                        }
                        if (integrateHexShiftMsg.Length > 14)
                        {
                            integrateHexShiftMsgs.Add(integrateHexShiftMsg.Substring(0, 14));
                            currentHexShiftMsg += integrateHexShiftMsg.Remove(0, 14);
                            continue;
                        }
                        int length = integrateHexShiftMsg.Length;
                        integrateHexShiftMsg += currentHexShiftMsg.Substring(0, 14 - length);
                        currentHexShiftMsg = currentHexShiftMsg.Remove(0, 14 - length);
                    }
                    if (currentHexShiftMsg == "")
                    {
                        currentHexShiftMsg = receivedHexShiftMsgs[++n];
                    }
                }
                else if (currentHexShiftMsg.Length == 14)
                {
                    integrateHexShiftMsg = currentHexShiftMsg;
                    integrateHexShiftMsgs.Add(integrateHexShiftMsg);
                    if (n < receivedHexShiftMsgs.Count - 1)
                    {
                        currentHexShiftMsg = receivedHexShiftMsgs[++n];
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    integrateHexShiftMsg = currentHexShiftMsg.Substring(0, 14);
                    integrateHexShiftMsgs.Add(integrateHexShiftMsg);
                    currentHexShiftMsg = currentHexShiftMsg.Remove(0, 14);
                }
            }
        }
    }
}
