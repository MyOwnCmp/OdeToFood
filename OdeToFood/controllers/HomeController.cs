using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.controllers
{
    public class HomeController:Controller
    {
        private IResturantData _restuarntData;

        public HomeController(IResturantData restaurantData)
        {
            _restuarntData = restaurantData;
        }
        public IActionResult Index()
        {
            var model = _restuarntData.GetAll();
            return View(model);
        }
    }
}
