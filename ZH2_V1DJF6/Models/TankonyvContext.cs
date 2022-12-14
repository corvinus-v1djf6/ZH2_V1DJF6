﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH2_V1DJF6.Models;

public partial class TankonyvContext : DbContext
{
    public TankonyvContext()
    {
    }

    public TankonyvContext(DbContextOptions<TankonyvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Textbook> Textbooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\v1djf6\\source\\repos\\ZH2_V1DJF6\\ZH2_V1DJF6\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderSk);

            entity.ToTable("Order");

            entity.Property(e => e.OrderSk).HasColumnName("OrderSK");
            entity.Property(e => e.StudentFk).HasColumnName("StudentFK");
            entity.Property(e => e.TextbookFk).HasColumnName("TextbookFK");

            entity.HasOne(d => d.StudentFkNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StudentFk)
                .HasConstraintName("FK_Order_ToStudent");

            entity.HasOne(d => d.TextbookFkNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.TextbookFk)
                .HasConstraintName("FK_Order_ToTextbook");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.Neptun)
                .HasMaxLength(6)
                .IsFixedLength();
        });

        modelBuilder.Entity<Textbook>(entity =>
        {
            entity.ToTable("Textbook");

            entity.Property(e => e.TextbookId)
                .ValueGeneratedNever()
                .HasColumnName("TextbookID");
            entity.Property(e => e.StockNumber).HasMaxLength(15);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
