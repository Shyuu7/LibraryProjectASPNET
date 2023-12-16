using LibraryProject.Data.Models;

namespace LibraryProject.Data
{
    public interface IRepositoryBook
    {
        public List<Book> Getall();
        public void Add(Book book);
        public void Edit(Book book);
        public void Delete(int id);
        public Book GetById(int id);

    }
}
