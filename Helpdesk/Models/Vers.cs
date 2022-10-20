using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models
{
    public class Vers : IdentityUser
    {
        [Key]
        [Required]
        public int programId { get; set; }

        [Required]
        public string name { get; set; }

        public string IsArchive { get; set; }

        public int IsDeperecated { get; set; }
    }
}
