using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.IService
{
    public interface IAsyncDataService<T>
    {
        string SqlConnString { get; }
        int Count(string cmd);
        int ExecuteNoQuery(string cmd);
    }
}
