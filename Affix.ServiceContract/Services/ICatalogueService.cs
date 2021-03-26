using Affix.ServiceContract.Service_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
    public interface ICatalogueService
    {
        Task<CatalogueServiceObject> CreateCatalogueAsync(CatalogueServiceObject catalogueserviceObject, CancellationToken token);

        Task<IEnumerable<CatalogueServiceObject>> GetCatalogueListAsync(CancellationToken token);

    }
}
