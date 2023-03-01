using Microsoft.AspNetCore.Mvc;
using CalculatorWebApi.Models;

namespace CalculatorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
       
        CalculatorLibrary.Calculator cal = new CalculatorLibrary.Calculator();
        Input obj = new Input();
        [Route("Add")]
        [HttpGet]
        public double Add(double number1, double number2)
        {
            return obj.result = cal.Addition(number1, number2);
        }
        [Route("Substract")]
        [HttpGet]
        public double Sub(double number1, double number2)
        {
            return obj.result = cal.Substraction(number1, number2);
        }
        [Route("Muliply")]
        [HttpGet]
        public double Mul(double number1, double number2)
        {
            return obj.result = cal.Multiplication(number1, number2);
        }
        [Route("Divide")]
        [HttpGet]
        public double Div(double number1, double number2)
        {
            
                return obj.result = cal.Division(number1, number2);
        }
    }

}
