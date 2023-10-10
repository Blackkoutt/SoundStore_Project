using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbProducerRepository : IProducerRepository
    {
        private readonly ApiContext _context;
        public DbProducerRepository(ApiContext context)
        {
            _context = context;
        }
        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var producerToDelete = GetOne(id);
            _context.Producers.Remove(producerToDelete);
            _context.SaveChanges();
        }

        public List<Producer> GetAll()
        {
            return _context.Producers.ToList();
        }

        public Producer GetOne(int id)
        {
            return _context.Producers.FirstOrDefault(m => m.Id == id);
        }
    }
}
