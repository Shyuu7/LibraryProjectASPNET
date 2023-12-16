using LibraryProject.Data.Models;

namespace LibraryProject.Data
{
    public interface IRepositoryCD
    {
        public List<CD> Getall();
        public void Add(CD cd);
        public void Edit(CD cd);
        public void Delete(int id);
        public CD GetById(int id);

    }
}
