using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 轨道检测车1._0
{
    public partial class Form1 : Form
    {
        private FaroScanControl m_FaroScanControl;
        private MileageControl m_MileageControl;
        private ShiftControl m_ShiftControl;
        private DataProcess m_DataProcess;

        public bool IsRecord = false;

        System.Threading.Timer MilegeTimeItem;
        System.Threading.TimerCallback MileageTimerDelegate;

        System.Threading.Timer ShiftTimeItem;
        System.Threading.TimerCallback ShiftTimerDelegate;
           
        public Form1()
        {
            InitializeComponent();

            ColumnHeader headerScan = new ColumnHeader();
            headerScan.Text = "扫描文件";
            headerScan.Width = 130;

            ColumnHeader headerMileage = new ColumnHeader();
            headerMileage.Text = "里程文件";
            headerMileage.Width = 130;

            ColumnHeader headerShift = new ColumnHeader();
            headerShift.Text = "位移文件";
            headerShift.Width = 130;

            listView2.Columns.AddRange(new ColumnHeader[] { headerScan, headerMileage, headerShift });

            ColumnHeader headerLas = new ColumnHeader();
            headerLas.Text = "Las文件";
            headerLas.Width = 140;
            headerLas.TextAlign = HorizontalAlignment.Center;

            listView3.Columns.Add(headerLas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //m_FaroScanControl = new FaroScanControl();
            m_MileageControl = new MileageControl();
            m_ShiftControl = new ShiftControl();
            m_DataProcess = new DataProcess();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //显示里程计对应的串口
                cbCOM1.Text = m_MileageControl.mileagePort.PortName;
                cbCOM1.Items.Add(cbCOM1.Text);

                //显示位移计对应的串口
                cbCOM2.Text = m_ShiftControl.shiftPort.PortName;
                cbCOM2.Items.Add(cbCOM2.Text);

                //连接激光扫描仪
               /* m_FaroScanControl.ScanCompleted += (s, ev) =>
                {
                    MessageBox.Show(DateTime.Now.ToString("hh:mm:ss") + " 扫描已停止" + "\r\n");
                };
                while (true)
                {
                    if (m_FaroScanControl.ScanConnect() == true)
                    {
                        MessageBox.Show("连接成功");
                        break;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("连接不成功,是否继续连接", "提示:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            break;
                    }
                }*/
            }
            catch
            {
                m_FaroScanControl.ShowExceptions();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //开启里程计串口,开辟里程数据发送线程
               /* m_MileageControl.mileagePort.Open();
                MileageTimerDelegate = new System.Threading.TimerCallback(m_MileageControl.MileageSend);*/

                //开启位移计串口,开辟位移数据发送线程
                m_ShiftControl.shiftPort.Open();
                ShiftTimerDelegate = new
                System.Threading.TimerCallback(m_ShiftControl.Shiftend);
                //启动扫描
               /* m_FaroScanControl.StartHelicalCanGreyScan();*/

                BtnRecord.Enabled = true;
            }
            catch
            {
                m_FaroScanControl.ShowExceptions();
            }
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            //里程计开启记录
            //MilegeTimeItem= new System.Threading.Timer(MileageTimerDelegate,null,0,10);

            //位移计开启记录
            ShiftTimeItem = new System.Threading.Timer(ShiftTimerDelegate,null,0,100);

            //记录扫描
           /* if(IsRecord)
            {
                m_FaroScanControl.PauseScan();
                BtnRecord.Text = "已经暂停";
                BtnRecord.BackColor = BackColor;
                IsRecord = false;
            }
            else
            {
                m_FaroScanControl.RecordScan();
                if(m_FaroScanControl.RecordingStatus())
                {
                    BtnRecord.Text = "正在记录";
                    BtnRecord.BackColor = Color.Red;
                    IsRecord = true;
                }
                else
                {
                    MessageBox.Show("扫描仪在预热,请在闪烁红灯之后点击记录");
                }
            }*/
        }
        private void BtnDataLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                m_DataProcess.baseFilePath = fbd.SelectedPath;
                m_DataProcess.GetAllFiles(fbd.SelectedPath);
                for (int n = 0; n < m_DataProcess.faroFilePath.Count; n++)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = m_DataProcess.faroFilePath[n];
                    item.SubItems.Add(m_DataProcess.mileageFilePath[n]);
                    item.SubItems.Add(m_DataProcess.shiftFilePath[n]);

                    listView2.Items.Add(item);
                }
                MessageBox.Show("数据加载成功！");
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string lasFilePath = m_DataProcess.baseFilePath + "\\Las数据文件";
            string lasFullPath = string.Empty;
            Directory.CreateDirectory(lasFilePath);
            for(int n=0;n<m_DataProcess.faroFilePath.Count;n++)
            {
                lasFullPath = lasFilePath + "\\" + (n + 1).ToString() + ".las";
                m_DataProcess.ConvertToLas(m_DataProcess.mileageFilePath[n], m_DataProcess.shiftFilePath[n], m_DataProcess.faroFilePath[n], lasFullPath);

                ListViewItem item = new ListViewItem();

                item.Text = lasFilePath;
                listView3.Items.Add(item);

                MessageBox.Show("数据转换完毕");
            }
        }
    }
}
