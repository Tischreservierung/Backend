namespace WebApi.QueryParams
{
    public class QueryParams
    {
        const int maxPageSize = 50;

        private int _pageSize;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = Math.Min(value, maxPageSize); }
        }

        public int PageNumber { get; set; } = 1;
    }
}
