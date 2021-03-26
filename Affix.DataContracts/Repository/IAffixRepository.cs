using Affix.DataContracts.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.DataContracts.Repository
{
   public  interface IAffixRepository
    {
        Task<AffixEntity> CreateAffixAsync(AffixEntity affixentity, CancellationToken token);

        Task<IEnumerable<AffixEntity>> GetAffixListAsync(CancellationToken token);


    }
}
