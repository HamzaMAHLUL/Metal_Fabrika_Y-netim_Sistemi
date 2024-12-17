using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Elemanlar
    {

        [Key]

        public int Eleman_Id { get; set; }  

        [Required]  
        public string ElemanAdi { get; set; }
        [Required]  
        public string ElemanSoyadi { get; set; }
        
        public string tecrubesi { get; set; }






         [ForeignKey("bolumler")]
         public int bolumlerBolum_ID { get; set; } // Bolumler sınıfından yabancı anahtar olarak aldım.  
         
        
        
        [ForeignKey("personeller")]
        public int personelPersonel_Id { get; set; } // Personeller sınıfından yabancı anahtar olarak aldım.     
        


       public Personeller personeller {  get; set; } // EBEVEYİN 

        public Bolumler bolumler { get; set; } // EBEVEYİN  


        public Eleman_iletisim_bilgileri eleman_iletisim_bilgileri { get; set; }
        
        public Eleman_kisisel_bilgileri eleman_Kisisel_bilgileri { get; set; }  

    }
}
