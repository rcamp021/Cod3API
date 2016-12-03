using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using Cod3API.Models;

namespace Cod3API.Controllers
{
    [RoutePrefix("Location")]
    public class LocationController : ApiController
    {
        [Route("GetPolice")]
        public IHttpActionResult GetPolice(float latitude, float longitude, int? metersInRadius)
        {
            using (var context = new cod3Entities())
            {
                return Ok(context.GetPolice(latitude.ToString(CultureInfo.CurrentCulture),
                    longitude.ToString(CultureInfo.CurrentCulture), metersInRadius).FirstOrDefault());
            }
            
        }
        //[Route("GetPoliceWithPriority/{latitude:float}/{longitude:float}/{metersInRadius}/{priority}")]
        //public IHttpActionResult GetPolice(float latitude, float longitude, int metersInRadius, int? priority)
        //{
        //    using (var context = new cod3Entities())
        //    {
        //        return Ok( context.GetPolice(latitude.ToString(CultureInfo.CurrentCulture),
        //            longitude.ToString(CultureInfo.CurrentCulture), metersInRadius, priority).FirstOrDefault());
        //    }

        //}
        [Route("GetEms")]
        public IHttpActionResult GetEms(float latitude, float longitude, int? metersInRadius)
        {
            using (var context = new cod3Entities())
            {
                return Ok(context.GetEms(latitude.ToString(CultureInfo.CurrentCulture),
                    longitude.ToString(CultureInfo.CurrentCulture), metersInRadius).FirstOrDefault());
            }
        }
        //[Route("GetEmsWithPriority/{latitude:float}/{longitude:float}/{metersInRadius:int}/{priority:int}")]
        //public IHttpActionResult GetEms(float latitude, float longitude, int metersInRadius, int priority)
        //{
        //    using (var context = new cod3Entities())
        //    {
        //        return Ok(context.GetEms(latitude.ToString(CultureInfo.CurrentCulture), longitude.ToString(CultureInfo.CurrentCulture),
        //            metersInRadius, priority).FirstOrDefault());
        //    }
        //}


        //public PoliceAndEms GetBoth(float latitude, float longitude, int metersInRadius, int? policePriority, int? emsPriority)
        //{
        //    using (var context = new cod3Entities())
        //    {
        //        return context.GetBoth(latitude, longitude, metersInRadius);
        //    }
        //}
    }
}
