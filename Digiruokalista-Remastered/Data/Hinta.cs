using System.ComponentModel.DataAnnotations;

namespace Digiruokalista_Remastered.Data
{
    public class Hinta
    {
        [Key]
        public int HintaID { get; set; }
        [Required]
        public string? Kuvaus { get; set; }
        [Required]
        public decimal Summa { get; set; }
    }
}
