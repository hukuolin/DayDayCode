using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    public class JsonData
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
        public int Count { get; set; }
    }
    public enum DBType
    {
        Oracle = 1,
        SqlServer = 2,
        MySql = 3
    }
}
