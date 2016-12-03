using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using Cod3API.Models;

namespace Cod3API.Controllers
{
    public class LocationController : ApiController
    {
        [Route("GetPolice/{latitude:float}/{longitude:float}/{metersInRadius:int}")]
        public float GetPolice(float latitude, float longitude, int metersInRadius)
        {
            using (var context = new cod3Entities())
            {
                return context.GetPolice(latitude, longitude, metersInRadius);
            }
            
        }
        [Route("GetPoliceWithPriority/{latitude:float}/{longitude:float}/{metersInRadius}/{priority}")]
        public float GetPolice(float latitude, float longitude, int metersInRadius, string priority)
        {
            using (var context = new cod3Entities())
            {
                return context.GetPolice(latitude, longitude, metersInRadius).Where(x => x.Priority == priority);
            }

        }
        [Route("GetEms/{latitude:float}/{longitude:float}/{metersInRadius:int}")]
        public float GetEms(float latitude, float longitude, int metersInRadius)
        {
            using (var context = new cod3Entities())
            {
                return context.GetEms(latitude, longitude, metersInRadius);
            }
        }
        [Route("GetEmsWithPriority/{latitude:float}/{longitude:float}/{metersInRadius:int}/{priority:int}")]
        public float GetEms(float latitude, float longitude, int metersInRadius, int priority)
        {
            using (var context = new cod3Entities())
            {
                return context.GetEms(latitude, longitude, metersInRadius).Where(x => x.CallPriority == priority);
            }
        }

        
        public PoliceAndEms GetBoth(float latitude, float longitude, int metersInRadius, int? policePriority, int? emsPriority)
        {
            using (var context = new cod3Entities())
            {
                return context.GetBoth(latitude, longitude, metersInRadius);
            }
        }
    }
}
