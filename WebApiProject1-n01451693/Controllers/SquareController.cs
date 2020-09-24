using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject1.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/square/{id}
        public int Get(int id)
        {
            return id * id ;
        }

    }
}
