using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ass1.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ApiController : ControllerBase
{
    [HttpGet]

    // [HttpGet]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }
}