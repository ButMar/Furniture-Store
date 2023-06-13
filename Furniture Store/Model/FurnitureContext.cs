using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Furniture_Store.Model;

public partial class FurnitureContext : DbContext
{
    public FurnitureContext()
    {
    }

    public FurnitureContext(DbContextOptions<FurnitureContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Calculate> Calculates { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<KitchensTemplate> KitchensTemplates { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=marynapc;Database=furniture;User ID=user1;Password=sa;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calculate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Calculat__3213E83FB95863FB");

            entity.ToTable("Calculate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ASideLeft).HasColumnName("aSideLeft");
            entity.Property(e => e.BSideCentre).HasColumnName("bSideCentre");
            entity.Property(e => e.CSideRight).HasColumnName("cSideRight");
        });

        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.DatailId);

            entity.ToTable("Detail");

            entity.Property(e => e.DatailId)
                .ValueGeneratedNever()
                .HasColumnName("datail_id");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<KitchensTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KitchensTemplate");

            entity.Property(e => e.KitchenDescription)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kitchenDescription");
            entity.Property(e => e.KitchenType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kitchenType");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.ToTable("Price");

            entity.Property(e => e.PriceId)
                .ValueGeneratedNever()
                .HasColumnName("price_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Price1).HasColumnName("price1");
            entity.Property(e => e.Price100).HasColumnName("price100");
            entity.Property(e => e.Price20).HasColumnName("price20");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);









}
