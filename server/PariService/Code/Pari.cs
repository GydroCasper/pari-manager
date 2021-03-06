﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PariService.Database;
using PariService.Dto;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code
{
    public class Pari : IPariList, IPari
    {
        private readonly PariDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IAttitude _attitude;

        public Pari(PariDbContext dbContext, IMapper mapper, IAttitude attitude)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _attitude = attitude;
        }

        public async Task<List<PariItem>> Get()
        {
            var res = await _dbContext.Paris.ToListAsync();

            return res.Select(x => _mapper.Map<PariItem>(x)).ToList();
        }

        public async Task<PariItem> Get(Guid? id)
        {
            if (!id.HasValue) throw new PariException("Bet is empty");

            var item = (from p in _dbContext.Paris
                join j in _dbContext.Judges on p.Id equals j.PariId
                join uj in _dbContext.Users on j.UserId equals uj.Id
                join a in _dbContext.Attitudes on p.Id equals a.PariId
                join b in _dbContext.Bettors on a.Id equals b.AttitudeId
                join ab in _dbContext.Users on b.UserId equals ab.Id
                group new {Pari = p, Judges = uj, Attitudes = a, Bettors = ab} by new {p.Id, p.Name, p.Date}
                into pari
                where pari.Key.Id == id
                select new PariItem
                {
                    Id = pari.Key.Id,
                    Name = pari.Key.Name,
                    Date = pari.Key.Date,
                    Attitudes = pari
                        .GroupBy(x => x.Attitudes)
                        .Select(x => new AttitudeItem
                        {
                            Id = x.Key.Id,
                            Name = x.Key.Name,
                            Description = x.Key.Description,
                            Bettors = x.Select(y => y.Bettors.DisplayName).ToList()
                        })
                        .ToList(),
                    Judges = pari.Select(x => x.Judges.DisplayName).Distinct().ToList()
                }).SingleOrDefault();

            if (item == null) throw new PariException("Bet not found", $"pariDb: {id}");

            return _mapper.Map<PariItem>(item);
        }

        public async Task<Guid> Create(PariItem pari)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                if (pari == null) throw new PariException("Bet is empty");

                pari.Id = Guid.NewGuid();
                _dbContext.Add(_mapper.Map<Paris>(pari));
                _dbContext.SaveChanges();

                foreach (var attitude in pari.Attitudes)
                {
                    await _attitude.Create(attitude, pari.Id);
                }

                transaction.Commit();
                return pari.Id;
            }
        }
    }
}