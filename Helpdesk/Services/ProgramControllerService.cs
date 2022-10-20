using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;

namespace Helpdesk.Services
{
    public class ProgramControllerService : IProgramControllerService
    {
        private readonly CreateRepozitory _createRepozitory;
        private readonly ApplicationDbContext _db;

        public ProgramControllerService(ApplicationDbContext db, CreateRepozitory createRepozitory)
        {
            _createRepozitory = createRepozitory;
            _db = db;
        }

        public IEnumerable<Programs> GetAllPrograms() => _db.Prog.ToList();

        public void Create1 (Programs obj)
        {
            _createRepozitory.Create1(obj);
        }
    }
}
