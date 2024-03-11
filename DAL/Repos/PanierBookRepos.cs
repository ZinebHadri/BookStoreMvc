using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PanierBookRepos
    {
        public void Create(PanierBook entity)
        {
            MyDbContext db = new MyDbContext();
            db.PanierBooks.Add(entity);
            db.SaveChanges();
        }
        public List<PanierBook> All(PanierBook entity)
        {
            MyDbContext db = new MyDbContext();
            return db.PanierBooks.ToList();
        }
    }
}