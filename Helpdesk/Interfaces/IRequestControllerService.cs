using Helpdesk.Models;

namespace Helpdesk.Interfaces
{
    public interface IRequestService {
        IEnumerable<Request> GetAllReq();
        void Create4(Request obj);
    }
    }

