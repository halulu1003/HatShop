using System;
using System.Collections.Generic;
using System.Linq;
using HATSHOP.Models;

namespace MvcMusicStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<HatShopEntities>
    {
        protected override void Seed(HatShopEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Sport" },
                new Genre { Name = "Pop" },
                new Genre { Name = "Classical" }
            };

            var artists = new List<Brand>
            {
                new Brand { Name = "Aaron Copland" },
                new Brand { Name = "Goldberg" },
                new Brand { Name = "DC" },
                new Brand { Name = "Barry Wordsworth" },
                new Brand { Name = "Doreen de Feis" },
               
            };

            new List<Item>
            {
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Aaron Copland"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Sport"), Price = 18.99M, Brand = artists.Single(a => a.Name == "Aaron Copland"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Sport"), Price = 28.99M, Brand = artists.Single(a => a.Name == "Aaron Copland"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Sport"), Price = 18.99M, Brand = artists.Single(a => a.Name == "Goldberg"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Sport"), Price = 28.99M, Brand = artists.Single(a => a.Name == "Aaron Copland"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Goldberg"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Classical"), Price = 18.99M, Brand = artists.Single(a => a.Name == "Goldberg"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Pop"), Price = 28.99M, Brand = artists.Single(a => a.Name == "Barry Wordsworth"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Pop"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Goldberg"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Barry Wordsworth"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Pop"), Price = 38.99M, Brand = artists.Single(a => a.Name == "Barry Wordsworth"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Pop"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Doreen de Feis"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Pop"), Price = 38.99M, Brand = artists.Single(a => a.Name == "Barry Wordsworth"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "male", Genre = genres.Single(g => g.Name == "Pop"), Price = 38.99M, Brand = artists.Single(a => a.Name == "Barry Wordsworth"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Doreen de Feis"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Classical"), Price = 18.99M, Brand = artists.Single(a => a.Name == "Doreen de Feis"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Sport"), Price = 28.99M, Brand = artists.Single(a => a.Name == "DC"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Classical"), Price = 18.99M, Brand = artists.Single(a => a.Name == "DC"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "unisex", Genre = genres.Single(g => g.Name == "Classical"), Price = 28.99M, Brand = artists.Single(a => a.Name == "Doreen de Feis"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                new Item { Type = "female", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Brand = artists.Single(a => a.Name == "Doreen de Feis"), ItemArtUrl = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Item.Add(a));
        }
    }
}