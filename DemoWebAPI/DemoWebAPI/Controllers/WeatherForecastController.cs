using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        #region ¸ê®ÆÃ´µ²(Model Binding)
        [HttpPost, Route("insert /{id}")] //WeatherForecast/insert/
        public string Create(int id) 
        {
            return $"Create a {id}";
        }

        [HttpPost, Route("[action]")]
        public string GetAll() 
        {
            return "Get All";
        }

        //[HttpGet, Route("/QueryOrderProduct/{oid}/product")] //"/QueryOrderProduct/1/product?pid=22"
        //public string GetOrderProduct(int oid,[FromQuery]int pid) 
        //{
        //    if (pid == default) 
        //    {
        //    return $"OrderID:{oid}";            
        //    }
        //    return $"OrderID:{oid}, ProductId:{pid}";
        //}

        [HttpGet, Route("/QueryOrderProduct/{oid}/product")] //"/QueryOrderProduct/1/product?pid=22"
        public string GetOrderProduct([FromQuery] Order request)
        {
            if (request == null)
            {
                return "parameter are null";
            }
            if (request.ProductId == default)
            {
                return $"OrderID:{request.Id}, Name:{request.Name}, Price:{request.Price}";
            }
            return $"OrderID:{request.Id}, Name:{request.Name}, Price:{request.Price}, ProductId:{request.ProductId}";
        }

        [HttpPost, Route("/CreateOrder")] //"/CreateOrder"
        public string CreateOrder([FromBody] Order request)
        {
            if (request == null)
            {
                return "parameter are null";
            }
            
            return $"Create Success.OrderID:{request.Id}";
        }

        [HttpPut, Route("/UpdateOrder")] //"/UpdateOrder"
        public string UpdateOrder([FromBody] Order request)
        {
            if (request == null)
            {
                return "parameter are null";
            }

            return $"Update Success.OrderID:{request.Id}";
        }
        #endregion
    }
}