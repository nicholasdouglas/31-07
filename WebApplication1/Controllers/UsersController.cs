using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var user = new Users
            {
                IdUser = 1,
                NomeUser = "Jorge",
                Email = "jorgematador@yahoo.com.br.org.pr.sesi",
                IdadeAno = 14
            };

            return View(user);
            

        }


    }
}
