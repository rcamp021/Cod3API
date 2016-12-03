using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using Cod3API.Logic;

namespace Cod3API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            var jsonFormatter = new JsonMediaTypeFormatter();
            //optional: set serializer settings here
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
        }
    }
}
