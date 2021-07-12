using System.ComponentModel.DataAnnotations;

namespace CountriesManagementISO3166_API.Models
{
    public class Subdivision
    {
        [Key]
        [Required]
        public int SubdivisionId { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SubdivisionCode { get; set; }
    }
}
