using Metal_Fabrika_Yönetim_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Metal_Fabrika_Yönetim_Sistemi.Controllers
{
    public class PersonellerController : Controller
    {
        public IActionResult personelAnaSayfa()
        {
            return View();
        }

        public IActionResult personel_iletisim_bilgileri()
        {
            return View();
        }

        public IActionResult Personel_kisisel_bilgileri()
        {
            return View();  
        }
    }
}
