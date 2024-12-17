using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Eleman_kisisel_bilgileri
    {

        [Key]

        public int Eleman_kisisel_bilgileri_Id { get; set; }

        public int yas { get; set; }

        public string cinsiyet { get; set; }

        public string medeni_durumu { get; set; }

        public string performans { get; set; }


        [ForeignKey("elemanlar")]
        public int elemanlarEleman_Id { get; set; }    
          
        public Elemanlar elemanlar { get; set; }

    }
}
