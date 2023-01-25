using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class TimesFiftyController : ApiController
    {
        //POST: api/TimesFifty/5 -> 250
        public int POST(int id)
        {
            return id * 50;
        }
    }
}
