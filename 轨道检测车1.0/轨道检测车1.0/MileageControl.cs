using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace 轨道检测车1._0
{
    class MileageControl
    {
        private byte[] mileageSendOrder = new byte[] { 0x01, 0x03, 0x00, 0x10, 0x00, 0x08, 0x45, 0xC9 };

        public SerialPort mileagePort;
        public double perimeter=0.628;

        public byte[] receivedMileMsg;
        public List<byte[]> receivedMileMsgs;      //接收到的原始字节数据
        public List<string> receivedHexMileMsgs=new List<string>();   //转换后的十六进制字符串数据
        public List<string> integrateHexMileMsgs=new List<string>(); //整合后的十六进制字符串数据
        public List<double> leftMileages = new List<double>();  //左里程
        public List<double> leftShifts = new List<double>();    //与上一次里程的位移值（左）
        public List<double> rightMileages = new List<double>();  //右里程
        public List<double> rightShifts = new List<double>();    //与上一次里程的位移值（右）

        public Thread thd_MileageProcess;

        public MileageControl()
        {
            mileagePort = new SerialPort("COM1", 115200, Parity.None, 8, StopBits.One);
            receivedMileMsgs = new List<byte[]>();
            mileagePort.DataReceived += new SerialDataReceivedEventHandler(mileagePort_DataReceived);
            thd_MileageProcess = new Thread(new ThreadStart(MileageCaculate));
        }
        private void mileagePort_DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
            receivedMileMsg = new byte[mileagePort.BytesToRead];
            mileagePort.Read(receivedMileMsg, 0, receivedMileMsg.Length);
            receivedMileMsgs.Add(receivedMileMsg);
            if(receivedMileMsgs.Count==1000)
            {
                thd_MileageProcess.Start();
            }
        }
        public void MileageSend(object obj)
        {
            mileagePort.Write(mileageSendOrder, 0, mileageSendOrder.Length);
        }
        public void MileageCaculate()
        {
            for(int n=0;n<receivedMileMsgs.Count;n++)
            {
                string receivedHexMileMsg = ByteToHexStr(receivedMileMsgs[n]);
                receivedHexMileMsgs.Add(receivedHexMileMsg);
            }
            IntegrateData();
            ConvertToMileage();
            WriteIntoFile();
            thd_MileageProcess.Abort();
        }
        public void WriteIntoFile()
        {
            FileStream fs = new FileStream("C:\\Users\\ZXC\\Desktop\\项目\\里程数据文件\\4.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("里程1" + " " + "位移1" + " " + "里程2" + " " + "位移2");
            for(int n=0;n<leftMileages.Count;n++)
            {
                sw.WriteLine(leftMileages[n].ToString()+" "+leftShifts[n].ToString()+" "+rightMileages[n].ToString()+" "+rightShifts[n].ToString());
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("存储完毕");
        }
        public void LeftCaculate(List<double>lAngles)
        {
            leftMileages.Add(0);
            leftShifts.Add(0);
            double leftShift;
            double leftMileage;
            for (int i = 1; i < lAngles.Count; i++)
            {
                double detaAngle = lAngles[i] - lAngles[i - 1];
                if (detaAngle >= 0 && detaAngle <= 100000000)                   //顺时针旋转，正常情况
                {
                    leftShift = detaAngle / 360.0 * perimeter;
                    leftShifts.Add(leftShift);
                    leftMileage = leftMileages[i - 1] + leftShift;
                    leftMileages.Add(leftMileage);
                }
                else if (detaAngle > 100000000)                                 //逆时针旋转，归0跃变
                {
                    detaAngle = lAngles[i] - (lAngles[i - 1] + 429496729.5);
                    leftShift = detaAngle / 360.0 * perimeter;
                    leftShifts.Add(leftShift);
                    leftMileage = leftMileages[i - 1] + leftShift;
                    leftMileages.Add(leftMileage);
                }
                else if (detaAngle < 0 && Math.Abs(detaAngle) <= 100000000)            //逆时针旋转，正常情况           
                {
                    leftShift = detaAngle / 360.0 * perimeter;
                    leftShifts.Add(leftShift);
                    leftMileage = leftMileages[i - 1] + leftShift;
                    leftMileages.Add(leftMileage);
                }
                else
                {
                    detaAngle = (lAngles[i] + 429496728.5) - lAngles[i - 1];   //顺时针旋转，归0跃变
                    leftShift = detaAngle / 360.0 * perimeter;
                    leftShifts.Add(leftShift);
                    leftMileage = leftMileages[i - 1] + leftShift;
                    leftMileages.Add(leftMileage);
                }
            }
        }
        public void RightCaculate(List<double>rAngles)
        {
            rightMileages.Add(0);
            rightShifts.Add(0);
            double rightShift;
            double rightMileage;
            for (int i = 1; i < rAngles.Count; i++)
            {
                double detaAngle = rAngles[i] - rAngles[i - 1];
                if (detaAngle >= 0 && detaAngle <= 100000000)                   //顺时针旋转，正常情况
                {
                    rightShift = detaAngle / 360.0 * perimeter;
                    rightShifts.Add(rightShift);
                    rightMileage = rightMileages[i - 1] + rightShift;
                    rightMileages.Add(rightMileage);
                }
                else if (detaAngle > 100000000)                                 //逆时针旋转，归0跃变
                {
                    detaAngle = rAngles[i] - (rAngles[i - 1] + 429496729.5);
                    rightShift = detaAngle / 360.0 * perimeter;
                    rightShifts.Add(rightShift);
                    rightMileage = rightMileages[i - 1] + rightShift;
                    rightMileages.Add(rightMileage);
                }
                else if (detaAngle < 0 && Math.Abs(detaAngle) <= 100000000)            //逆时针旋转，正常情况           
                {
                    rightShift = detaAngle / 360.0 * perimeter;
                    rightShifts.Add(rightShift);
                    rightMileage = rightMileages[i - 1] + rightShift;
                    rightMileages.Add(rightMileage);
                }
                else
                {
                    detaAngle = (rAngles[i] + 429496728.5) - rAngles[i - 1];   //顺时针旋转，归0跃变
                    rightShift = detaAngle / 360.0 * perimeter;
                    rightShifts.Add(rightShift);
                    rightMileage = rightMileages[i - 1] + rightShift;
                    rightMileages.Add(rightMileage);
                }
            }
        }
        public void ConvertToMileage()
        {
            List<string> leftHexMileages = new List<string>();
            List<string> rightHexMileages = new List<string>();
            string leftHexMileage = string.Empty;
            string rightHexMileeage = string.Empty;

            for(int n=0;n<integrateHexMileMsgs.Count;n++)
            {
                leftHexMileage = integrateHexMileMsgs[n].Substring(6, 8);
                leftHexMileages.Add(leftHexMileage);
                rightHexMileeage = integrateHexMileMsgs[n].Substring(22,8);
                rightHexMileages.Add(rightHexMileeage);
            }

            List<double> leftAngles = new List<double>();
            List<double> rightAngles = new List<double>();
            leftAngles.Add(0);
            rightAngles.Add(0);

            for (int i = 0; i < leftHexMileages.Count; i++)
            {
                double leftAngle = (double)Convert.ToInt64(leftHexMileages[i], 16) / 10.0;
                leftAngles.Add(leftAngle);
            }
            for (int i = 0; i < rightHexMileages.Count; i++)
            {
                double rightAngle = (double)Convert.ToInt64(rightHexMileages[i], 16) / 10.0;
                rightAngles.Add(rightAngle);
            }
            LeftCaculate(leftAngles);
            RightCaculate(rightAngles);
            
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
        public void IntegrateData()
        {
            int n = 0;
            string currentHexMileMsg = receivedHexMileMsgs[n];
            while(n<receivedHexMileMsgs.Count)
            {
                string integrateHexMileMsg = string.Empty;
                if (currentHexMileMsg.Length<42)
                {
                    integrateHexMileMsg = receivedHexMileMsgs[n];
                    if (n < receivedHexMileMsgs.Count-1)
                    {
                        currentHexMileMsg = receivedHexMileMsgs[++n];
                    }
                    else
                    {
                        //integrateHexMileMsgs.Add(integrateHexMileMsg);
                        break;
                    }
                    if (currentHexMileMsg != null)
                    {
                        while (integrateHexMileMsg.Length<42)
                        {
                            integrateHexMileMsg += currentHexMileMsg;
                            if (n < receivedHexMileMsgs.Count - 1)
                            {
                                currentHexMileMsg = receivedHexMileMsgs[++n];
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (integrateHexMileMsg.Length == 42)
                        {
                            integrateHexMileMsgs.Add(integrateHexMileMsg);
                            continue;
                        }
                        if (integrateHexMileMsg.Length > 42)
                        {
                            integrateHexMileMsgs.Add(integrateHexMileMsg.Substring(0, 42));
                            currentHexMileMsg += integrateHexMileMsg.Remove(0, 42);
                            continue;
                        }
                        int length = integrateHexMileMsg.Length;
                        integrateHexMileMsg += currentHexMileMsg.Substring(0, 42 - length);
                        currentHexMileMsg = currentHexMileMsg.Remove(0, 42 - length);
                    }
                    if(currentHexMileMsg=="")
                    {
                        currentHexMileMsg = receivedHexMileMsgs[++n];
                    }
                }
                else if(currentHexMileMsg.Length==42)
                {
                    integrateHexMileMsg = currentHexMileMsg;
                    integrateHexMileMsgs.Add(integrateHexMileMsg);
                    currentHexMileMsg = receivedHexMileMsgs[++n];
                }
                else
                {
                    integrateHexMileMsg = currentHexMileMsg.Substring(0, 42);
                    integrateHexMileMsgs.Add(integrateHexMileMsg);
                    currentHexMileMsg =currentHexMileMsg.Remove(0, 42);
                }
            }
        }
    }
}
