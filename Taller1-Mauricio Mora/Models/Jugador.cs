using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller1_Mauricio_Mora.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Posicion { get; set; }
        [Range(0, 150)]
        public int Edad { get; set; }

        public string Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
