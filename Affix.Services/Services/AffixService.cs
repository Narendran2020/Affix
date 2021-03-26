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
    public class AffixService : IAffixService
    {
        private readonly IAffixRepository _affixRepository;
        private readonly IMapper _mapper;

        public AffixService(IAffixRepository affixRepository, IMapper mapper)
        {
            _affixRepository = affixRepository;
            _mapper = mapper;

        }
        public async Task<AffixServiceObject> CreateAffixAsync(AffixServiceObject catalogueserviceObject, CancellationToken token)
        {
            var res = _mapper.Map<AffixEntity>(catalogueserviceObject);
            var createdEntity = await _affixRepository.CreateAffixAsync(res, token);
            return _mapper.Map<AffixServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<AffixServiceObject>> GetAffixListAsync(CancellationToken token)
        {
            var serviceResult = await _affixRepository.GetAffixListAsync(token);
            return _mapper.Map<IEnumerable<AffixServiceObject>>(serviceResult);
        }
    }
}
