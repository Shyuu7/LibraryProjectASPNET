using LibraryProject.Data.Models;
using SQLitePCL;

namespace LibraryProject.Data
{
    public class RepositoryBook : IRepositoryBook
    {
        private LibraryProjectContext _context;
        public RepositoryBook(LibraryProjectContext context)
        {
            _context = context;
        }
        public List<Book> Getall()
        {
            return _context.Book.ToList();
        }
        public void Add(Book product)
        {
            _context.Book.Add(product);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var deleteItem = _context.Book.FirstOrDefault(p => p.id == id);
            if (deleteItem != null)
            {
                _context.Book.Remove(deleteItem);
                _context.SaveChanges();
            }

        }

        public void Edit(Book updatedBook)
        {
            var existingBook = _context.Book.FirstOrDefault(b => b.id == updatedBook.id);

            if (existingBook != null)
            {
                existingBook.title = updatedBook.title;
                existingBook.description = updatedBook.description;
                existingBook.price = updatedBook.price;
                existingBook.author = updatedBook.author;
                existingBook.publishingYear = updatedBook.publishingYear;
                existingBook.ISBN = updatedBook.ISBN;
                existingBook.genre = updatedBook.genre;

                _context.SaveChanges();
            }
        }
        public Book GetById(int id)
        {
            return _context.Book.FirstOrDefault(p => p.id == id);
        }
        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

    }
}
