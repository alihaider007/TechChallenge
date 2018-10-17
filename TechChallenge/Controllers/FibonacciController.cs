using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int n)
        {
            if(n > 92 || n < -92)
            {
                return StatusCode(400);
            }
            var arr = new long[n + 1];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            var nNumber = arr[n];

            return Content(nNumber.ToString());
        }
    }
}
