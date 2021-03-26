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
    
  
    public sealed class CountryRepository : ICountryRepository
    {
        private readonly AppointmentDbContext _dbContext;

        public CountryRepository(AppointmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CountryEntity> CreateCountryAsync(CountryEntity countryEntity, CancellationToken token)
        {
            countryEntity.ModifiedBy = null;
            countryEntity.CreatedBy = 1;
            countryEntity.ModifiedDate = null;
            countryEntity.CreatedDate = DateTime.Now;
            countryEntity.CountryGuid = Guid.NewGuid();
            await _dbContext.CountryMasters.AddAsync(countryEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.CountryMasters.SingleAsync(x => x.Id == countryEntity.Id, token);
        }

        public async Task DeleteCountryByIdAsync(int countryId, CancellationToken token)
        {
            var countryEntity = await _dbContext.CountryMasters
                .SingleAsync(country => country.Id == countryId, token);
            countryEntity.Status = false;
            await _dbContext.SaveChangesAsync(token);
        }

        public async Task<IEnumerable<CountryEntity>> GetCountryListAsync(CancellationToken token)
        {
            return await _dbContext.CountryMasters
                                   .Where(x => x.Status).ToListAsync(token);
        }

        public async Task<CountryEntity> UpdateCountryByIdAsync(CountryEntity countryEntity, CancellationToken token)
        {
            countryEntity.ModifiedDate = DateTime.Now;
            countryEntity.CreatedBy = _dbContext.CountryMasters.Where(x => x.Id == countryEntity.Id).Select(x => x.CreatedBy).FirstOrDefault();
            countryEntity.ModifiedBy = 1;
            countryEntity.CreatedDate = _dbContext.CountryMasters.Where(x => x.Id == countryEntity.Id).Select(x => x.CreatedDate).FirstOrDefault();
            _dbContext.CountryMasters.Update(countryEntity);
            await _dbContext.SaveChangesAsync(token);
            return countryEntity;
        }
    }
}
