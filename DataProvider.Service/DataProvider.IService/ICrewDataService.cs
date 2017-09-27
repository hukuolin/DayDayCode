using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;

namespace DataProvider.IService
{
    public interface ICrewDataService:IBase
    {
        JsonData QueryMenus();
    }
}
