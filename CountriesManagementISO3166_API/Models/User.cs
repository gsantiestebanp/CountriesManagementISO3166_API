using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CountriesManagementISO3166_API.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [JsonIgnore]
        [Required]
        public string Password { get; set; }
    }
}
