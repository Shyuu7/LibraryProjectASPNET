using LibraryProject.Data.Models;
using SQLitePCL;

namespace LibraryProject.Data
{
    public class RepositoryCD : IRepositoryCD
    {
        private LibraryProjectContext _context;
        public RepositoryCD(LibraryProjectContext context)
        {
            _context = context;
        }
        public List<CD> Getall()
        {
            return _context.CD.ToList();
        }
        public void Add(CD cd)
        {
            _context.CD.Add(cd);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var deleteItem = _context.CD.FirstOrDefault(p => p.id == id);
            if (deleteItem != null)
            {
                _context.CD.Remove(deleteItem);
                _context.SaveChanges();
            }

        }

        public void Edit(CD updatedCD)
        {
            var existingCD = _context.CD.FirstOrDefault(b => b.id == updatedCD.id);

            if (existingCD != null)
            {
                existingCD.name = updatedCD.name;
                existingCD.singer = updatedCD.singer;
                existingCD.price = updatedCD.price;
                existingCD.album = updatedCD.album;
                existingCD.releaseYear = updatedCD.releaseYear;

                _context.SaveChanges();
            }
        }
        public CD GetById(int id)
        {
            return _context.CD.FirstOrDefault(p => p.id == id);
        }
        public void Update(CD cd)
        {
            throw new NotImplementedException();
        }

    }
}
