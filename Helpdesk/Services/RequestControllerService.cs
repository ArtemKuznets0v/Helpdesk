using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;

namespace Helpdesk.Services
{
    public class RequestService : IRequestService
    {
        private readonly CreateRepozitory _createRepozitory;

        private readonly ApplicationDbContext _db;

        public RequestService(ApplicationDbContext db, CreateRepozitory createRepozitory)
        {
            _createRepozitory = createRepozitory;
            _db = db;
        }

        public IEnumerable<Request> GetAllReq() => _db.Req.ToList();
        public void Create(Request obj)
        {
            // ValidationProblemDetails--here.

            _createRepozitory.Create4(obj);
        }

        public void Create4(Request obj)
        {
            throw new NotImplementedException();
        }
    }
}
