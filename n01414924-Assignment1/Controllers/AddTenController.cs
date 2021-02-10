using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01414924_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///    Part 1 -
        ///    This is performed using GET
        ///    This method returns the value of the input plus 10
        /// </summary>
        /// 
        /// <param name="id"> An integer input to which 10 needs to be added
        /// <example> http://localhost:56***/api/AddTen/10 </example>
        /// </param>
        /// 
        /// <returns>
        ///    20
        /// </returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
