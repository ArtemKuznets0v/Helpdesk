using Helpdesk.Models;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Companys> GetAllCompany();
        Pager<Companys> SearchPaged(string? searchString, int pageSize, int currentPage);

        bool Create(Companys obj);
    }
}
