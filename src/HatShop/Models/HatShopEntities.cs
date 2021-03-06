﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HATSHOP.Models
{
    public class HatShopEntities : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Brand> Artists { get; set; }
    }
}
