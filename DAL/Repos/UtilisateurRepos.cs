using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UtilisateurRepos
    {
        public List<Utilisateur> All() //pour récuperer tous les elements de la basededonnee

        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Utilisateurs.ToList();
        }
        public void Ajouter(Utilisateur obj)
        {
            using(var MyDbContext=new MyDbContext ()) {
            MyDbContext.Utilisateurs.Add(obj);
            MyDbContext.SaveChanges();
            }
        }

        public Utilisateur Afficher(int id)
        {
            using (var MyDbContext = new MyDbContext())
            {
               return MyDbContext.Utilisateurs.Find(id);

            }
        }
        public void Update(Utilisateur obj)
        {
            using (var MyDbContext = new MyDbContext())
            {
                var result = MyDbContext.Utilisateurs.Find(obj.Id);
                result.Nom=obj.Nom;
                MyDbContext.SaveChanges();  

            }
        }
        public void Delete(int id)
        {
            using (var MyDbContext = new MyDbContext())
            {
                var result= MyDbContext.Utilisateurs.Find(id);
                MyDbContext.Utilisateurs.Remove(result);
                MyDbContext.SaveChanges();


            }
        }
    }
}