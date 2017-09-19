using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OrclHandler orcl = new OrclHandler();
            orcl.Query();
        }
    }
}
