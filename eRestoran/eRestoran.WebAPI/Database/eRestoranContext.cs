using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eRestoran.WebAPI.Database
{
    public partial class eRestoranContext : DbContext
    {
        public eRestoranContext()
        {
        }

        public eRestoranContext(DbContextOptions<eRestoranContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Jelo> Jelos { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<NarudzbaDetalji> NarudzbaDetaljis { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_BIN");

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Jelo>(entity =>
            {
                entity.ToTable("Jelo");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Jelos)
                    .HasForeignKey(d => d.KategorijaID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Jelo_Kategorija");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime).HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash);

                entity.Property(e => e.LozinkaSalt);

                entity.Property(e => e.Prezime).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.GradID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Korisnik_Grad");
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.ToTable("KorisnikUloga");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.KorisnikID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_KorisnikUloga_Korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.UlogaID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_KorisnikUloga_Uloga");
            });

            

            modelBuilder.Entity<Like>(entity =>
            {
                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.HasOne(d => d.Jelo)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.JeloID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LikeJelo");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.KorisnikID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Like_Korisnik");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.ToTable("Narudzba");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.NarudzbaKorisniks)
                    .HasForeignKey(d => d.KorisnikID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Narudzba_Korisnik");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Narudzba_Status");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.NarudzbaUposleniks)
                    .HasForeignKey(d => d.UposlenikID)
                    .HasConstraintName("FK_Narudzba_Uposlenik");
            });

            modelBuilder.Entity<NarudzbaDetalji>(entity =>
            {
                entity.ToTable("NarudzbaDetalji");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Jelo)
                    .WithMany(p => p.NarudzbaDetaljis)
                    .HasForeignKey(d => d.JeloID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NarudzbaDetalji_Jelo");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaDetaljis)
                    .HasForeignKey(d => d.NarudzbaID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NarudzbaDetalji_Narudzba");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RezervacijaKorisniks)
                    .HasForeignKey(d => d.KorisnikID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Rezervacija_Korisnik");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Rezervacija_Status");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.RezervacijaUposleniks)
                    .HasForeignKey(d => d.UposlenikID)
                    .HasConstraintName("FK_Rezervacija_Uposlenik");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
