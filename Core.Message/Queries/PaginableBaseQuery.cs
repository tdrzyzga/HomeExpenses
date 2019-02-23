using Microsoft.EntityFrameworkCore.Storage;

namespace Core.Message.Queries
{
    public abstract class PaginableBaseQuery : BaseQuery
    {
        public int Page { get; }
        public int ItemsPerPage { get; }
        public string SortBy { get; }
        public string SortDir { get; }
        
        protected PaginableBaseQuery(int page, int itemsPerPage, string sortBy, string sortDir)
        {
            Page = page;
            ItemsPerPage = itemsPerPage;
            SortBy = sortBy;
            SortDir = sortDir;
        }
    }
}