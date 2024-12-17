using Metal_Fabrika_Yönetim_Sistemi.Data;
using Metal_Fabrika_Yönetim_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Metal_Fabrika_Yönetim_Sistemi.Controllers
{
    public class BolumlerController : Controller
    {

        private AppDbContext _db;

        public BolumlerController(AppDbContext M_F_Y_S)
        {
            _db = M_F_Y_S;
        }
        public IActionResult Index()
        {
            // Bolumler tablosundaki tüm verileri liste olarak alır
            IEnumerable<Bolumler> Bolumler_List = _db.Bolumler.ToList();


            return View(Bolumler_List); // "Index" view'ini çağırır
            //veritabanı'dan aldığım liste parametre olarak Bolumler sayfasına gönder 
        }
    }

}
