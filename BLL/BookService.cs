using DAL.Entity;
using DAL.Repos;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class BookService
    {

        private readonly BookRepos _bookRepository;

        public BookService(BookRepos bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.ReadAll();
        }



        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }


        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }
        public BookDetailVM GetBookById(int id)
        {
            var book = _bookRepository.GetBookById(id);

            if (book == null)
            {
                throw new InvalidOperationException($"No book found with ID {id}");
            }

            return new BookDetailVM
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
            
            };
        }

    }
        
}

    
