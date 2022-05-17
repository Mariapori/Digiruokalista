using System.ComponentModel.DataAnnotations;

namespace Digiruokalista_Remastered.Data
{
    public class Kategoria
    {
        [Key]
        public int KategoriaID { get; set; }
        [Required]
        public string? Nimi { get; set; }
        public List<Ruoka> Ruuat { get; set; } = new List<Ruoka>();
    }
}
