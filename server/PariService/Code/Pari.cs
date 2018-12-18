using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PariService.Dto;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code
{
    public class Pari : IPariList
    {
        public async Task<object> Get()
        {
            var result = new List<PariItem>
            {
                new PariItem { Id = Guid.NewGuid(), Name = "Курилы", Date = DateTime.Now, Judges = new List<string> {"Вася", "Петя"}},
                new PariItem { Id = Guid.NewGuid(), Name = "Кокорин на Мамаеве", Date = DateTime.MaxValue, Judges = new List<string> {"Пьерлуиджи Колина"}}
            };

            return result;
        }
    }
}