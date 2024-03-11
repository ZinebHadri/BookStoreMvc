using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos;

public class BookRepos
{
    public void Create(Book entity)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Books.Add(entity);
        mydb.SaveChanges();
    }

    public  Book Read(int id)
    {
        MyDbContext mydb = new MyDbContext();
        return mydb.Books.Find(id);
    }

    public List<Book> ReadAll()
    {
        MyDbContext mydb = new MyDbContext();
        return mydb.Books.ToList();
    }

    public void Update(Book entity)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Entry(entity).State = EntityState.Modified;
        mydb.SaveChanges();
    }
    public void Add(Book book)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Books.Add(book);
        mydb.SaveChanges();
    }
    public Book GetBookById(int id)
    {
        MyDbContext mydb = new MyDbContext();
        return mydb.Books.FirstOrDefault(book => book.Id == id);
    }
    public void Delete(int id)
    {
        MyDbContext mydb = new MyDbContext();
        Book entity = mydb.Books.Find(id);
        mydb.Books.Remove(entity);
        mydb.SaveChanges();
    }
}