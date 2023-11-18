using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagement2023DbContext _context;
        public Book? Get(int bookId)
        {
            _context = new BookManagement2023DbContext();

            return _context.Books.Find(bookId);
        }

        public List<Book> GetAll()
        {
            _context = new BookManagement2023DbContext();

            return _context.Books.Include(cat => cat.BookCategory).ToList();
        }

        public void Create(Book book)
        {
            _context = new BookManagement2023DbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context = new BookManagement2023DbContext();
            _context.Books.Update(book);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context = new BookManagement2023DbContext();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
