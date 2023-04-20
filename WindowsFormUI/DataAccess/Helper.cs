using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormUI
{
    public static class Helper
    {
      
            public static string CnnStringVal(string name)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
        
    }
}
