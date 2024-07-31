using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AmogusController : Controller
    {
        public IActionResult Index()
        {
            var amogus = new Amogus()
            {
                Id = 1,
                Nome = "Devolva",
                Valor = 2.4m,
                Descr = "Graças ao diabo mãe",
                DataFabric = new DateTime (2024, 07, 31, 09, 42, 04)
            };

            return View(amogus);
        }
    }
}

