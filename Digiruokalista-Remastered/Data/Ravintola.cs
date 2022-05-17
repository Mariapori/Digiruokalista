using System.ComponentModel.DataAnnotations;

namespace Digiruokalista_Remastered.Data
{
    public class Ravintola
    {
        [Key]
        public int RavintolaID { get; set; }
        [Required]
        public string? Nimi { get; set; }
        [Required]
        public string? yTunnus { get; set; }
        public string? Puhelinnumero { get;set; }
        public List<Kategoria> Kategoriat { get; set; } = new List<Kategoria>();
    }
}
