using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Helpdesk.Models
{
    public class Notification : IdentityUser
    {
        [Key]
        [Required]
        public int idNotification { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
        public string DateOfRegistration { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string Deadline { get; set; }

        [Required]
        public string Status { get; set; }


        [Required]
        public int idEmployes { get; set; }

        [Required]
        public int idCompany { get; set; }

        [Required]
        public int idProgram { get; set; }

        [Required]
        public int programId { get; set; }

        [ForeignKey("idEmployes")]
        public virtual Employes Employes { get; set; }

        [ForeignKey("idCompany")]
        public virtual Companys Companys { get; set; }

        [ForeignKey("idProgram")]
        public virtual Programs Programs { get; set; }

        [ForeignKey("programId")]
        public virtual Vers Vers { get; set; }
    }

}
