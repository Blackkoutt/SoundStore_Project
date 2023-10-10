using Projekt_.NET.DTO;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.DbImplementations;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Services
{
    public class PerformerService : IPerformerService
    {
        private readonly IPerformerRepository _performerRepository;
        public PerformerService(IPerformerRepository _performerRepository)
        {
            this._performerRepository = _performerRepository;
        }
        public void Add(PerformerDto performer)
        {
            Performer performerToAdd = new Performer();
            performerToAdd.Id = performer.Id;
            performerToAdd.Name = performer.Name;
            _performerRepository.Add(performerToAdd);
        }

        public void Delete(int id)
        {
            _performerRepository.Delete(id);
        }

        public List<Performer> GetAll()
        {
            return _performerRepository.GetAll();   
        }

        public Performer GetOne(int id)
        {
            return _performerRepository.GetOne(id);
        }
    }
}
