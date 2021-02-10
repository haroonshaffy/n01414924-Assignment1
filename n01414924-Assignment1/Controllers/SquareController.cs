using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01414924_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        ///    This is performed using GET
        ///    This method returns the value of square of a number
        /// </summary>
        /// 
        /// <param name="id"> An integer input who's square you would like to know
        /// <example> http://localhost:56***/api/Square/10 </example>
        /// </param>
        /// 
        /// <returns>
        ///    100
        /// </returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
