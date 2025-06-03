using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets.Models
{
    public class tickets
    {
        [Key]
        public int id_ticket { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public string? nombre_app { get; set; }
        public DateTime fecha_creacion { get; set; }

        [ForeignKey("id_usuarioC")]
        public virtual usuarios usuarioCliente { get; set; }

        [ForeignKey("id_usuarioE")]
        public virtual usuarios usuarioEmpleado { get; set; }

        [ForeignKey("id_cat")]
        public virtual categoria categorias { get; set; }

        [ForeignKey("id_estado")]
        public virtual estado estados { get; set; }

        [ForeignKey("id_prioridad")]
        public virtual prioridad prioridades { get; set; }
    }
}
