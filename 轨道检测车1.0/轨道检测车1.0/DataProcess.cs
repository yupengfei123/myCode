using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQOPENLib;
using System.IO;

namespace 轨道检测车1._0
{
    public class DataProcess
    {
        public List<string> mileageFilePath;
        public List<string> shiftFilePath;
        public List<string> faroFilePath;
        public string baseFilePath;

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

       public DataProcess()
       {
           licLibIf = new iQLibIfClass();
           licLibIf.License = licenseCode;
           libRef = (IiQLibIf)licLibIf;
           lasfile = new LasFile();

           mileageFilePath = new List<string>();
           shiftFilePath = new List<string>();
           faroFilePath = new List<string>();
           baseFilePath = string.Empty;
       }
       public void GetAllFiles(string dataName)
       {
           DirectoryInfo TheFolder = new DirectoryInfo(dataName);
           foreach (DirectoryInfo NextProjectFolder in TheFolder.GetDirectories())
           {
               foreach (DirectoryInfo NextFolder in NextProjectFolder.GetDirectories())
               {
                   switch (NextFolder.Name)
                   {
                       case "里程数据":
                           {
                               foreach (FileInfo NextFile in NextFolder.GetFiles())
                               {
                                   mileageFilePath.Add(NextFile.FullName);
                               }
                               break;
                           }
                       case "位移数据":
                           {
                               foreach (FileInfo NextFile in NextFolder.GetFiles())
                               {
                                   shiftFilePath.Add(NextFile.FullName);
                               }
                               break;
                           }
                       case "激光扫描数据":
                           {
                               foreach (DirectoryInfo faroNextFolder in NextFolder.GetDirectories())
                               {
                                   faroFilePath.Add(faroNextFolder.FullName);
                               }
                               break;
                           }
                       default:
                           break;
                   }
               }
           }
       }
       public void ConvertToLas(string mileagePath,string shiftPath,string faroPath, string lasPath)
       {
            Array points;
            Array Intensity;
            lasfile = new LasFile();
            libRef.load(faroPath);
            int Cols = libRef.getScanNumCols(0);
            int Rows = libRef.getScanNumRows(0);
            for (int col = 0; col < Cols; col++)
            {
                libRef.getXYZScanPoints2(0, 0, col, Rows, out points, out Intensity);
                int tempRows = 0;
                for (int row = 0; row < Rows; row++)
                {
                    PointRecord pointRecord = new PointRecord();
                    pointRecord.X = (Int32)((Convert.ToDouble((points.GetValue(3 * row))) - lasfile.header.Xoffset) / lasfile.header.XscaleFactor);
                    pointRecord.Y = (Int32)((Convert.ToDouble((points.GetValue(3 * row + 1))) - lasfile.header.Yoffset) / lasfile.header.YscaleFactor);
                    pointRecord.Intensity = Convert.ToUInt16((Intensity.GetValue(tempRows++)));
                    lasfile.pointRecords.Add(pointRecord);
                }
            }
            lasfile.AddMileage(mileagePath,Rows,Cols);
            lasfile.AddShift(shiftPath,Rows,Cols);

            lasfile.header.NumberofPointRecords = (uint)lasfile.pointRecords.Count;
            lasfile.Sort();
            lasfile.lasBytes=lasfile.GetLasBytes();
            lasfile.WriteIntoFile(lasPath);
       }
    }
}
