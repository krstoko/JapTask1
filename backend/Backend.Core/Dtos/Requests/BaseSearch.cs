namespace backend.Dtos.Requests
{
    public class BaseSearch
    {
        public int? Skip { get; set; }
        public int? PageSize { get; set; }
        public string? SearchValue { get; set; }
    }
}
