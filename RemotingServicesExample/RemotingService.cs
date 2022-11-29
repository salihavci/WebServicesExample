using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServicesExample
{
    public class RemotingService : MarshalByRefObject, IRemotingService
    {
        public string GetMessage(string name)
        {
            return $"Hello, {name}";
        }
    }
}
