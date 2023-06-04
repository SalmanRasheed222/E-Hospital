using Microsoft.AspNetCore.Mvc;

namespace E_Hospital.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult doctor()
        {
            return View();
        }
    }
}
