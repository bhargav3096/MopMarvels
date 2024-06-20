using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MopMarvels.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product>? Product { get; set; }
        public SelectList? Category { get; set; }
        public string? category { get; set; }
        public string? search { get; set; }
    }
}
