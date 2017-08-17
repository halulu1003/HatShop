using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HATSHOP.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Brand> Albums { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public int GenreId { get; set; }
        public int BrandId { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string CategoryArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Brand Brand { get; set; }
    }
}
