using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AsmxWebServicesExample
{
    /// <summary>
    /// CalculatorWebService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true,Description = "Bu metot 2 sayıyı toplayıp session'a kaydeder",CacheDuration = 15,MessageName = "DoubleSum")]
        public int Add(int num1, int num2)
        {
            List<string> calculations;
            if (Session["calculation"] == null)
            {
                calculations= new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["calculation"];
            }
            var total = num1 + num2;
            string strRecentCalculations = num1.ToString() + " + " + num2.ToString() + " = " + total.ToString();
            calculations.Add(strRecentCalculations);
            Session["calculation"] = calculations;
            return total;
        }
        
        [WebMethod(EnableSession = true,Description = "Bu metot 3 sayıyı toplayıp session'a kaydeder",CacheDuration = 15,MessageName = "TripleSum")]
        public int Add(int num1, int num2,int num3)
        {
            List<string> calculations;
            if (Session["calculation"] == null)
            {
                calculations= new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["calculation"];
            }
            var total = num1 + num2 + num3;
            string strRecentCalculations = num1.ToString() + " + " + num2.ToString() + " + " + num3.ToString() + " = " + total.ToString();
            calculations.Add(strRecentCalculations);
            Session["calculation"] = calculations;
            return total;
        }

        [WebMethod(EnableSession = true, Description = "Bu metot kaydedilen işlemleri liste olarak getirir.")]
        public List<string> GetCalculations()
        {
            if (Session["calculation"] == null)
            {
                List<string> calculations = new List<string>
                {
                    "Herhangi bir hesaplama yapılmadı."
                };
                 return calculations;
            }
            else
            {
                return (List<string>)Session["calculation"];
            }
        }
    }
}
