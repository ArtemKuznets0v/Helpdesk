using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;


namespace Helpdesk.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly CreateRepozitory _createRepozitory;
        
        private readonly ApplicationDbContext _db;

        public CompanyService(ApplicationDbContext db,CreateRepozitory createRepozitory)
        {
            _createRepozitory  = createRepozitory;
            _db = db;
        }

        public IEnumerable<Companys> GetAllCompany() => _db.Comp.ToList();
       
    public Pager<Companys> SearchPaged(string? searchString,int pageSize,int currentPage)
        {
            var firma = _db.Comp.AsQueryable();


            if (!String.IsNullOrEmpty(searchString))
            {
                firma = firma.Where(s => s.NameCompany!.Contains(searchString));
            }
          
            int recsCount = firma.Count();

            int recSkip = (currentPage - 1) * pageSize;

            var data = firma.Skip(recSkip).Take(pageSize).ToList();

            return new Pager<Companys> { CurrentPage = currentPage, PageCount = (int)Math.Ceiling(recsCount / (double)pageSize), Items = data, PageSize = pageSize, TotalCount = recsCount };
        }
        public void Delete(int id)
        {
            _createRepozitory.Delete(id);
        }
        
        public bool Create (Companys obj)
        {
           // ValidationProblemDetails--here.
           var reseult = _createRepozitory.Create(obj);
            return reseult == 1 ? true : false;
        }
        public void Update(Companys obj)
        {
            _createRepozitory.Update(obj);
        }
        public List<Companys> GetAll()
        {
            return _createRepozitory.GetAll();
        }
    }
}
