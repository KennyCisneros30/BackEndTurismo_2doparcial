﻿using System;
using System.Collections.Generic;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public partial class restauranteContext : DbContext
{
    public restauranteContext()
    {
    }

    public restauranteContext(DbContextOptions<restauranteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Restaurante> Restaurantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5755S3Q\\SQLEXPRESS;Database=Turismodbfirst;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Restaura__3214EC07EFC4F6BC");

            entity.ToTable("Restaurante");

            entity.Property(e => e.Calificacion).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.Direccion).HasMaxLength(400);
            entity.Property(e => e.Especialidad).HasMaxLength(400);
            entity.Property(e => e.Foto).HasMaxLength(300);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
