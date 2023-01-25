using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class RouteTestController : ApiController
    {
        //get: api/RouteTest/Greeting2 -> "howdy"
        [HttpGet]
        public string Greeting2() { return "howdy"; }

        //get: api/RouteTest/Greeting3 -> "Heya"
        [HttpGet]
        public string Greeting3() { return "Heya"; }


        //get: api/RouteTest/Greeting4 -> "Hola"
        [HttpGet]
        public string Greeting4() { return "Hola"; }
    }
}
