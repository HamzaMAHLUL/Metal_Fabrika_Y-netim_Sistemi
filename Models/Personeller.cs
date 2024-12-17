using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Personeller
    {
        [Key]
        public int Personel_Id {  get; set; } // Birincil anahtar

        [Required]  
        public string PersonelAd { get; set; } // Personel Adı

        [Required]  
        public string PersonelSoyad { get; set; } // Personel Soyadı


        [ForeignKey("bolumler")]
        public int  bolumlerBolum_Id { get; set; }   
        public Bolumler bolumler { get; set; } //Burada hangi sınıftan yabancı anahtar aldığımızı bilirtilir. Yani Bolumller EBEVEYİN olarak düşünebiliriz. 
       
        public Personel_iletisim_bilgileri personel_İletisim_Bilgileri { get; set; }    

        public Personel_kisisel_bilgileri personel_Kisisel_Bilgileri { get; set; }


        public List<Elemanlar> elemanlar { get; set; } //// Personel_Id yabancı anahtar olarak yoladım Elemanlar sınıfına sonra Elemeanlar sınıfından bir liste oluşturdum IColllection metoduyla bire çok ilişki gerçekleştirdim. 


    }
}
