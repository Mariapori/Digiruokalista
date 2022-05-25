using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digiruokalista_Remastered.Data
{
    public class Hinta
    {
        [Key]
        public int HintaID { get; set; }
        [Required]
        public string? Kuvaus { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Summa { get; set; }
    }
}
