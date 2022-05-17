using System.ComponentModel.DataAnnotations;

namespace Digiruokalista_Remastered.Data
{
    public class Ruoka
    {
        [Key]
        public int RuokaID { get; set; }
        public int AnnosNro { get; set; }
        [Required]
        public string? Nimi { get; set; }
        public List<Hinta> Hinnat { get; set; } = new List<Hinta>();
    }
}
