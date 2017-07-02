using System.ServiceProcess;
using System.ServiceModel;
using WCF_DuplexSvc;

namespace WindowsServiceHostDll
{
    public partial class WcfService : ServiceBase
    {
        internal static ServiceHost serviceHost;
        public WcfService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe WindowsServiceHostDll.exe
            serviceHost?.Close();
            serviceHost = new ServiceHost(typeof(DuplexSvc));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
