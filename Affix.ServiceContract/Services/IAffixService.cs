using Affix.ServiceContract.Service_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
     public interface  IAffixService
    {
        Task<AffixServiceObject> CreateAffixAsync(AffixServiceObject catalogueserviceObject, CancellationToken token);

        Task<IEnumerable<AffixServiceObject>> GetAffixListAsync(CancellationToken token);
    }
}
