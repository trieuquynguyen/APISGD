﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeFake.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFoodApi.Domain.EntityTypeConfigurations
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
