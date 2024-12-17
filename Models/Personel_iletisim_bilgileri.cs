using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Personel_iletisim_bilgileri
    {
        [Key]
        public int Personel_iletisim_bilgileri_Id { get; set; }

        [Required]  
        public int Telefon_No { get; set; }
        
        public int Ek_Telefon_No { get; set; }  

        public string Adres {  get; set; }

        [ForeignKey("personeller")]

        public int  personelPersonel_Id { get; set; }//Yabancı anahtar Personller sınıfından 


        public Personeller personeller { get; set; }    







    }
}
