using Affix.ServiceContract.Service_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
    public interface IOrganizationService
    {
        Task<OrganizationServiceObject> CreateOrganizationAsync(OrganizationServiceObject appointmentServiceObject, CancellationToken token);
        Task<OrganizationServiceObject> UpdateOrganizationByIdAsync(OrganizationServiceObject appointmentServiceObject, CancellationToken token);
        Task<IEnumerable<OrganizationServiceObject>> GetOrganizationListAsync(CancellationToken token);
        Task DeleteOrganizationByIdAsync(int appointmentId, CancellationToken token);
    }

}
