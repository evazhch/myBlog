using Microsoft.AspNetCore.Mvc;
using MyBlog.BLL.Sys;
using MyBlog.Common.Model;
using MyBlog.Model.Sys;

namespace MyBlog.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly SysUserLogic sysUserLogic;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SysUserLogic sysUserLogic)
        {
            _logger = logger;
            this.sysUserLogic = sysUserLogic;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetUser")]
        public ApiResponse<SysUser> GetUser(string userName)
        {
            return new ApiResponse<SysUser>(sysUserLogic.GetSysUser(userName));
        }
    }
}
