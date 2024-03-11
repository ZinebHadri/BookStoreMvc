using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategorieRepos
    {
        public List<Categorie> All()
        {
            MyDbContext db = new MyDbContext();
            return db.Categories.ToList();
        }
        public void Create(Categorie entity)
        {
            MyDbContext db = new MyDbContext();
            db.Categories.Add(entity);
            db.SaveChanges();

         }
        public void Update(Categorie entity)
        {
            using (var MyDbContext = new MyDbContext())
            {
                var result = MyDbContext.Categories.Find(entity.Id);
                result.NomCategorie = entity.NomCategorie;
                MyDbContext.SaveChanges();

            }
        }
         public Categorie GetById(int id)
            {
               MyDbContext db = new MyDbContext();
                return db.Categories.FirstOrDefault(c => c.Id == id);
            }
        
    }
}
