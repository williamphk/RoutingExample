using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class TestController : ApiController
    {
        public string GET(string id)
        {
            return "Hello" + " " + id + "!";
        }
    }
}
