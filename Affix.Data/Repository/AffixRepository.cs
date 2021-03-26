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
    public sealed class AffixRepository : IAffixRepository
    {
        private readonly AppointmentDbContext _dbContext;

        public AffixRepository(AppointmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AffixEntity> CreateAffixAsync(AffixEntity affixentity, CancellationToken token)
        {
            //affixentity.ModifiedBy = null;
            affixentity.ModifiedDate = null;
            affixentity.AffixGuid = Guid.NewGuid();
            affixentity.CreatedDate = DateTime.Now;
            string currentMonth = DateTime.Now.Month.ToString();
            affixentity.Month = currentMonth;
            string currentYear = DateTime.Now.Year.ToString();
            affixentity.Year = currentYear;
            await _dbContext.AffixSettingMasters.AddAsync(affixentity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.AffixSettingMasters.SingleAsync(Affix => Affix.Id == affixentity.Id, token);
        }

        public async Task<IEnumerable<AffixEntity>> GetAffixListAsync(CancellationToken token)
        {
            return await _dbContext.AffixSettingMasters.Where(x => x.Status).ToListAsync(token);
        }
    }
}
