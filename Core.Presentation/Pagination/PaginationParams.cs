namespace Core.Presentation.Pagination
{
    public class PaginationParams
    {
        public int Page { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 5;
        public string SortBy { get; set; }
        public string SortDir { get; set; }

        public PaginationParams()
        {
        }

        public PaginationParams(string sortBy, string sortDir)
        {
            SortBy = sortBy;
            SortDir = sortDir;
        }

        public PaginationParams(int page, int itemsPerPage, string sortBy, string sortDir)
        {
            Page = page;
            ItemsPerPage = itemsPerPage;
            SortBy = sortBy;
            SortDir = sortDir;
        }
    }
}