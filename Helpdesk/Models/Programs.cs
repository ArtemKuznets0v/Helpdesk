using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models
{
    public class Programs : IdentityUser
    {
        [Key]
        [Required]
        public int idProgram { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Required]
        public string NameProgram { get; set; }

        [Required]
        public string IsArchive { get; set; }
    }
}
