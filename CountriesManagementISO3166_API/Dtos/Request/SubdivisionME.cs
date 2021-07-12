using System.ComponentModel.DataAnnotations;

namespace CountriesManagementISO3166_API.Dtos
{
    public class SubdivisionME
    {
        [Required]
        public int SubdivisionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SubdivisionCode { get; set; }
    }
}
