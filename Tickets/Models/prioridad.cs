using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class prioridad
    {
        [Key]
        public int id_prioridad { get; set; }
        public string? nombre { get; set; }
    }
}
