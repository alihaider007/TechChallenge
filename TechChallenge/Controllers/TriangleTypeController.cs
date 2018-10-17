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
    public class TriangleTypeController : ControllerBase
    {
        private enum TriangleType
        {
            Equilateral = 1,
            Scalene = 2,
            Isosceles = 3,
            Error = 4
        }

        [HttpGet]
        public string Get(int a, int b, int c)
        {
            var numbers = new int[] { a, b, c };

            var val = numbers.Distinct().Count();

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Error);
            }
            else if (val == 1)
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Equilateral);
            }
            else if (val == 2)
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Isosceles);
            }
            else if (val == 3)
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Scalene);
            }
            else
            {
                return Enum.GetName(typeof(TriangleType), TriangleType.Error);
            }
        }
    }
}
