﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class DefaultController : ApiController
    {
        //GET api/example
        public string Get()
        {
            return "My first program";
        }
    }
}
