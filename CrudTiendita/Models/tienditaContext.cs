﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CrudTiendita.Models
{
    public partial class tienditaContext : DbContext
    {
        public tienditaContext()
        {
        }

        public tienditaContext(DbContextOptions<tienditaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user id=root;password=root;database=tiendita", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.18-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproductos)
                    .HasName("PRIMARY");

                entity.ToTable("productos");

                entity.HasComment("	");

                entity.Property(e => e.Idproductos)
                    .HasColumnType("int(11)")
                    .HasColumnName("idproductos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Existecia)
                    .HasColumnType("int(11)")
                    .HasColumnName("existecia");

                entity.Property(e => e.Precio)
                    .HasPrecision(8, 2)
                    .HasColumnName("precio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
