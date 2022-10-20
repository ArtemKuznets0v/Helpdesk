using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models
{
    public class Companys : IdentityUser
    {
        [Key]
        [Required]
        public int idCompany { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Required]
        public string NameCompany { get; set; }

        [StringLength(12, MinimumLength = 10)]
        [RegularExpression(@"^[0-9]+$")]
        [Required]
        public string NIP { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [StringLength(25, MinimumLength = 4)]
        public string? City { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [StringLength(20, MinimumLength = 5)]
        public string? Country { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [StringLength(30, MinimumLength = 4)]
        public string? Street { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        [Range(1, 300, ErrorMessage = "Number of the building must be between 1 and 300 only.")]
        public int? nrOfBuilding { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        [Range(1, 300, ErrorMessage = "Number of the apartments must be between 1 and 300 only.")]
        public int? nrApartments { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        [StringLength(63, MinimumLength = 1)]
        public string? domains { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        [StringLength(30, MinimumLength = 1)]
        public string? regon { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        [StringLength(30, MinimumLength = 1)]
        public string? krs { get; set; }

        [RegularExpression(@"(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})")]
        [StringLength(60, MinimumLength = 3)]
        public string? WebAdres { get; set; }

    }
}
