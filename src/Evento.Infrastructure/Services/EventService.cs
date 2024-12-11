using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Evento.Core.Repositories
using Evento.Infrastrucure.DTO;

namespace Evento.Infrastrucure.Services
{

    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        private readonly IMapper _mapper;


        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }


        public async Task<EventDto> GetAsync(Guid id)
        {
            var @event = await _eventRepository.GetAsync(id);

            return _mapper.Map<EventDto>@event(@event);
        }

        public async Task<IEnumerable<EventDto>> BrowseAsync(string name = null)
        {
            var events = await _eventRepository.BrowseAsync(name);

            return _mapper.Map<IEnumerable<EventDto>>(events);
        }
         
        public async TaskCreateAsync(Guid id, string name, string description, DateTime startDate. DateTime endDate)
        {
            throw mew NotImplementedException();
        }

        public async Task AddTicketsAsync(Guid eventId, int amount, decimal price)
        {
            throw new NotImplementedException();
        }

        public async TaskUpdateAsync(Guid name, string name, string description)
        {
            throw new NotImplementedException();
        }

        public async DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}