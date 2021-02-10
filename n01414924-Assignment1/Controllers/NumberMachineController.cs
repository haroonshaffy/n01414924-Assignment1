using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01414924_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        ///     Here, we're taking an input from the customer and performing 4 mathematical functions in it
        ///     The mathematical functions being performed are as follows -
        ///     1) Square of the input
        ///     2) Divide by 2
        ///     3) Add 10
        ///     4) Subtract 3
        /// </summary>
        /// 
        /// <param name="id"> This is an integer input on which the mathematical operations will be performed
        /// <example> http://localhost:56***/api/NumberMachine/30 </example>
        /// </param>
        /// 
        /// <returns>
        ///     457
        /// </returns>
        public int Get(int id)
        {
            //int a = id * id;
            //int b = a / 2;
            //int c = b + 10;
            //int d = c - 3;

            return (id * id) / 2 + 10 -3;
        }
    }
}
