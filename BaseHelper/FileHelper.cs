using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BaseHelper
{
    public class FileHelper
    {
        public static byte[] ReadFileStream(string fileFullName) 
        {
            FileStream fs = new FileStream(fileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            MemoryStream ms = new MemoryStream();
            byte[] bts = new byte[1024];
            int seek = fs.Read(bts, 0, bts.Length);
            while (seek > 0)
            {
                ms.Write(bts, 0, bts.Length);
                seek = fs.Read(bts, 0, bts.Length);
            }
            byte[] fileStream = ms.ToArray();
            ms.Close();
            fs.Close();
            return bts;
        }
        public static FileInfo GetFileName(string fileFullName)
        {
            FileInfo fi = new FileInfo(fileFullName);
            return fi;
        }
    }
}
