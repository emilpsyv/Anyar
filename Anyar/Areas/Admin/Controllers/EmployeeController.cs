using Anyar.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anyar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController(AnyarContext _context) : Controller
    {
       
        public async Task< ActionResult> Index()
        {

            return View();
        }      
    }
}
