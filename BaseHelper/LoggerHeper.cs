﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BaseHelper
{
    public class LoggerHeper
    {
        public void WriteLog(string text,string path,string fileName,bool appendTimeSpan) 
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string file = path + "/" + fileName;
                FileStream fs;
                if (File.Exists(file))
                {
                    fs = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                }
                else
                {
                    fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                }
                if (appendTimeSpan) 
                {
                    text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff") + "\r\n" + text;
                }
                byte[] bts = Encoding.UTF8.GetBytes(text);
                fs.Write(bts, 0, bts.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}
