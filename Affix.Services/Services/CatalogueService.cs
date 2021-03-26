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
    public class CatalogueService : ICatalogueService
    {
        private readonly ICatalogueRepository _catalogueRepository;
        private readonly IMapper _mapper;

        public CatalogueService(ICatalogueRepository catalogueRepository, IMapper mapper)
        {
            _catalogueRepository = catalogueRepository;
            _mapper = mapper;
        }
        public async Task<CatalogueServiceObject> CreateCatalogueAsync(CatalogueServiceObject catalogueserviceObject, CancellationToken token)
        {
            var res = _mapper.Map<CatalogueEntity>(catalogueserviceObject);
            var createdEntity = await _catalogueRepository.CreateCatalogueAsync(res, token);
            return _mapper.Map<CatalogueServiceObject>(createdEntity);

        }

        public async Task<IEnumerable<CatalogueServiceObject>> GetCatalogueListAsync(CancellationToken token)
        {
            var serviceResult = await _catalogueRepository.GetCatalogueListAsync(token);
            return _mapper.Map<IEnumerable<CatalogueServiceObject>>(serviceResult);
        }
    }
}


