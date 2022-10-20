using Helpdesk.Models;

namespace Helpdesk.Interfaces
{
    public interface IProgramControllerService
    {
        IEnumerable<Programs> GetAllPrograms();

        void Create1(Programs obj);
    }
}
