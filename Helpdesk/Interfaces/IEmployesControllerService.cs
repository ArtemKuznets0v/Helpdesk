using Helpdesk.Models;

namespace Helpdesk.Interfaces
{
    public interface IEmployesService
    {
        IEnumerable<Employes> GetAllEmployes();

        Pager<Employes> SearchPaged(string? searchString, int pageSize, int currentPage);
    }
}
