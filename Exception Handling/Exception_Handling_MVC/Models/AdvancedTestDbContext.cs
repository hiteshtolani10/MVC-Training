using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exception_Handling_MVC.Models;

public partial class AdvancedTestDbContext : DbContext
{
    public AdvancedTestDbContext()
    {
    }

    public AdvancedTestDbContext(DbContextOptions<AdvancedTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AHM-FJRQZD3-L\\MSSQLSERVER01;Database=AdvancedTestDb;Trusted_Connection=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_contacts");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
