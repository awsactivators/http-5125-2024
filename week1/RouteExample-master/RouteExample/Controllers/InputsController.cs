using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RouteExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InputsController : ControllerBase
    {

        /// <summary>
        /// This method receives a number and outputs the lucky version of that number
        /// </summary>
        /// <param name="UserInput">The number to make lucky</param>
        /// <returns>The lucky number (UserInput * 3)</returns>
        /// <example>
        /// GET : https://localhost:xx/api/Inputs/Lucky/90 -> 270
        /// GET : https://localhost:xx/api/Inputs/Lucky/30 -> 90
        /// </example>
        [HttpGet(template:"Lucky/{UserInput}")]
        public int Lucky(int UserInput)
        {
            int LuckyNumber = UserInput * 3;
            return LuckyNumber;
        }

        /// <summary>
        /// Receives a user input and subtracts 13 from it to make it unlucky
        /// </summary>
        /// <returns>An unlucky version of the input number (-13)</returns>
        /// <example>
        /// GET api/Inputs/Unlucky?UserInput=80 -> 67
        /// GET api/Inputs/Unlucky?UserInput=0 -> -13
        /// </example>
        [HttpGet(template:"Unlucky")]
        public int Unlucky(int UserInput)
        {
            int UnluckyNumber = UserInput - 13;
            return UnluckyNumber;
        }

        /// <summary>
        /// Receives two values (base) and (exponent) and returns base^exponent
        /// </summary>
        /// <param name="BaseNumber">The base number to raise to an exponent</param>
        /// <param name="ExponentNumber">The power to raise to</param>
        /// <returns>
        /// the result of base to the power of exponent
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/exponent?BaseNumber=10&ExponentNumber=1 -> 10
        /// GET: localhost:xx/api/exponent?BaseNumber=10&ExponentNumber=2 -> 100
        /// </example>
        [HttpGet(template:"Exponent")]
        public double Exponent(int BaseNumber, int ExponentNumber)
        {
            double result = Math.Pow(BaseNumber,ExponentNumber);
            return result;
        }


        /// <summary>
        /// Receives a POST request with a password
        /// </summary>
        /// <param name="Password">The password to identify</param>
        /// <returns>A sentence acknowledging the password</returns>
        /// <example>
        /// POST: api/Inputs/Password
        //  HEADER: Content-Type: application/x-www-form-urlencoded
        //  BODY: Password=seasme
        // -> the password is seasme

        //curl -H "Content-Type: application/x-www-form-urlencoded" -d "Password=test" "https://localhost:7132/api/inputs/password"
        /// </example>
        [HttpPost(template:"Password")]
        [Consumes("application/x-www-form-urlencoded")]
        public string Password([FromForm]string Password)
        {
            return "the password is "+Password;
        }


    }
}
