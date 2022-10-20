using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;

namespace Helpdesk.Services
{
    public class EmployesService : IEmployesService
    {

        private readonly ApplicationDbContext _db;
        
        public EmployesService(ApplicationDbContext db)
        {
            
            _db = db;
        }
        public IEnumerable<Employes> GetAllEmployes() => _db.Empl.ToList();

        public Pager<Employes> SearchPaged(string? searchString, int pageSize, int currentPage)
        {
            var employes = _db.Empl.AsQueryable();


            if (!String.IsNullOrEmpty(searchString))
            {
                employes = employes.Where(s => s.Name!.Contains(searchString));
            }

            int recsCount = employes.Count();

            int recSkip = (currentPage - 1) * pageSize;

            var data = employes.Skip(recSkip).Take(pageSize).ToList();

            return new Pager<Employes> { CurrentPage = currentPage, PageCount = (int)Math.Ceiling(recsCount / (double)pageSize), Items = data, PageSize = pageSize, TotalCount = recsCount };
        }
    }
}

