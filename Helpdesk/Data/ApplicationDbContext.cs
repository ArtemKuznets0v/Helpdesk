using Helpdesk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Helpdesk.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employes> Empl { get; set; }
        public DbSet<Companys> Comp { get; set; }
        public DbSet<Programs> Prog { get; set; }
        public DbSet<Notification> Notific { get; set; }
        public DbSet<Vers> Vers { get; set; }

        public DbSet<Request> Req { get; set; }
    }
}