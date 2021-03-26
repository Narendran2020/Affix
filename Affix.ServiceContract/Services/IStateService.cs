using Affix.ServiceContract.Service_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
    public interface IStateService
    {
        Task<StateServiceObject> CreateStateAsync(StateServiceObject stateServiceObject, CancellationToken token);
        Task<StateServiceObject> UpdateStateByIdAsync(StateServiceObject stateServiceObject, CancellationToken token);
        Task<IEnumerable<StateServiceObject>> GetStateListAsync(CancellationToken token);
        Task DeleteStateByIdAsync(int stateId, CancellationToken token);
    }
}
