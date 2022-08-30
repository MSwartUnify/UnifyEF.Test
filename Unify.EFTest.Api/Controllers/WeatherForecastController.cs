using Microsoft.AspNetCore.Mvc;
using Unify.EFTest.Service.Departments;

namespace Unify.EFTest.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    private readonly IDepartmentService _DepartmentService;
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IDepartmentService departmentService)
    {
        _logger = logger;
        _DepartmentService = departmentService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var x1 = _DepartmentService.GetDepartmentsWithUsers();
        
        var x2 = _DepartmentService.GetDepartments();
        
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}