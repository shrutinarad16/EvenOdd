using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EvenOdd
{
    /// <summary>
    /// Summary description for EvenOdd
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EvenOdd : System.Web.Services.WebService
    {

        [WebMethod]
        public string evenodd(int n)
        {
            if (n % 2 == 0)
                return n + " is even";
            else
                return n + " is odd";
        }
    }
}
