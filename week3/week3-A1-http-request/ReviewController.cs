using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace week3_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ReviewController : ControllerBase
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    /// <example>
    /// GET: localhost:xx/api/Review -> 'Hello'
    /// </example>
    [HttpGet]
    public string Review1()
    {
      return "Hello";
    }

    // POST: localhost:xx/api/Review -> 'POST request'
    [HttpPost(template:"Review2")]

    public string Review2()
    {
      return "POST request";
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="Password">This password to identify</param>
    /// <returns>A sentence acknowleging passowrd</returns>
    // POST: localhost:xx/api/Review -> 'POST request'
    [HttpPost(template:"Password")]
    [Consumes("application/x-www-form-urlencoded")]

    public string Password([FromForm]string Password)
    {
      return "The password is "+Password;
    }
  }
}