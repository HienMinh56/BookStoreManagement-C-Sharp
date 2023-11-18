using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        private BookManagement2023DbContext _context = new();
        public List<BookCategory> GetAll()
        {
            //_context = new BookManagement2023DbContext();
            //return _context.BookCategories.ToList();
            return new BookManagement2023DbContext().BookCategories.ToList();
        }
        public void DeleteCate(int CateId)
        {
            var cate =_context.BookCategories.FirstOrDefault(c => c.BookCategoryId == CateId);
            if(cate != null)
            {
                _context.Remove(cate);
                _context.SaveChanges();
            }
        }
        public void AddCate(BookCategory cate)
        {
            _context.Add(cate);
            _context.SaveChanges();

        }
        public void UpdateCate(BookCategory cate)
        {
            _context.Update(cate);
            _context.SaveChanges();
        }
    }
}
