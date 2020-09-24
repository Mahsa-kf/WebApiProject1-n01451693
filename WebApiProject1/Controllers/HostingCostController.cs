using System;
using System.Web.Http;

namespace Asssingment1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        public string[] Get(int id)
        {
            string[] result;
            int fn = id / 14;
            double subTotal = (fn + 1) * 5.5;
            double hst = subTotal * 0.13;
            hst = Math.Round(hst, 2);
            double total = subTotal + hst;

            string str1 = $"{fn} fortnights at $5.50 / FN = { subTotal.ToString("C")} CAD";
            string str2 = $"HST 13% = { hst.ToString("C") } CAD";
            string str3 = $"Total = { total.ToString("C") } CAD";

            result = new string[] { str1, str2, str3 };

            return result;
        }
    }
}
