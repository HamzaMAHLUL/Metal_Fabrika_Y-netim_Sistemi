using System.ComponentModel.DataAnnotations;//Bu kutuphaneyi Key için ekeledim

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Bolumler
    {
        [Key] //Birincil anahtar olduğunu belirtir.
        public int Bolum_ID { get; set; }

        [Required]  //Bolum_ADI özelliğinin zorunlu olduğunu belirtir.Yani, bu alan boş (null) geçilemez.
       
        public string Bolum_ADI { get; set; }

        public Personeller personeller { get; set; } //Bolumler sınıfının çocuğu olarak düşünebiliriz.

       public List<Elemanlar> elemanlar {  get; set; } // Bolum_Id yabancı anahtar olarak yoladım Elemanlar sınıfına sonra Elemeanlar sınıfından bir liste oluşturdum IColllection metoduyla bire çok ilişki gerçekleştirdim. 

     

    }
}
