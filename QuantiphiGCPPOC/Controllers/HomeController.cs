using System.Web.Http;

namespace QuantiphiGCPPOC.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/hello
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}