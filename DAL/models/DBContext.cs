using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Detaile> Detailes { get; set; }
        public virtual DbSet<Invaite> Invaites { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Desktop\\projectChanuca\\StoreAccesories.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CodeCategory)
                    .HasName("PK__Category__CBD747064A2BE97D");

                entity.ToTable("Category");

                entity.Property(e => e.NameCategory).HasMaxLength(50);
            });

            modelBuilder.Entity<Detaile>(entity =>
            {
                entity.HasKey(e => e.CodeDetailesOfInvite)
                    .HasName("PK__tmp_ms_x__81AB01811CA659E3");

                entity.HasOne(d => d.CodeInviteNavigation)
                    .WithMany(p => p.Detailes)
                    .HasForeignKey(d => d.CodeInvite)
                    .HasConstraintName("FK_Detailes_ToTable");

                entity.HasOne(d => d.CodeProductNavigation)
                    .WithMany(p => p.Detailes)
                    .HasForeignKey(d => d.CodeProduct)
                    .HasConstraintName("FK_Detailes_ToTable_1");
            });

            modelBuilder.Entity<Invaite>(entity =>
            {
                entity.HasKey(e => e.CodeInvite)
                    .HasName("PK__Invaites__22B0C94ED13E9F32");

                entity.Property(e => e.DateInvite).HasColumnType("datetime");

                entity.HasOne(d => d.CodeUserNavigation)
                    .WithMany(p => p.Invaites)
                    .HasForeignKey(d => d.CodeUser)
                    .HasConstraintName("FK_Invaites_ToTable");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.CodePicture)
                    .HasName("PK__Products__2E8946D476190213");

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NamePicture)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodeCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CodeCategory)
                    .HasConstraintName("FK_Products_ToTable");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CodeUser)
                    .HasName("PK__tmp_ms_x__B7C926387853C51D");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.NameUser)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
