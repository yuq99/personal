using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Connec_BLL
    {
        public static string IsServer()
        {
            if (DBHP_DAL.IsConnected() == true){
                return "与数据连接成功";
            }
            else {
                return "与数据连接失败";
            }
        }

    }
}
