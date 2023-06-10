using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PetAmigoMVC;

public partial class PetAmigoContext : DbContext
{
    public PetAmigoContext()
    {
    }

    public PetAmigoContext(DbContextOptions<PetAmigoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doacao> Doacaos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PetAmigo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__doacao__3213E83FDC36C4F1");

            entity.ToTable("doacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cep)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Imgurl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imgurl");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Raca)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("raca");
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
