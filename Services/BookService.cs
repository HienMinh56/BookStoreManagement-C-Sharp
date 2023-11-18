using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new BookRepository();

        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        public List<Book> SearchBooks(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.Description.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<Book> SearchBooksByCate(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookCategoryId.ToString().Contains(keyword.ToLower())).ToList();
        }
        public Book? SearchBooksByName(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookName.ToLower().ToString().Trim().Equals(keyword.ToLower().Trim())).FirstOrDefault();
        }

        public void DeleteABook(int id)
        {
            _repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return _repo.Get(id);
        }

        public void AddABook(Book book)
        {
            _repo.Create(book);
        }

        public void UpdateABook(Book book)
        {
            _repo.Update(book);
        }
    }
}