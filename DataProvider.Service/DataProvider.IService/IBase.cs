using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.IService
{
    public interface IBase
    {
        string DbConnString { get; set; }
        bool? Result { get; set; }
        string ExceptionMsg { get; set; }
    }
}
