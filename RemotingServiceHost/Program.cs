using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServicesExample;

namespace RemotingServiceHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RemotingService service = new RemotingService();
            TcpChannel channel = new TcpChannel(2065);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine($"Remoting servis başlatıldı : {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
