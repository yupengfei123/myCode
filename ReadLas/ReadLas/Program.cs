using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadLas
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\3.las", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            for (int n = 0; n < 281;n++ )
            {
                br.ReadByte();
            }
            Int32 X = br.ReadInt32();
            Int32 Y = br.ReadInt32();
            Int32 Z = br.ReadInt32();
            ushort intensity = br.ReadUInt16();
            Console.ReadLine();
        }
        public static string ByteToHexStr(byte[] bytes)
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
    }
}
