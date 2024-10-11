using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RouteExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        // GET : localhost:xx/api/Review/Review1 -> "Hello"
        [HttpGet(template:"Review1")]
        public string Review1()
        {
            return "Hello";
        }

        // POST : localhost:xx/api/Review/Review2 -> "POST request"
        [HttpPost(template:"Review2")]
        public string Review2()
        {
            return "POST request";
        }

        // GET : localhost:xx/api/Review/Review3 -> "Another GET"
        [HttpGet(template:"Review3")]
        public string Review3()
        {
            return "Another GET";
        }

    }
}
