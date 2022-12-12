using Microsoft.AspNetCore.Mvc;

namespace ArmstrongNumber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmstrongNumberController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int number) 
        {
            var result = ArmstrongNumber.Calculate(number)
                ? $"The number {number} is an Armstrong Number."
                : $"The number {number} is not an Armstrong Number.";

            return Ok(result);
        }
    }
}
