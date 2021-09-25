using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PutLuckTestMVC.Models;
using Dapper;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

namespace PutLuckTestMVC.Controllers
{
    public class PotLuckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RSVPform()
        {
            return View();
        }
        public IActionResult Dish()
        {
            return View();
        }
        [HttpPost]
        public IActionResult thankyouRSVP(TeamMember user)
        {
                DAL.AddRSVP(user);
                return View();
            
        }
        
        [HttpPost]
        public IActionResult thankyoudish(Dish newDish)
        {
            if (newDish.TMName == null || newDish.DishDescription == null || newDish.PhoneNumber == null || newDish.DishName == null || newDish.Category == null || newDish.DishName.Length < 2)
            {
                ViewData["Message"] = "Please fill in all fields fully and correctly";
                return View("Dish");
            }
            else
            {
                DAL.AddDish(newDish);
                return View("dishlist");
            }
        }
        [HttpPost]
        public IActionResult dishlist()
        {
            List<Dish> newDish = DAL.GetAllDishes();
            return View(newDish);
        }
    }
}
