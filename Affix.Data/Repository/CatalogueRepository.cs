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
    public sealed class CatalogueRepository : ICatalogueRepository
    {
        
        private readonly AppointmentDbContext _dbContext;

        public CatalogueRepository(AppointmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CatalogueEntity> CreateCatalogueAsync(CatalogueEntity catalogueentity, CancellationToken token)
        {
            catalogueentity.ModifiedBy = null;
            catalogueentity.ModifiedDate = null;
            catalogueentity.CatalogueGuid = Guid.NewGuid();
            catalogueentity.CreatedDate = DateTime.Now;
            await _dbContext.CatalogueMasters.AddAsync(catalogueentity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.CatalogueMasters.SingleAsync(Catalogue => Catalogue.Id == catalogueentity.Id, token);
        }

        public async Task<IEnumerable<CatalogueEntity>> GetCatalogueListAsync(CancellationToken token)
        {
            return await _dbContext.CatalogueMasters.Where(x => x.Status).ToListAsync(token);
        }
    }
}
