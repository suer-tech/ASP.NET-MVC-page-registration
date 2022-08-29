using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class User
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Secondname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Key]
        public int ID { get; set; }
    }
}
