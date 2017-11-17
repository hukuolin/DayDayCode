using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BaseHelper;
namespace JustExample
{
    public class StudeyWebService
    {
        ExampleWebService.AppDataAPISoapClient api = new ExampleWebService.AppDataAPISoapClient();
        CallFSOP.FSOPServerSoapClient fsop = new  CallFSOP.FSOPServerSoapClient();
        public void UploadFile(string fileFullName) 
        {
            byte[] fileStream = FileHelper.ReadFileStream(fileFullName);
            api.UploadFile(fileStream);
        }
        public void UploadFileToFSOP(string fileFullName, string funName,string tocken)
        {
            FileInfo fi = FileHelper.GetFileName(fileFullName);
            byte[] fileStream = FileHelper.ReadFileStream(fileFullName);
            fsop.UploadFileWithCallWcf(fileStream, funName, fi.Name, "test" + fi.Extension, tocken);
        }
    }
}
