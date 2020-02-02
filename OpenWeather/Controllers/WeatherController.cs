using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Business;

namespace OpenWeather.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public ActionResult GetWeatherByCityName()
        {
            return View();
        }
    }
}