﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OChamaAqui.DATA.Models
{
    public partial class OChamaAquiContext : DbContext
    {
        public OChamaAquiContext()
        {
        }

        public OChamaAquiContext(DbContextOptions<OChamaAquiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vaga> Vaga { get; set; }
        public virtual DbSet<VagaCliente> VagaCliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2P2AHI0\\SQLEXPRESS;Initial Catalog=OChamaAqui;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Cpf).IsFixedLength();

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.Numero).IsFixedLength();
            });

            modelBuilder.Entity<Vaga>(entity =>
            {
                entity.Property(e => e.Local).IsFixedLength();
            });

            modelBuilder.Entity<VagaCliente>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vaga_Cliente_Usuario");

                entity.HasOne(d => d.IdVagaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVaga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vaga_Cliente_Vaga");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}