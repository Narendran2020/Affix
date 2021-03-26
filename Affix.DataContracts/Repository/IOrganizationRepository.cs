using Affix.DataContracts.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.DataContracts.Repository
{
    public interface IOrganizationRepository
    {
        Task<OrganizationEntity> CreateOrganizationAsync(OrganizationEntity organizationEntity, CancellationToken token);

        Task<IEnumerable<OrganizationEntity>> GetOrganizationListAsync(CancellationToken token);

        Task<OrganizationEntity> UpdateOrganizationByIdAsync(OrganizationEntity organizationEntity, CancellationToken token);

        Task DeleteOrganizationByIdAsync(int organizationId, CancellationToken token);



    }
}
