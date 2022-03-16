using Microsoft.AspNetCore.Mvc;

namespace HomeworkTwo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    { 
    
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
       
        [HttpPost]
        [Route("Login")]
        public IActionResult Login()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpGet]
        [Route("NotVisible")]
   
        //this endpoint will be hidden in swagger
        //SwaggerCustomFilter is used for hidden
        public IActionResult NotVisible()
        {
            return Ok();
        }

    }
}
