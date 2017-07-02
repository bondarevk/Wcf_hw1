using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceHostDll
{
    static class Program
    {
        static void Main()
        {
            var servicesToRun = new ServiceBase[] 
            { 
                new WcfService() 
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
