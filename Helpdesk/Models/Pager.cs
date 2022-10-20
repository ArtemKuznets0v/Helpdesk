namespace Helpdesk.Models
{
    public class Pager<T>
    {
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public IEnumerable <T> Items { get; set; }
    }
}
