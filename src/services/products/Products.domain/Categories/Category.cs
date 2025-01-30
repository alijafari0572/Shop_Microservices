﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Products.domain.Products;

namespace Products.domain.Categories
{
    public class Category : BaseEntity.BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Permalink { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public string BannerUrl { get; set; }
        public string IconUrl { get; set; }
        public string ThumbnailUrl { get; set; }

        public ICollection<Product> Products { get; set; }
        public Category ParentCategory { get; set; }

        public class CategoryConfiguration : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.HasKey(b => b.Id);
                builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
                builder.Property(p => p.Permalink).IsRequired().HasMaxLength(200);
                builder.Property(p => p.BannerUrl).IsRequired().HasMaxLength(50)
                    .HasDefaultValue("https://via.placeholder.com/500x100.png");
                builder.Property(p => p.IconUrl).IsRequired().HasMaxLength(50)
                    .HasDefaultValue("https://via.placeholder.com/85.png");
                builder.Property(p => p.ThumbnailUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/150x150.png");
                builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);

                builder.HasData(SeedCategories());
            }

            private List<Category> SeedCategories()
            {
                var categories = new List<Category>();
                string directoryPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                string categorySeedPath = Path.Combine(directoryPath, @"SeedData/CategorySeed.json");
                using (StreamReader r = new StreamReader(categorySeedPath))
                {
                    string json = r.ReadToEnd();
                    categories = JsonConvert.DeserializeObject<List<Category>>(json);
                }

                return categories ?? new();
            }
        }
    }
}