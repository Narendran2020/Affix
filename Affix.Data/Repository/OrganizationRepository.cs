using Affix.DataContracts.Entity;
using Affix.DataContracts.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.Data.Repository
{
    public sealed class OrganizationRepository : IOrganizationRepository
    {
        private readonly AppointmentDbContext _dbContext;

        public OrganizationRepository(AppointmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<OrganizationEntity> CreateOrganizationAsync(OrganizationEntity organizationEntity, CancellationToken token)
        {
            organizationEntity.ModifiedBy = null;
            organizationEntity.CreatedBy = 1;
            organizationEntity.ModifiedDate = null;
            organizationEntity.CreatedDate = DateTime.Now;
            organizationEntity.OrganizationGuid = Guid.NewGuid();
            await _dbContext.OrganizationMasters.AddAsync(organizationEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.OrganizationMasters.SingleAsync(x => x.Id == organizationEntity.Id, token);
        }

        public async Task DeleteOrganizationByIdAsync(int organizationId, CancellationToken token)
        {
            var organizationEntity = await _dbContext.OrganizationMasters
                .SingleAsync(appointment => appointment.Id == organizationId, token);
            organizationEntity.Status = false;
            await _dbContext.SaveChangesAsync(token);
        }

        public async Task<IEnumerable<OrganizationEntity>> GetOrganizationListAsync(CancellationToken token)
        {
            return await _dbContext.OrganizationMasters
                                   .Where(x => x.Status).ToListAsync(token);
        }

        public async Task<OrganizationEntity> UpdateOrganizationByIdAsync(OrganizationEntity organizationEntity, CancellationToken token)
        {
            organizationEntity.ModifiedDate = DateTime.Now;
            organizationEntity.CreatedBy = _dbContext.OrganizationMasters.Where(x => x.Id == organizationEntity.Id).Select(x => x.CreatedBy).FirstOrDefault();
            organizationEntity.ModifiedBy = 1;
            organizationEntity.CreatedDate = _dbContext.OrganizationMasters.Where(x => x.Id == organizationEntity.Id).Select(x => x.CreatedDate).FirstOrDefault();
            _dbContext.OrganizationMasters.Update(organizationEntity);
            await _dbContext.SaveChangesAsync(token);
            return organizationEntity;
        }
    }
}
