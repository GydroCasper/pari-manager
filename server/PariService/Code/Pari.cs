using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PariService.Database;
using PariService.Dto;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code
{
    public class Pari : IPariList
    {
        private readonly PariDbContext _dbContext;
        private readonly IMapper _mapper;

        public Pari(PariDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PariItem>> Get()
        {
            var res = await _dbContext.Paris.ToListAsync();
            Console.WriteLine($"1 {JsonConvert.SerializeObject(res.First())}");
            Console.WriteLine($"2 {JsonConvert.SerializeObject(_mapper.Map<PariItem>(res.First()))}");

            return res.Select(x => _mapper.Map<PariItem>(x)).ToList();
        }
    }
}