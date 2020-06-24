using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IsA.Models.Banka
{
    public class DbContextBanka : DbContext
    {
        
        public DbContextBanka() { }
        public DbContextBanka(DbContextOptions<DbContextBanka> options) : base(options)
        {
        }

        public virtual DbSet<Banka> Banka { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("Data Source=ZC-A7\\SQLEXPRESS;Initial Catalog=VETS;Integrated Security=True");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banka>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id").UseIdentityColumn(1, 1);

                entity.Property(e => e.adresa)
                    .HasColumnName("adresa")
                    .HasMaxLength(100);

                entity.Property(e => e.mesto)
                    .IsRequired()
                    .HasColumnName("mesto")
                    .HasMaxLength(255);

                entity.Property(e => e.naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(255);
            });

            initialDataBanka(modelBuilder);
        }
        public IConfiguration Configuration { get; }
        void initialDataBanka(ModelBuilder modelBuilder)
        {
            DataSet ds = new DataSet();
            
            string constring = Podesavanja.connectionString_VETS_test;
            SqlDataAdapter da = new SqlDataAdapter("Select*from Banka", constring);
            da.Fill(ds);
            List<Banka> lstBanke = new List<Banka>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Banka b1 = new Banka();
                b1.Id = (1 + i);
                b1.adresa = ds.Tables[0].Rows[i].IsNull("Adresa") ? "" : (string)ds.Tables[0].Rows[i]["Adresa"];
                b1.mesto = (string)ds.Tables[0].Rows[i]["Mesto"];
                b1.naziv = (string)ds.Tables[0].Rows[i]["Naziv"];
                lstBanke.Add(b1);
            }
            
            modelBuilder.Entity<Banka>().HasData(lstBanke.ToArray());
        }
    }
}
