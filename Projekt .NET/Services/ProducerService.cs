using Projekt_.NET.Models;
using Projekt_.NET.Repositories.DbImplementations;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;
        public ProducerService(IProducerRepository _producerRepository)
        {
            this._producerRepository = _producerRepository;
        }
        public void Add(Producer producer)
        {
            _producerRepository.Add(producer);
        }

        public void Delete(int id)
        {
            _producerRepository.Delete(id);
        }

        public List<Producer> GetAll()
        {
            return _producerRepository.GetAll();
        }

        public Producer GetOne(int id)
        {
            return _producerRepository.GetOne(id);
        }
    }
}
