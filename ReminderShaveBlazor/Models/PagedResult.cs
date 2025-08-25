namespace ReminderShaveBlazor.Models
{
    public class PagedResult<T> where T : class
    {
        public List<T> Items { get; set; } = new();
        public int TotalCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
