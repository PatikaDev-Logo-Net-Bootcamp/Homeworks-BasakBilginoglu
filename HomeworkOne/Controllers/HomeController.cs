using HomeworkOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            return View();
        }
         [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {   
                //Validasyon kurallarına uyulmadığı takdirde ResponseView  Success:false olarak gösterilecek
               return Fail();
            }
               // Validasyon kurallarına uyulmuşsa ResponseView  Success:true olarak gösterilecek Error:Null olacak.
            return Success();
        }
        public IActionResult Success()
        {
            return Ok(new ResponseViewModel { Success = true, Error = "Null", Data = "Giriş İşlemi Başarılı" });
        }
        public IActionResult Fail()
        {
            return BadRequest(new ResponseViewModel { Success = false, Error = "Hatalı Giriş", Data = "Null" });
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
