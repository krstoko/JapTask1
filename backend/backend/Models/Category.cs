using System;

namespace backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImgUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
