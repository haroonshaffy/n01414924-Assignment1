using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01414924_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        ///    Part 1 -
        ///    This is performed using POST
        ///    The system responds with "Hello World!" or receiving a POST request
        /// </summary>
        /// 
        /// <param name=None> No values are being passed as an input
        /// <example> curl -d "" "http://localhost:56***/api/Greeting" in the TERMINAL/COMMAND PROMPT </example>
        /// </param>
        /// 
        /// <returns>
        ///    "Hello World!"
        /// </returns>
        /// 
        /// /// <summary>
        ///    Part 2 -
        ///    This is performed using GET
        ///    The system responds with a greeting message to the number of members (Inputted by the customer) 
        /// </summary>
        /// 
        /// <param name="id"> Integer value is passed representing the number of members
        /// <example> http://localhost:56***/api/Greeting/6 </example>
        /// </param>
        /// 
        /// <returns>
        ///    Greetings to 6 people!
        /// </returns>
        public string Post()
        {
            return "Hello World!";
        }

        // GET api/Greeting/id
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
