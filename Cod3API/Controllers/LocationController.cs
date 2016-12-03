using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using Cod3API.Models;

namespace Cod3API.Controllers
{
    public class LocationController : ApiController
    {
        public string Get(float latitude, float longitude)
        {

            using (var context = new cod3Entities())
            {
                //var result = (from c in context.)
            }
            return "Hello World";
        }
    }
}
