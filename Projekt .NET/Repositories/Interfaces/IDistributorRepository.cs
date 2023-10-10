using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface IDistributorRepository
    {
        public void Add(Distributor distributor);
        public void Delete(int id);
        public Distributor GetOne(int id);
        public List<Distributor> GetAll();
    }
}
