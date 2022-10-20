namespace Helpdesk.Models
{
    public class Pageres <T>
    {
        public string SearchString { get; set; }
        public Pager<T> Items { get; set; }
    }
}
