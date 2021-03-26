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
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryrepository, IMapper mapper)
        {
            _countryRepository = countryrepository;
            _mapper = mapper;
        }
        public async Task<CountryServiceObject> CreateCountryAsync(CountryServiceObject countryServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<CountryEntity>(countryServiceObject);
            var createdEntity = await _countryRepository.CreateCountryAsync(res, token);
            return _mapper.Map<CountryServiceObject>(createdEntity);
        }

        public async Task DeleteCountryByIdAsync(int countryId, CancellationToken token)
        {
            await _countryRepository.DeleteCountryByIdAsync(countryId, token);
        }

        public async Task<IEnumerable<CountryServiceObject>> GetCountryListAsync(CancellationToken token)
        {
            var serviceResult = await _countryRepository.GetCountryListAsync(token);
            return _mapper.Map<IEnumerable<CountryServiceObject>>(serviceResult);
        }

        public async Task<CountryServiceObject> UpdateCountryByIdAsync(CountryServiceObject countryServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<CountryEntity>(countryServiceObject);
            var updatedEntity = await _countryRepository.UpdateCountryByIdAsync(res, token);
            return _mapper.Map<CountryServiceObject>(updatedEntity);
        }
    }
}
