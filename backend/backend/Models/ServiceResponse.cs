namespace backend.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
        public bool LoadMore { get; set; } = true;
        public int TotalDataNumber { get; set; }
    }
}
