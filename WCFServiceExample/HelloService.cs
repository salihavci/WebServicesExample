using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceExample
{
    // NOT: "HelloService" sınıf adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return $"Hello, {name}";
        }
    }
}
