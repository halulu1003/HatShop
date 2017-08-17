using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HATSHOP.Models
{
    public class Genre
    {
        public string Name { get; set; }
    }

    public class Category
    {
        public string Type { get; set; }
        public Genre Genre { get; set; }
    }
}
