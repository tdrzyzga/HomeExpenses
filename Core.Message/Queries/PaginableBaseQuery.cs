using Microsoft.EntityFrameworkCore.Storage;

namespace Core.Message.Queries
{
    public abstract class PaginableBaseQuery : BaseQuery
    {
        public int PageIndex { get; }
        public int ItemsPerPage { get; }
        public string SortBy { get; }
        public string SortDir { get; }
        
        protected PaginableBaseQuery(int pageIndex, int itemsPerPage, string sortBy, string sortDir)
        {
            PageIndex = pageIndex;
            ItemsPerPage = itemsPerPage;
            SortBy = sortBy;
            SortDir = sortDir;
        }
    }
}