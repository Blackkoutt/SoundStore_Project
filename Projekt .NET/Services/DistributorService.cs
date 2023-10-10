using Projekt_.NET.Models;
using Projekt_.NET.Repositories.DbImplementations;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Services
{
    public class DistributorService : IDistributorService
    {
        private readonly IDistributorRepository _distributorRepository;
        public DistributorService(IDistributorRepository _distributorRepository)
        {
            this._distributorRepository = _distributorRepository;
        }
        public void Add(Distributor distributor)
        {
            _distributorRepository.Add(distributor);
        }

        public void Delete(int id)
        {
            _distributorRepository.Delete(id);
        }

        public List<Distributor> GetAll()
        {
            return _distributorRepository.GetAll();
        }

        public Distributor GetOne(int id)
        {
            return _distributorRepository.GetOne(id);
        }
    }
}
