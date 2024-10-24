using System.ComponentModel.DataAnnotations;

namespace Taller1_Mauricio_Mora.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Direccion { get; set; }
        [MaxLength(50)]
        public string Ciudad { get; set; }
        [Range(0, 44000)]
        public int Capacidad { get; set; }
    }
}
