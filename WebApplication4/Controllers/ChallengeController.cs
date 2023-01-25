using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class ChallengeController : ApiController
    {
        /// <summary>
        /// Calculates the volume of a prism given length, width, and height
        /// </summary>
        /// <param name="x">The width of the prism in cm</param> 
        /// <param name="y">The length of the prism in cm</param>
        /// <param name="z">The height of the prism in cm</param>
        /// <returns>
        /// The total volume is {result}cm^3
        /// </returns>
        //get: api/Challenge/x/y/z  -> "The total volume is {result}cm^3"
        [HttpGet]
        [Route("api/Challenge/Calculate/{x}/{y}/{x}")]
        public string Calculate(int x, int y, int z)
        {
            int volume = x * y * z;
            return "The total of volume of the prism is " + volume + "cm^3";
        }
    }
}
