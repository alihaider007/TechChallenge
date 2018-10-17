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
    public class ReverseWordsController : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] string sentence)
        {
            var newStr = sentence.Split(' ');
            List<string> arrStr = new List<string>();

            foreach (var s in newStr)
            {
                var rev = s.Reverse().ToArray();
                arrStr.Add(string.Join("", rev));
            }

            var reverseStr = string.Join(" ", arrStr);

            return reverseStr;
        }
    }
}
