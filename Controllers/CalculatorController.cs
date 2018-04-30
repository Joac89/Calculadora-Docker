using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
     [Route("api/v1/[controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet("add/{*nums}")]
        public IActionResult Addition([Bind] string nums)
        {
            var serv = new CalculatorService();
            var result = serv.Addition(nums);

            return Ok(result);
        }

        [HttpGet("subs/{*nums}")]
        public IActionResult Substraction([Bind] string nums)
        {
            var serv = new CalculatorService();
            var result = serv.Substraction(nums);

            return Ok(result);
        }

        [HttpGet("mult/{*nums}")]
        public IActionResult Multiplication([Bind] string nums)
        {
            var serv = new CalculatorService();
            var result = serv.Multiplication(nums);

            return Ok(result);
        }

        [HttpGet("div/{*nums}")]
        public IActionResult Division([Bind] string nums)
        {
            var serv = new CalculatorService();
            var result = serv.Division(nums);

            return Ok(result);
        }
    }
}
