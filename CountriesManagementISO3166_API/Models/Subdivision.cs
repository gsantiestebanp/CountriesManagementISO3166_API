using System.ComponentModel.DataAnnotations;

namespace Countries_Management_ISO3166_API.Models
{
    public class Subdivision
    {
        [Key]
        [Required]
        public int SubdivisionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SubdivisionCode { get; set; }
    }
}
