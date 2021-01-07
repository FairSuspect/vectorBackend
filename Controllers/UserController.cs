using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vectorBackend.Models;
using vectorBackend.Entities;
using vectorBackend.Data;

namespace vectorBackend.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationContext _applicationContext;

        public UserController(ILogger<UserController> logger,ApplicationContext applicationContext)
        {
            _logger = logger;
            _applicationContext = applicationContext;
        }

        public string Index(string Name, int ID)
        {
            return "Hello, i'm " + Name + " with " + ID + " id";
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpGet]
        // public string List()
        // {
        //     return "Hi there";
        // }
        public IActionResult List()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            await _applicationContext.Users.AddAsync(user);
            await _applicationContext.SaveChangesAsync();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
