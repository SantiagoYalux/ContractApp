using ContractsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ContractsApp.Repository.DBContext;

public partial class ContractcourseDbContext : DbContext
{
    public ContractcourseDbContext()
    {
    }

    public ContractcourseDbContext(DbContextOptions<ContractcourseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Contractitem> Contractitems { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contract");

            entity.Property(e => e.ColegioCurso).HasMaxLength(3);
            entity.Property(e => e.ColegioLocalidad).HasMaxLength(100);
            entity.Property(e => e.ColegioNivel).HasMaxLength(16);
            entity.Property(e => e.ColegioNombre).HasMaxLength(150);
            entity.Property(e => e.CourseCode).HasMaxLength(100);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.MedioEntrega).HasMaxLength(100);
            entity.Property(e => e.Total).HasPrecision(10, 2);
            entity.Property(e => e.Vendedor).HasMaxLength(100);
        });

        modelBuilder.Entity<Contractitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contractitem");

            entity.HasIndex(e => e.ContractId, "ContractId");

            entity.HasIndex(e => e.ItemId, "ItemId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(25);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Contract).WithMany(p => p.Contractitems)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contractitem_ibfk_1");

            entity.HasOne(d => d.Item).WithMany(p => p.Contractitems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contractitem_ibfk_2");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item");

            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Precio).HasPrecision(9, 2);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
