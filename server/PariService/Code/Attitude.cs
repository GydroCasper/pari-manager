using System;
using System.Threading.Tasks;
using AutoMapper;
using PariService.Database;
using PariService.Dto;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code
{
    public class Attitude: IAttitude
    {
        private readonly PariDbContext _dbContext;
        private readonly IMapper _mapper;

        public Attitude(PariDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Create(AttitudeItem attitude, Guid pariId)
        {
            if (attitude == null) throw new PariException("Attitude is empty");

            attitude.Id = Guid.NewGuid();
            var attitudeDbItem = _mapper.Map<Attitudes>(attitude);
            attitudeDbItem.PariId = pariId;
            _dbContext.Add(attitudeDbItem);
            _dbContext.SaveChanges();
            return attitude.Id;
        }
    }
}