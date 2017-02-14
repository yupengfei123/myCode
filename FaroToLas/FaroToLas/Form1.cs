using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IQOPENLib;
using LSSDKLib;

namespace FaroToLas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string filePath;
        private string licenseCode = "FARO Open Runtime License\n"
           + "Key:664WL6NRTCKXXKPT6KZCSPLPJ\n"
           + "\n"
           + "The software is the registered property of "
           + "FARO Scanner Production GmbH, Stuttgart, Germany.\n"
           + "All rights reserved.\n"
           + "This software may only be used with written permission "
           + "of FARO Scanner Production GmbH, Stuttgart, Germany.";
        public IiQLicensedInterfaceIf licLibIf;
        public IiQLibIf libRef;
        public LasFile lasfile;
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                filePath = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licLibIf = new iQLibIfClass();
            licLibIf.License = licenseCode;
            libRef = (IiQLibIf)licLibIf;
            libRef.load(filePath);
            ConvertToLas();
        }
        public void ConvertToLas()
        {
            Array points;
            Array Intensity;
            lasfile = new LasFile();
            int Cols = libRef.getScanNumCols(0);
            int Rows = libRef.getScanNumRows(0);
            for(int col=0;col<Cols;col++)
            {
                libRef.getXYZScanPoints2(0, 0, col, Rows, out points, out Intensity);
                int tempRows=0;
                for(int row=0;row<Rows;row++)
                {
                    PointRecord pointRecord = new PointRecord();
                    pointRecord.X = (Int32)((Convert.ToDouble((points.GetValue(3*row))) - lasfile.header.Xoffset) / lasfile.header.XscaleFactor);
                    pointRecord.Y = (Int32)((Convert.ToDouble((points.GetValue(3*row+1))) - lasfile.header.Yoffset) / lasfile.header.YscaleFactor);
                    pointRecord.Z = (Int32)((Convert.ToDouble((points.GetValue(3*row+2))) - lasfile.header.Zoffset) / lasfile.header.ZscaleFactor);

                    pointRecord.Intensity = Convert.ToUInt16((Intensity.GetValue(tempRows++)));
                    lasfile.pointRecords.Add(pointRecord);
                }
            }
            lasfile.header.NumberofPointRecords = (uint)lasfile.pointRecords.Count;
            lasfile.Sort();
            lasfile.GetLasBytes();
        }
    }
}
