using System.ComponentModel.DataAnnotations;

namespace QPadBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        public List<Note>? Notes { get; set; }
    }
}
