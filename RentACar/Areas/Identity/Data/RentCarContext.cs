﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCar.Areas.Identity.Data;

namespace RentCar.Areas.Identity.Data;

public class RentCarContext : IdentityDbContext<RentCarUser>
{
    public RentCarContext(DbContextOptions<RentCarContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new RentCarUserEntityConfiguration());

    }
}
    public class RentCarUserEntityConfiguration : IEntityTypeConfiguration<RentCarUser>
    {
        public void Configure(EntityTypeBuilder<RentCarUser> builder)
        {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }