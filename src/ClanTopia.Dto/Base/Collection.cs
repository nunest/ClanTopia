namespace ClanTopia.Dto
{
    public abstract class Collection<T> : ResponseBase
    {
        public List<T>? Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}
