using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFWebClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient helloServiceClient = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label1.Text = helloServiceClient.GetMessage("Salih");
        }
    }
}