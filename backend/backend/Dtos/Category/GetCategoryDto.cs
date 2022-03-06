using System;

namespace backend.Dtos.Category
{
    public class GetCategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImgUrl { get; set; }
    }
}
