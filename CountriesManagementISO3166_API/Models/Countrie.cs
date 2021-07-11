﻿using System.ComponentModel.DataAnnotations;

namespace Countries_Management_ISO3166_API.Models
{
    public class Countrie
    {
        [Key]
        [Required]
        public int CountrieId { get; set; }

        [Required]
        public string CommonName { get; set; }

        [Required]
        public string IsoName { get; set; }

        [Required]
        [MaxLength(2)]
        public string Alpha2Code { get; set; }

        [Required]
        [MaxLength(3)]
        public string Alpha3Code { get; set; }

        [Required]
        [MaxLength(3)]
        [Range(1, int.MaxValue)]
        public int NumericCode { get; set; }

        public int NumberSubdivisions { get; set; }

        public string Observation { get; set; }
    }
}
    