using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbDistributorRepository : IDistributorRepository
    {
        private readonly ApiContext _context;
        public DbDistributorRepository(ApiContext context)
        {
            _context = context;
        }
        public void Add(Distributor distributor)
        {
            _context.Distributors.Add(distributor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var distributorToDelete = GetOne(id);
            _context.Distributors.Remove(distributorToDelete);
            _context.SaveChanges();
        }

        public List<Distributor> GetAll()
        {
            return _context.Distributors.ToList();
        }

        public Distributor GetOne(int id)
        {
            return _context.Distributors.FirstOrDefault(m => m.Id == id);
        }
    }
}
