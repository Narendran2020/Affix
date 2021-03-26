using Affix.ServiceContract.Service_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
   public interface  ICountryService
    {
        Task<CountryServiceObject> CreateCountryAsync(CountryServiceObject countryServiceObject, CancellationToken token);
        Task<CountryServiceObject> UpdateCountryByIdAsync(CountryServiceObject countryServiceObject, CancellationToken token);
        Task<IEnumerable<CountryServiceObject>> GetCountryListAsync(CancellationToken token);
        Task DeleteCountryByIdAsync(int countryId, CancellationToken token);



    }
}
