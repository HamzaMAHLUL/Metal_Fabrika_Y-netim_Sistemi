using Microsoft.AspNetCore.Mvc;

namespace Metal_Fabrika_Yönetim_Sistemi.Controllers
{
    public class ElemanlarController : Controller
    {
        public IActionResult Elemanlar()
        {
            return View();
        }

        public IActionResult Eleman_iletisim_bilgileri()
        {
            return View();  
        }

        public IActionResult Eleman_kisisel_bilgileri()
        {
            return View();  
        }

    }
}
