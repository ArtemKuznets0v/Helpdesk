using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models
{
    public class Employes : IdentityUser
    {
        [Key]
        [Required]
        public int idEmployes { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Required]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Required]
        public string SurName { get; set; }

        [StringLength(40, MinimumLength = 3)]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string? EmailEmp { get; set; }

        [RegularExpression(@"^\+[1-9]{1}[0-9]{3,14}$")]
        [StringLength(13, MinimumLength = 9)]
        public string? Number { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string? workplace { get; set; }

        [RegularExpression(@"^\+[1-9]{1}[0-9]{3,14}$")]
        [StringLength(13, MinimumLength = 9)]
        public string? workNumber { get; set; }

       

    }
}
