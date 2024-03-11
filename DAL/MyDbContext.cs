using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
  public class MyDbContext: DbContext 
    {//je definis les entites que j ai de type dbset
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<PanierBook> PanierBooks{ get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Book> Books{ get; set; }
        protected override void OnConfiguring
         (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=.\SQLEXPRESS;Initial Catalog=BookStore;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }



}
