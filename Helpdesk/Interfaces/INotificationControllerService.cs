using Helpdesk.Models;

namespace Helpdesk.Interfaces
{
    public interface INotificationControllerService
    {
        IEnumerable<Notification> GetAllNotifications();
        void Create2(Notification obj);
    }
}
