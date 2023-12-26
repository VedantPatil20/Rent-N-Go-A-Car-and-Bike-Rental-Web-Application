using Microsoft.AspNetCore.Mvc;

namespace Rent_N_Go_A_Car_and_Bike_Rental_Web_Application.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
