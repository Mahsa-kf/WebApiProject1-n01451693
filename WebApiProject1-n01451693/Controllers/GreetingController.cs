using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting/{id}
        public string Get (int id)
        {
            return "Greetings to " + id + " people!";
        }

        // Post api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

    }
}
