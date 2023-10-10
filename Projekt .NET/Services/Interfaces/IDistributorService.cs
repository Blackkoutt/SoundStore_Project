using Projekt_.NET.Models;

namespace Projekt_.NET.Services.Interfaces
{
    public interface IDistributorService
    {
        public void Add(Distributor distributor);
        public void Delete(int id);
        public Distributor GetOne(int id);
        public List<Distributor> GetAll();
    }
}
