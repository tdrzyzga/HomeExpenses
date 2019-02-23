using System;

namespace Core.Presentation.Pagination
{
    public enum SortDirection
    {
        None,
        Asc,
        Desc
    }

    public static class SortDirectionExtensions
    {
        public static SortDirection ToSortDirection(this string sortDir)
        {
            Enum.TryParse<SortDirection>(sortDir, true, out var result);

            return result;
        }
    }
}