using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Assign1.Controllers
{
    public class HostingCostController : ApiController
    {
        //GET: HostingCost
        //Path: /api/HostingCost/{id}

        public IEnumerable<string> Get(int id)
        {
            int fortnights = (id / 14)+1;
            double charge = Math.Round(5.50,2);
            double chargeFN = Math.Round(charge * fortnights,2);
            double tax = Math.Round(0.13*chargeFN,2);
            double total = chargeFN + tax;
            return new string[] { fortnights + " fortnights at $" + string.Format("{0:0.00}", charge) + "/FN = $" + string.Format("{0:0.00}", chargeFN) + " CAD", "HST 13% =$" + string.Format("{0:0.00}", tax) + " CAD", "Total =$" + string.Format("{0:0.00}", total) + " CAD" };
        }
    }
}
