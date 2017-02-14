using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\项目\\Shift.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            Random ranMileage = new Random();
            int shift;
            for(int n=0;n<10000;n++)
            {
                shift=ranMileage.Next(1,20);
                sw.WriteLine(shift.ToString());
            }
            sw.Close();
            fs.Close();
        }
    }
}
