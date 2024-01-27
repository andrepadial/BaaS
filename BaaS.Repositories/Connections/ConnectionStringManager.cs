using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Repositories.Connections
{
    public class ConnectionStringManager
    {
        public static string EBankConnection { set; get; }

        public static string InfobankConnection { set; get; }
        public static string ContaCorrenteConnection { set; get; }
    }
}
