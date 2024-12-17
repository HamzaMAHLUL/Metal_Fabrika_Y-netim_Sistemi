using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Personel_kisisel_bilgileri
    {

        [Key]
        public int Personel_Kisisel_Bilgileri { get; set; } 

        public int yas {  get; set; }   

        public string cinsiyet { get; set; }    

        public string ogretim_durumu { get; set; }      

        public string medeni_durumu { get; set; }   

        public string performans {  get; set; }


        [ForeignKey("personeller")]
        public int personelPersonel_Id { get; set; }//Yabancı anahtar Personller sınıfından 

        public Personeller personeller { get; set; } //EBEVEYİN
    }
}
