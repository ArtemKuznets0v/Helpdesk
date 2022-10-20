using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;

namespace Helpdesk.Services
{
    public class NotificationControllerService : INotificationControllerService
    {

        private readonly CreateRepozitory _createRepozitory;
        private readonly ApplicationDbContext _db;

        public NotificationControllerService(ApplicationDbContext db, CreateRepozitory createRepozitory)
        {
            _createRepozitory = createRepozitory;
            _db = db;
        }

        public IEnumerable<Notification> GetAllNotifications() => _db.Notific.ToList();

        public void Create2(Notification obj)
        {
            _createRepozitory.Create2(obj);
        }
    }
}
