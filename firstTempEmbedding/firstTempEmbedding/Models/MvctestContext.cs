using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace firstTempEmbedding.Models;

public partial class MvctestContext : DbContext
{
    public MvctestContext()
    {
    }

    public MvctestContext(DbContextOptions<MvctestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<User> Users { get; set; }
	public virtual DbSet<Role> Roles { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.;initial catalog=mvctest;user id=sa;password=aptech; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3214EC07D8F27B33");

            entity.ToTable("employee");

            entity.Property(e => e.Designation)
                .HasMaxLength(250)
                .HasColumnName("designation");
            entity.Property(e => e.Empname)
                .HasMaxLength(250)
                .HasColumnName("empname");
            entity.Property(e => e.Joining)
                .HasColumnType("date")
                .HasColumnName("joining");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC0704CBEB22");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ServiceTitle)
                .HasMaxLength(255)
                .HasColumnName("Service_title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
