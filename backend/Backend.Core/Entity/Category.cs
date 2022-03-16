using backend.Entity;
using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Category : EntityBase
    {
        public string ImgUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
