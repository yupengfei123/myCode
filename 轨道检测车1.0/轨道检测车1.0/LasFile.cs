using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 轨道检测车1._0
{
    public class LasFile
    {
        public Header header;
        public VariableRecordHeader variableRecordHeader;
        public PointRecord pointRecord;
        public List<PointRecord> pointRecords;
        public List<byte> lasBytes;

        public LasFile()
        {
            header = new Header();
            variableRecordHeader = new VariableRecordHeader();
            pointRecord = new PointRecord();
            pointRecords = new List<PointRecord>();
            lasBytes = new List<byte>();
        }
        public void WriteIntoFile(string lasFilePath)
        {
            FileStream fs = new FileStream(lasFilePath, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int n = 0; n < lasBytes.Count; n++)
            {
                bw.Write(lasBytes[n]);
            }
            bw.Close();
            fs.Close();
        }
        public void AddMileage(string mileageFileName,int rows,int cols)
        {
            FileStream fs = new FileStream(mileageFileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            for (int col = 0; col < cols;col++ )
            {
                string mileage = sr.ReadLine();
                for(int row=col*rows;row<rows*(col+1);row++)
                {
                    pointRecords[row].Z = Convert.ToInt32((Convert.ToDouble(mileage) - header.Zoffset) / header.ZscaleFactor);
                }
            }
            sr.Close();
            fs.Close();
        }
        public void AddShift(string shiftFileName,int rows,int cols)
        {
            FileStream fs = new FileStream(shiftFileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            for (int col = 0; col < cols; col++)
            {
                string shift = sr.ReadLine();
                for (int row = col * rows; row < rows * (col + 1); row++)
                {
                    pointRecords[row].UserData = shift.ToCharArray();
                }
            }
            sr.Close();
            fs.Close();
        }
        public List<byte> GetLasBytes()
        {
            List<byte> lasbytes = new List<byte>();
            lasbytes.AddRange(header.GetHeaderBytes());
            lasbytes.AddRange(variableRecordHeader.GetVariableHeaderBytes());
            foreach(PointRecord PR in pointRecords)
            {
                lasbytes.AddRange(PR.GetPointRecordBytes());
            }
            return lasbytes;
        }
        public void Sort()
        {
            List<Int32> xCoordinates = new List<int>();
            List<Int32> yCoordinates = new List<int>();
            List<Int32> zCoordinates = new List<int>();

            foreach(PointRecord pr in pointRecords)
            {
                xCoordinates.Add(pr.X);
                yCoordinates.Add(pr.Y);
                zCoordinates.Add(pr.Z);
            }

            xCoordinates.Sort();
            header.MinX = (xCoordinates[0] * header.XscaleFactor) + header.Xoffset;
            header.MaxX = (xCoordinates[xCoordinates.Count-1] * header.XscaleFactor) + header.Xoffset;

            yCoordinates.Sort();
            header.MinY = (yCoordinates[0] * header.YscaleFactor) + header.Yoffset;
            header.MaxY = (yCoordinates[yCoordinates.Count - 1] * header.YscaleFactor) + header.Yoffset;

            zCoordinates.Sort();
            header.MinZ = (zCoordinates[0] * header.ZscaleFactor) + header.Zoffset;
            header.MaxZ = (zCoordinates[zCoordinates.Count - 1] * header.ZscaleFactor) + header.Zoffset;

        }
    }
    public class Header
    {
        public char[] FileSignature;
        public ushort FileSourceID;
        public ushort GlobalEncoding;
        public UInt32 ProjectID1;
        public ushort ProjectID2;
        public ushort ProjectID3;
        public char[] ProjectID4;
        public char[] VersionMajor;
        public char[] VersionMinor;
        public char[]SystemIdentifier;
        public char[] GeneratingSoftware;
        public ushort CreationDay;
        public ushort CreationYear;
        public ushort HeaderSize;
        public UInt32 OffsetToPoint;
        public UInt32 NumberofVariableLengthRecords;
        public char[] PointDataFormatID;
        public ushort PointDataRecordLenrth;
        public UInt32 NumberofPointRecords;
        public UInt32[] NumberofPointByReturn;
        public double XscaleFactor;
        public double YscaleFactor;
        public double ZscaleFactor;
        public double Xoffset;
        public double Yoffset;
        public double Zoffset;
        public double MaxX;
        public double MinX;
        public double MaxY;
        public double MinY;
        public double MaxZ;
        public double MinZ;

        public List<byte> headerBytes;

        public Header()
        {
            FileSignature = new char[] {'L','A','S','F'};
            FileSourceID = 0;
            GlobalEncoding = 0;
            ProjectID1 = 4;
            ProjectID2 = 1;
            ProjectID3 = 0;
            ProjectID4 = new char[8];
            VersionMajor = new char[]{''};
            VersionMinor = new char[]{''};
            SystemIdentifier = new char[32];
            GeneratingSoftware = new char[32];
            CreationDay = 0;
            CreationYear = 0;
            HeaderSize = 227;
            OffsetToPoint = 281;
            NumberofVariableLengthRecords = 1;                       //一个变长记录区
            PointDataFormatID = new char[]{'\0'};
            PointDataRecordLenrth = 20;
            NumberofPointRecords = 0;
            NumberofPointByReturn = new UInt32[5];
            XscaleFactor = 0.0000001;
            YscaleFactor = 0.0000001;
            ZscaleFactor = 0.001;
            Xoffset = 0.0;
            Yoffset = 0.0;
            Zoffset = 0.0;
            MaxX = 0.0;
            MinX = 0.0;
            MaxY = 0.0;
            MinY = 0.0;
            MaxZ = 0.0;
            MinZ = 0.0;

            headerBytes = new List<byte>();
        }

        public List<byte> GetHeaderBytes()
        {
            List<byte> headerbytes = new List<byte>();

            headerbytes.AddRange(Encoding.UTF8.GetBytes(FileSignature));
            headerbytes.AddRange(BitConverter.GetBytes(FileSourceID));
            headerbytes.AddRange(BitConverter.GetBytes(GlobalEncoding));
            headerbytes.AddRange(BitConverter.GetBytes(ProjectID1));
            headerbytes.AddRange(BitConverter.GetBytes(ProjectID2));
            headerbytes.AddRange(BitConverter.GetBytes(ProjectID3));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(ProjectID4));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(VersionMajor));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(VersionMinor));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(SystemIdentifier));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(GeneratingSoftware));
            headerbytes.AddRange(BitConverter.GetBytes(CreationDay));
            headerbytes.AddRange(BitConverter.GetBytes(CreationYear));
            headerbytes.AddRange(BitConverter.GetBytes(HeaderSize));
            headerbytes.AddRange(BitConverter.GetBytes(OffsetToPoint));
            headerbytes.AddRange(BitConverter.GetBytes(NumberofVariableLengthRecords));
            headerbytes.AddRange(Encoding.UTF8.GetBytes(PointDataFormatID));
            headerbytes.AddRange(BitConverter.GetBytes(PointDataRecordLenrth));
            headerbytes.AddRange(BitConverter.GetBytes(NumberofPointRecords));

            for (int n = 0; n < 5;n++)
            {
                headerbytes.AddRange(BitConverter.GetBytes(NumberofPointByReturn[n]));
            }
            headerbytes.AddRange(BitConverter.GetBytes(XscaleFactor));
            headerbytes.AddRange(BitConverter.GetBytes(YscaleFactor));
            headerbytes.AddRange(BitConverter.GetBytes(ZscaleFactor));
            headerbytes.AddRange(BitConverter.GetBytes(Xoffset));
            headerbytes.AddRange(BitConverter.GetBytes(Yoffset));
            headerbytes.AddRange(BitConverter.GetBytes(Zoffset));
            headerbytes.AddRange(BitConverter.GetBytes(MaxX));
            headerbytes.AddRange(BitConverter.GetBytes(MinX));
            headerbytes.AddRange(BitConverter.GetBytes(MaxY));
            headerbytes.AddRange(BitConverter.GetBytes(MinY));
            headerbytes.AddRange(BitConverter.GetBytes(MaxZ));
            headerbytes.AddRange(BitConverter.GetBytes(MinZ));

            return headerbytes;
        }
    }

    public class VariableRecordHeader
    {
        public ushort Reserved;
        public char[] UserID;
        public ushort RecordID;
        public ushort RecordLengthAfterHeader;
        public char[] Description;
        public List<byte> VariableHeaderBytes;

        public VariableRecordHeader()
        {
            Reserved = 0;
            UserID = new char[16];
            RecordID = 0;
            RecordLengthAfterHeader = 54;
            Description = new char[32];

            VariableHeaderBytes = new List<byte>();
        }

        public List<byte>GetVariableHeaderBytes()
        {
            List<byte> variableHeaderBytes = new List<byte>();
            variableHeaderBytes.AddRange(BitConverter.GetBytes(Reserved));
            variableHeaderBytes.AddRange(Encoding.UTF8.GetBytes(UserID));
            variableHeaderBytes.AddRange(BitConverter.GetBytes(RecordID));
            variableHeaderBytes.AddRange(BitConverter.GetBytes(RecordLengthAfterHeader));
            variableHeaderBytes.AddRange(Encoding.UTF8.GetBytes(Description));
            return variableHeaderBytes;
        }
    }
    public class PointRecord
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Z;
        public ushort Intensity;
        public byte BitRecord;
        public char[] Classification;
        public char[] ScanAngleRank;
        public char[] UserData;
        public ushort PointSourceID;

        public List<byte> PointRecordBytes;

        

       public PointRecord()
        {
            X = 0;
            Y = 0;
            Z = 0;
            Intensity = 0;
            BitRecord = 0x00;
            Classification = new char[]{'\0'};
            ScanAngleRank = new char[]{'\0'};
            UserData = new char[]{'\0'};
            PointSourceID = 0;

            PointRecordBytes = new List<byte>();
        }

       public List<byte> GetPointRecordBytes()
       {
           List<byte> pointRecordBytes = new List<byte>();
           pointRecordBytes.AddRange(BitConverter.GetBytes(X));
           pointRecordBytes.AddRange(BitConverter.GetBytes(Y));
           pointRecordBytes.AddRange(BitConverter.GetBytes(Z));
           pointRecordBytes.AddRange(BitConverter.GetBytes(Intensity));

           pointRecordBytes.Add(BitRecord);

           pointRecordBytes.AddRange(Encoding.UTF8.GetBytes(Classification));
           pointRecordBytes.AddRange(Encoding.UTF8.GetBytes(ScanAngleRank));
           pointRecordBytes.AddRange(Encoding.UTF8.GetBytes(UserData));
           pointRecordBytes.AddRange(BitConverter.GetBytes(PointSourceID));
           return pointRecordBytes;
       }
    }
}
