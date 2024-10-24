using System.ComponentModel.DataAnnotations;

namespace Taller1_Mauricio_Mora.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Ciudad { get; set; }
        [Range(0, 50)]
        public int Titulos { get; set; }
        [MaxLength(15)]
        public string AceptaExtranjeros { get; set; }
    }
}
