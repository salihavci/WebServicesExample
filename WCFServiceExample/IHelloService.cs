using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceExample
{
    // NOT: "IHelloService" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract(Name = "IHelloService")]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
