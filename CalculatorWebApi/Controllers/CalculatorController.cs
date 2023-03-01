using Microsoft.AspNetCore.Mvc;
using CalculatorWebApi.Models;

namespace CalculatorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
       
        CalculatorLibrary.Calculator cal = new CalculatorLibrary.Calculator();
        Calc obj = new Calc();
        [Route("Add")]
        [HttpGet]
        public double Add(double number1, double number2)
        {
            return obj.result = cal.Addition(number1, number2);
        }
        [Route("Sub")]
        [HttpGet]
        public double Sub(double number1, double number2)
        {
            return obj.result = cal.Substraction(number1, number2);
        }
        [Route("Mul")]
        [HttpGet]
        public double Mul(double number1, double number2)
        {
            return obj.result = cal.Multiplication(number1, number2);
        }
        [Route("Div")]
        [HttpGet]
        public double Div(double number1, double number2)
        {
            
                return obj.result = cal.Division(number1, number2);
        }
    }

}
