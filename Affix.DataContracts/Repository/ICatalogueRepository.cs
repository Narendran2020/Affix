using Affix.DataContracts.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.DataContracts.Repository
{
    public interface ICatalogueRepository
    {
        Task<CatalogueEntity> CreateCatalogueAsync(CatalogueEntity catalogueentity, CancellationToken token);

        Task<IEnumerable<CatalogueEntity>> GetCatalogueListAsync(CancellationToken token);
    }
}
