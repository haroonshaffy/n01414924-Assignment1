using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01414924_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// What we're trying to do here is to calculate the total cost a customer has to pay 
        /// for web hosting and maintenance
        /// We know that the cost is $5.50 per fortnight and that HST is calculated at 13%
        /// First we need to calculate the number of fortnights based on the number of days entered
        /// To do this, I add 1 to the number of days, then divide by 14 and round the number off
        /// to the nearest ceiling value
        /// Next, I calculate the total cost for hosting and maintenance by multiplying cost per
        /// fortnight with total number of fortnights
        /// Now we need to calculate HST, mathematically that's (total cost * HST%)/100
        /// Round that value to 2 decimal places
        /// Now the total cost to the customer is total cost for hosting and maintenance + HST
        /// </summary>
        /// 
        /// <param name="id"> This is an integer input representing the number of days elapsed
        /// since the beginning of hosting
        /// <example> http://localhost:56***/api/HostingCost/15 </example>
        /// </param>
        /// 
        /// <returns>
        /// 
        /// <string>2 fortnights at $5.50/FN = $11.00 CAD</string>
        /// <string>HST 13% = $1.43 CAD</string>
        /// <string>Total = $12.43 CAD</string>
        /// </ArrayOfstring>
        /// 
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            int days = id;
            decimal perFN = 5.50M;
            decimal HST = 13M;
            decimal numberOfFN = Math.Ceiling(((decimal)days + 1) / 14);
            decimal Cost1 = numberOfFN * perFN;
            decimal HSTCost = Math.Round((Cost1 * HST) / 100, 2);
            decimal TotalCost = Cost1 + HSTCost;
            string one = numberOfFN + " fortnights at $5.50/FN = $" + Cost1 + " CAD";
            string two = "HST 13% = $" + HSTCost + " CAD";
            string three = "Total = $" + TotalCost + " CAD";

            return new string[3] { one, two, three };
        }
    }
}
