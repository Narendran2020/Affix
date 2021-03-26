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
    public sealed class StateRepository : IStateRepository
    {
        private readonly AppointmentDbContext _dbContext;

        public StateRepository(AppointmentDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<StateEntity> CreateStateAsync(StateEntity stateEntity, CancellationToken token)
        {
            stateEntity.ModifiedBy = null;
            stateEntity.CreatedBy = 1;
            stateEntity.ModifiedDate = null;
            stateEntity.CreatedDate = DateTime.Now;
            stateEntity.StateGuid = Guid.NewGuid();
            await _dbContext.StateMasters.AddAsync(stateEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.StateMasters.Include(x => x.Country).SingleAsync(x => x.Id == stateEntity.Id, token);
           /* return await _dbContext.Appointments
                .Include(x => x.AppointmentSchedule)
                                .SingleAsync(appointment => appointment.Id == appointmentEntity.Id, token);*/
        }

        public async Task DeleteStateByIdAsync(int stateId, CancellationToken token)
        {
            var stateEntity = await _dbContext.StateMasters
                .Include(x => x.Country).SingleAsync(x => x.Id == stateId, token);
            stateEntity.Status = false;
            await _dbContext.SaveChangesAsync(token);
        }

        public async Task<IEnumerable<StateEntity>> GetStateListAsync(CancellationToken token)
        {
            return await _dbContext.StateMasters.
                                   Include(x => x.Country).Where(x => x.Status).ToListAsync(token);
        }

        public async Task<StateEntity> UpdateStateByIdAsync(StateEntity stateEntity, CancellationToken token)
        {
            stateEntity.ModifiedDate = DateTime.Now;
            stateEntity.CreatedBy = _dbContext.StateMasters.Where(x => x.Id == stateEntity.Id).Select(x => x.CreatedBy).FirstOrDefault();
            stateEntity.ModifiedBy = 1;
            stateEntity.CreatedDate = _dbContext.StateMasters.Where(x => x.Id == stateEntity.Id).Select(x => x.CreatedDate).FirstOrDefault();
            _dbContext.StateMasters.Update(stateEntity);
            await _dbContext.SaveChangesAsync(token);
            return stateEntity;
        }

    }
}
