using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metal_Fabrika_Yönetim_Sistemi.Models
{
    public class Eleman_iletisim_bilgileri
    {

        [Key]
        public int Eleman_iletisim_bilgileri_Id { get; set; }


        [Required]
        public int Telefon_No { get; set; }

        public int Ek_Telefon_No { get; set; }

        public string Adres { get; set; }


        [ForeignKey("elemanlar")]
        public int elemanlarEleman_Id { get; set; }    

        public Elemanlar elemanlar {  get; set; }  

    }
}
