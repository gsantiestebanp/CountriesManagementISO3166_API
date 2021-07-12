using System.ComponentModel.DataAnnotations;

namespace CountriesManagementISO3166_API.Dtos
{
    public class SubdivisionMS
    {
        public int SubdivisionId { get; set; }
        public string Name { get; set; }
        public string SubdivisionCode { get; set; }
    }
}
