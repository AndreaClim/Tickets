using System.ComponentModel.DataAnnotations;
namespace Tickets.Models
{
    public class roles_t
    {
        [Key]
        public int id_roles { get; set; }
        public string? nombre { get; set; }
    }
}
