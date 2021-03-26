using Affix.DataContracts.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.DataContracts.Repository
{
     public interface  IStateRepository
    {
        Task<StateEntity> CreateStateAsync(StateEntity stateEntity, CancellationToken token);

        Task<IEnumerable<StateEntity>> GetStateListAsync(CancellationToken token);

        Task<StateEntity> UpdateStateByIdAsync(StateEntity stateEntity, CancellationToken token);

        Task DeleteStateByIdAsync(int stateId, CancellationToken token);


    }
}
