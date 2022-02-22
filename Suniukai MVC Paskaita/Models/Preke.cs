using System.ComponentModel.DataAnnotations;

namespace GeliuEshop_projektas.Models
{
    public class Preke
    {
        [Key]
        public int Id { get; set; }
        public string? Vardas { get; set; }
        public string? Nuotrauka { get; set; }
        public string? Aprasymas { get; set; }
        public double Kaina { get; set; } = 0;
    }
}
