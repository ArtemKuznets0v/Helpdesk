using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;

namespace Helpdesk.Services
{
    public class ProgramVersionControllerService : IProgramVersionControllerService
    {
        private readonly CreateRepozitory _createRepozitory;
        private readonly ApplicationDbContext _db;

        public ProgramVersionControllerService(ApplicationDbContext db, CreateRepozitory createRepozitory)
        {
            _createRepozitory = createRepozitory;
            _db = db;
        }
        public IEnumerable<Vers> GetAllVers() => _db.Vers.ToList();

       public void Create3(Vers obj)
        {
            _createRepozitory.Create3(obj);
        }
    }
}
