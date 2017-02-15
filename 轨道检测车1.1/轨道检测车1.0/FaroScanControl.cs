using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LSSDKLib;
using IQOPENLib;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace 轨道检测车1._0
{
    class FaroScanControl:_IScanCtrlSDKEvents
    {
        //更换扫描仪时需更换许可码
        private string licenseCode = "FARO Open Runtime License\n"
            + "Key:"
            + "664WL6NRTCKXXKPT6KZCSPLPJ"
            + "\n"
            + "\n"
            + "The software is the registered property of "
            + "FARO Scanner Production GmbH, Stuttgart, Germany.\n"
            + "All rights reserved.\n"
            + "This software may only be used with written permission "
            + "of FARO Scanner Production GmbH, Stuttgart, Germany.";
        private IScanCtrlSDK scanCtrl { get; set; }
        private int cookie;
        private IConnectionPoint connectionPoint;

        //更换扫描仪时需更换扫描仪的IP
        public string ScanIP = "172.17.15.178";
        public int NumCols = 1000000;          //总线数
        public int SplitLines = 10000;         //单个文件的线数
        public int ScanFileNum=1;                //扫描初始编号
        public string ScanFileName="移动扫描";            //扫描文件基本名
        public string FilePath="E://";                //文件存储路径
        public event EventHandler ScanCompleted;

         /// <summary>
        /// 构造函数
        /// </summary>
        public FaroScanControl()
        {
            IiQLicensedInterfaceIf licSDKIf = new ScanCtrlSDKClass();
            licSDKIf.License = licenseCode;
            scanCtrl = (IScanCtrlSDK)licSDKIf;
        }
        
        ///<summary>
        ///连接扫描仪
        ///<summary>
        ///
        public bool ScanConnect()
        {
            scanCtrl.ScannerIP = ScanIP;
            scanCtrl.connect();
            Thread.Sleep(1000);
            if(scanCtrl.Connected)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Implements _IScanCtrlSDKEvents.scanCompleted
        /// </summary>
        /// <remarks>See documentation 8.3.1.4</remarks>
        public void scanCompleted()
        {
            connectionPoint.Unadvise(cookie);
            OnScanCompleted(EventArgs.Empty);
        }
        protected void OnScanCompleted(EventArgs e)
        {
            var temp = ScanCompleted;
            if(temp!=null)
            {
                temp(this, e);
            }
        }
        public void StartHelicalCanGreyScan()
        {
            Guid IID_IScanCtrlSDKEvents = typeof(_IScanCtrlSDKEvents).GUID;
            ((IConnectionPointContainer)scanCtrl).FindConnectionPoint(ref IID_IScanCtrlSDKEvents, out connectionPoint);
            connectionPoint.Advise(this, out cookie);
            // 可设置扫描参数
            scanCtrl.ScanMode = ScanMode.HelicalCanGrey;
            scanCtrl.SplitAfterLines = SplitLines;
            scanCtrl.NumCols = NumCols;
            scanCtrl.ScanFileNumber = ScanFileNum;
            scanCtrl.ScanBaseName = ScanFileName;
            scanCtrl.StorageMode = StorageMode.SMLocal;   //存储于机身SD卡中

            //固定扫描参数
            scanCtrl.Resolution = 4;
            scanCtrl.MeasurementRate = 8;
            scanCtrl.NoiseCompression = 1;
            scanCtrl.syncParam();
            Thread.Sleep(1000);
            scanCtrl.startScan();
        }

        /// <summary>
        /// Get progress of scanning.
        /// </summary>
        public int ScanProgress
        {
            get
            {
                return scanCtrl.ScanProgress;
            }
        }
        public int RecordScan()
        {
            return scanCtrl.recordScan();
        }
        public void ShowExceptions()
        {
            string exceptionMessages = string.Empty;
            for(int i=0;i<scanCtrl.NumberExceptions;i++)
            {
                exceptionMessages+=scanCtrl.getExceptionMsg(i)+"\n";
            }
            MessageBox.Show(exceptionMessages);
       
        }

        /// <summary>
        /// Pauses scan data recording when scanning on helical CAN mode. Restart scan data recording with RecordScan.
        /// </summary>
        public void PauseScan()
        {
            switch (scanCtrl.pauseScan())
            {
                case 0:
                    return;
                case 3:
                    throw new InvalidOperationException("not connected");
                default:
                    throw new InvalidOperationException("unknown return value");
            }
        }
        public bool RecordingStatus()
        {
            Thread.Sleep(1000);
            HelicalRecordingStatus status;
            scanCtrl.inquireRecordingStatus(out status);
            if (status.ToString() == "HRSRecording")
                return true;
            else
                return false;

        }
    }
}
