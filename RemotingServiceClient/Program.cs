using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServicesExample;

namespace RemotingServiceClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RemotingService service;
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            service = (RemotingService)Activator.GetObject(typeof(RemotingService), "tcp://localhost:2065/GetMessage");
            Console.WriteLine(service.GetMessage("Salih"));
            Console.ReadKey();
        }
    }
}
