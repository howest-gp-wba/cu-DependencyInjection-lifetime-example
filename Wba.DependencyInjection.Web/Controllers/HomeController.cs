using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wba.DependencyInjection.Web.Models;
using Wba.DependencyInjection.Web.Services;
using Wba.DependencyInjection.Web.Services.Interfaces;


namespace Wba.DependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICreateUserIdServiceSingleton 
            _createUserIdServiceSingleton1;
        private readonly ICreateUserIdServiceSingleton
            _createUserIdServiceSingleton2;
        private readonly ICreateUserIdServiceTransient
            _createUserIdServiceTransient1;
        private readonly ICreateUserIdServiceTransient
            _createUserIdServiceTransient2;
        private readonly ICreateUserIdServiceScoped 
            _createUserIdServiceScoped1;
        private readonly ICreateUserIdServiceScoped
            _createUserIdServiceScoped2;

        public HomeController(
            ICreateUserIdServiceSingleton createUserIdServiceSingleton1,
            ICreateUserIdServiceTransient createUserIdServiceTransient1,
            ICreateUserIdServiceScoped createUserIdServiceScoped1,
            ICreateUserIdServiceSingleton createUserIdServiceSingleton2,
            ICreateUserIdServiceTransient createUserIdServiceTransient2,
            ICreateUserIdServiceScoped createUserIdServiceScoped2
            )
        {
            _createUserIdServiceSingleton1  = createUserIdServiceSingleton1;
            _createUserIdServiceSingleton2  = createUserIdServiceSingleton2;
            _createUserIdServiceTransient1  = createUserIdServiceTransient1;
            _createUserIdServiceTransient2  = createUserIdServiceTransient2;
            _createUserIdServiceScoped1     = createUserIdServiceScoped1;
            _createUserIdServiceScoped2     = createUserIdServiceScoped2;
        }
        public IActionResult Index()
        {
            ViewBag.UserIdTransient1 = _createUserIdServiceTransient1.GetUserId();
            ViewBag.UserIdTransient2 = _createUserIdServiceTransient2.GetUserId();
            
            ViewBag.UserIdScoped1 = _createUserIdServiceScoped1.GetUserId();
            ViewBag.UserIdScoped2 = _createUserIdServiceScoped2.GetUserId();

            ViewBag.UserIdSingleton1 = _createUserIdServiceSingleton1.GetUserId();
            ViewBag.UserIdSingleton2 = _createUserIdServiceSingleton2.GetUserId();
            return View();
        }

        public IActionResult About()
        {
            ViewBag.UserIdTransient1 = _createUserIdServiceTransient1.GetUserId();
            ViewBag.UserIdTransient2 = _createUserIdServiceTransient2.GetUserId();

            ViewBag.UserIdScoped1 = _createUserIdServiceScoped1.GetUserId();
            ViewBag.UserIdScoped2 = _createUserIdServiceScoped2.GetUserId();

            ViewBag.UserIdSingleton1 = _createUserIdServiceSingleton1.GetUserId();
            ViewBag.UserIdSingleton2 = _createUserIdServiceSingleton2.GetUserId();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
