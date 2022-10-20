using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models
{
    public class Request : IdentityUser
    {
        [Key]
        [Required]
        public int idRequest { get; set; }

        [Required]
        public string Name { get; set; }    

        public string Email {get; set; }

        public string Number { get; set; }

        [Required]
        public string Problem { get; set; }
    }
}
