using Affix.DataContracts.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.DataContracts.Repository
{
     public interface ICountryRepository
    {
        Task<CountryEntity> CreateCountryAsync(CountryEntity countryEntity, CancellationToken token);

        Task<IEnumerable<CountryEntity>> GetCountryListAsync(CancellationToken token);

        Task<CountryEntity> UpdateCountryByIdAsync(CountryEntity countryEntity, CancellationToken token);

        Task DeleteCountryByIdAsync(int countryId, CancellationToken token);
    }
}
