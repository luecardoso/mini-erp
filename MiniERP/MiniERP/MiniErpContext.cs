using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MiniERP.DataModels;

namespace MiniERP;

public partial class MiniErpContext : DbContext
{
    public MiniErpContext()
    {
    }

    public MiniErpContext(DbContextOptions<MiniErpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Itempedido> Itempedidos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; initial Catalog=mini_erp;User ID=usuario3;password=senha1234;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cliente__3213E83FA629C67A");

            entity.ToTable("cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataNascimento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dataNascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Sexo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefone)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__forneced__3213E83FA1F6B226");

            entity.ToTable("fornecedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Itempedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__itempedi__3213E83FB74631C6");

            entity.ToTable("itempedido");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FkPedido).HasColumnName("fk_pedido");
            entity.Property(e => e.FkProduto).HasColumnName("fk_produto");
            entity.Property(e => e.QuantidadeComprada).HasColumnName("quantidadeComprada");
            entity.Property(e => e.ValorTotal)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valorTotal");
            entity.Property(e => e.ValorUnitario)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valorUnitario");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.Itempedidos)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__itempedid__fk_pe__4316F928");

            entity.HasOne(d => d.FkProdutoNavigation).WithMany(p => p.Itempedidos)
                .HasForeignKey(d => d.FkProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__itempedid__fk_pr__4222D4EF");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pedido__3213E83F990E9376");

            entity.ToTable("pedido");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCompra)
                .HasColumnType("datetime")
                .HasColumnName("dataCompra");
            entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pedido__fk_clien__3F466844");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__produto__3213E83F66A81CB6");

            entity.ToTable("produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FkFornecedor).HasColumnName("fk_fornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preco");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");

            entity.HasOne(d => d.FkFornecedorNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FkFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__produto__fk_forn__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
