using Helpdesk.Models;

namespace Helpdesk.Interfaces
{
    public interface IProgramVersionControllerService
    {
       IEnumerable<Vers> GetAllVers();
       void Create3(Vers obj);


    }
}
