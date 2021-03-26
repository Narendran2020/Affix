using Affix.DataContracts.Entity;
using Affix.DataContracts.Repository;
using Affix.ServiceContract.Service_Objects;
using Affix.ServiceContract.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.Services.Services
{
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;
        private readonly IMapper _mapper;

        public StateService(IStateRepository staterepository, IMapper mapper)
        {
            _stateRepository = staterepository;
            _mapper = mapper;
        }
        public async Task<StateServiceObject> CreateStateAsync(StateServiceObject stateServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<StateEntity>(stateServiceObject);
            var createdEntity = await _stateRepository.CreateStateAsync(res, token);
            return _mapper.Map<StateServiceObject>(createdEntity);
        }

        public async Task DeleteStateByIdAsync(int stateId, CancellationToken token)
        {
            await _stateRepository.DeleteStateByIdAsync(stateId, token); ;
        }

        public async Task<IEnumerable<StateServiceObject>> GetStateListAsync(CancellationToken token)
        {
            var serviceResult = await _stateRepository.GetStateListAsync(token);
            return _mapper.Map<IEnumerable<StateServiceObject>>(serviceResult);
        }

        public async Task<StateServiceObject> UpdateStateByIdAsync(StateServiceObject stateServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<StateEntity>(stateServiceObject);
            var updatedEntity = await _stateRepository.UpdateStateByIdAsync(res, token);
            return _mapper.Map<StateServiceObject>(updatedEntity);
        }
    }
}
